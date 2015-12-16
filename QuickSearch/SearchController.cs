using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using KeePass;
using KeePass.App.Configuration;
using KeePassLib;
using KeePassLib.Utility;
using KeePass.Resources;
using KeePass.UI;


namespace QuickSearch
{

    class SearchController
    {
        static Object listViewLock = new object();
        List<Search> previousSearches = new List<Search>();
        QuickSearchControl quickSearchControl;
        BackgroundWorker backgroundWorker = new BackgroundWorker();
        PwDatabase database;
        EventHandler textUpdateHandler;
        ListView listview;
        //delegate void qsControlUpdateMethod(SearchStatus status)= qsUpdate;
        //MethodInvoker qsControlUpdateMethod = delegate (qsUpdate);
        delegate void QsUpdateMethod(SearchStatus status, bool cancellationPending);
        QsUpdateMethod qsUpdateMethod;

        public EventHandler TextUpdateHandler
        {
            get { return textUpdateHandler; }

        }

        public SearchController(QuickSearchControl qsCcontrol, PwDatabase database, ListView listview)
        {
            this.qsUpdateMethod = qsUpdate;
            this.quickSearchControl = qsCcontrol;
            this.database = database;
            this.textUpdateHandler = new EventHandler(control_TextUpdate);
            this.listview = listview;
            Debug.Assert(listview != null);
            this.backgroundWorker.WorkerSupportsCancellation = true;



        }

        public void ClearPreaviousSeaches()
        {
            this.previousSearches.Clear();
        }

        void control_TextUpdate(object sender, EventArgs e)
        {
            Debug.WriteLine("Text changed to: " + quickSearchControl.Text);
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
            String userText = this.quickSearchControl.Text.Trim();
            // if there is no text, don't search
            if (userText.Equals(String.Empty))
            {
                this.quickSearchControl.UpdateSearchStatus(SearchStatus.Normal);
                return;
            }
            else
            {
                this.quickSearchControl.UpdateSearchStatus(SearchStatus.Pending);
            }
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerSupportsCancellation = true;

            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);

            backgroundWorker.RunWorkerAsync(userText);

        }
        /// <summary>
        /// This method is called by the UI thread. The ListView usually can only be updated from this thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListViewItem[] items = e.Result as ListViewItem[];
            if (items != null)
            {
                /* don't make this. text will be overriden when selection index in listview changes
                string itemsFound = items.Length.ToString() + " " +
                KPRes.SearchItemsFoundSmall;
                Program.MainForm.SetStatusEx(itemsFound);
                */
                Stopwatch sw = Stopwatch.StartNew();
                this.listview.BeginUpdate();

                this.listview.Items.Clear();
                this.listview.Items.AddRange(items);
                this.listview.Items[0].Selected = true;
                this.listview.EndUpdate();
                Debug.WriteLine("ListView updated in elapsed Ticks: " + sw.ElapsedTicks.ToString() + ", elapsed ms: " + sw.ElapsedMilliseconds);

                //(Program.MainForm.Controls["m_statusMain"] as ToolStrip).Items["m_statusPartSelected"].Text = String.Empty;

            }


        }

        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;



            //this.quickSearchControl.UpdateSearchStatus()
            String userText = (string)e.Argument;
            Search newSearch = new Search(userText);

            bool previousSearchFound = false;
            lock (this)
            {
                //this.quickSearchControl.Invoke(new MethodInvoker(delegate()
                //{
                //    quickSearchControl.UpdateSearchStatus(SearchStatus.Pending);
                //}));

                for (int i = previousSearches.Count - 1; i >= 0; i--)
                {
                    if (previousSearches[i].ParamEquals(newSearch))
                    {
                        previousSearchFound = true;
                        newSearch = previousSearches[i];
                        Debug.WriteLine("found exact match in previousSearches");
                        break;
                    }
                }
                if (previousSearchFound == false)
                {
                    for (int i = previousSearches.Count - 1; i >= 0; i--)
                    {
                        if (previousSearches[i].IsRefinedSearch(newSearch))
                        {

                            previousSearchFound = true;
                            newSearch.performSearch(previousSearches[i].resultEntries, worker);
                            Debug.WriteLine("Search is refined search");
                            break;
                        }
                    }
                }
            }
            if (previousSearchFound == false)
            {
                newSearch.performSearch(database.RootGroup, worker);

            }
            //if (!worker.CancellationPending)
            //{
            lock (this)
            {

                this.previousSearches.Add(newSearch);
                if (!worker.CancellationPending)
                {
                    SearchStatus status;
                    if (newSearch.resultEntries.Count == 0)
                    {
                        status = SearchStatus.Error;
                    }
                    else
                    {
                        status = SearchStatus.Success;
                    }
                    //this.quickSearchControl.Invoke(new MethodInvoker(delegate()
                    //{
                    //    quickSearchControl.UpdateSearchStatus(status);
                    //}));
                    this.quickSearchControl.Invoke(qsUpdateMethod, status, worker.CancellationPending);

                }
            }
            //}
            //e.Result = newSearch.resultEntries;

            // for testing
            // only update the ListView if there are results
            if (newSearch.resultEntries.Count != 0)
            {
                // using the ListView itself for locking caused problems

                if (!worker.CancellationPending)
                {

                    //this.listview.Groups.Clear();

                    ListViewItem[] items = new ListViewItem[newSearch.resultEntries.Count];
                    int i = 0;
                    foreach (PwEntry entry in newSearch.resultEntries)
                    {
                        if (worker.CancellationPending)
                        {


                            return;
                            //break;
                        }
                        items[i] = AddEntryToList(entry);
                        i++;
                    }
                    lock (listViewLock)
                    {
                        if (!worker.CancellationPending)
                        {

                            //Control.CheckForIllegalCrossThreadCalls = false;
                            //this.listview.BeginUpdate();

                            //this.listview.Items.Clear();
                            //this.listview.Items.AddRange(items);
                            //this.listview.Items[0].Selected = true;
                            //this.listview.EndUpdate();
                            ////Debug.WriteLine("Setting CheckForIllegalCrossThreadCalls to true");
                            //Control.CheckForIllegalCrossThreadCalls = true;
                            e.Result = items;
                        }
                    }
                }
            }









            // set Cancel if necessary. Otherwise the completed method won't know about the status.
            //if (worker.CancellationPending)
            //{
            //    e.Cancel = true;
            //}
            //else // the search was completed
            //{

            //}



        }
        private ListViewItem AddEntryToList(PwEntry pe)
        {


            ListViewItem lvi = new ListViewItem();
            lvi.Tag = new PwListItem(pe);

            //if (pe.Expires && (pe.ExpiryTime <= m_dtCachedNow))
            //{
            //    lvi.ImageIndex = (int)PwIcon.Expired;
            //    if (m_fontExpired != null) lvi.Font = m_fontExpired;
            //}
            //else 
            if (pe.CustomIconUuid.EqualsValue(PwUuid.Zero))
                lvi.ImageIndex = (int)pe.IconId;
            else
                lvi.ImageIndex = (int)PwIcon.Count +
                    database.GetCustomIconIndex(pe.CustomIconUuid);

            //if (m_bEntryGrouping)
            //{
            //    PwGroup pgContainer = pe.ParentGroup;
            //    PwGroup pgLast = ((m_lvgLastEntryGroup != null) ?
            //        (PwGroup)m_lvgLastEntryGroup.Tag : null);

            //    Debug.Assert(pgContainer != null);
            //    if (pgContainer != null)
            //    {
            //        if (pgContainer != pgLast)
            //        {
            //            m_lvgLastEntryGroup = new ListViewGroup(
            //                pgContainer.GetFullPath());
            //            m_lvgLastEntryGroup.Tag = pgContainer;

            //            m_lvEntries.Groups.Add(m_lvgLastEntryGroup);
            //        }

            //        lvi.Group = m_lvgLastEntryGroup;
            //    }
            //}

            if (!pe.ForegroundColor.IsEmpty)
                lvi.ForeColor = pe.ForegroundColor;

            if (!pe.BackgroundColor.IsEmpty)
                lvi.BackColor = pe.BackgroundColor;
            // else if(Program.Config.MainWindow.EntryListAlternatingBgColors &&
            //	((m_lvEntries.Items.Count & 1) == 1))
            //	lvi.BackColor = m_clrAlternateItemBgColor;

            // m_bOnlyTans &= PwDefs.IsTanEntry(pe);
            //if (m_bShowTanIndices && m_bOnlyTans)
            //{
            //    string strIndex = pe.Strings.ReadSafe(PwDefs.TanIndexField);

            //    if (strIndex.Length > 0) lvi.Text = strIndex;
            //    else lvi.Text = PwDefs.TanTitle;
            //}
            //else 
            lvi.Text = GetEntryFieldEx(pe, 0, true);

            for (int iColumn = 1; iColumn < listview.Columns.Count; ++iColumn)
                lvi.SubItems.Add(GetEntryFieldEx(pe, iColumn, true));

            //listview.Items.Add(lvi);
            Debug.Assert(lvi != null);
            return lvi;
        }


        private string GetEntryFieldEx(PwEntry pe, int iColumnID, bool bAsterisksIfHidden)
        {
            List<AceColumn> l = Program.Config.MainWindow.EntryListColumns;
            if ((iColumnID < 0) || (iColumnID >= l.Count)) { Debug.Assert(false); return string.Empty; }

            AceColumn col = l[iColumnID];
            if (bAsterisksIfHidden && col.HideWithAsterisks) return PwDefs.HiddenPassword;

            string str = string.Empty;
            switch (col.Type)
            {
                case AceColumnType.Title: str = pe.Strings.ReadSafe(PwDefs.TitleField); break;
                case AceColumnType.UserName: str = pe.Strings.ReadSafe(PwDefs.UserNameField); break;
                case AceColumnType.Password: str = pe.Strings.ReadSafe(PwDefs.PasswordField); break;
                case AceColumnType.Url: str = pe.Strings.ReadSafe(PwDefs.UrlField); break;
                case AceColumnType.Notes: str = pe.Strings.ReadSafe(PwDefs.NotesField); break;
                case AceColumnType.CreationTime: str = TimeUtil.ToDisplayString(pe.CreationTime); break;
                case AceColumnType.LastAccessTime: str = TimeUtil.ToDisplayString(pe.LastAccessTime); break;
                case AceColumnType.LastModificationTime: str = TimeUtil.ToDisplayString(pe.LastModificationTime); break;
                case AceColumnType.ExpiryTime:
                    if (pe.Expires) str = TimeUtil.ToDisplayString(pe.ExpiryTime);
                    else str = KPRes.NeverExpires;
                    break;
                case AceColumnType.Uuid: str = pe.Uuid.ToHexString(); break;
                case AceColumnType.Attachment: str = pe.Binaries.KeysToString(); break;
                case AceColumnType.CustomString:
                    str = pe.Strings.ReadSafe(col.CustomName);
                    break;
                case AceColumnType.PluginExt:
                    str = Program.ColumnProviderPool.GetCellData(col.CustomName, pe);
                    break;
                case AceColumnType.OverrideUrl: str = pe.OverrideUrl; break;
                case AceColumnType.Tags:
                    str = StrUtil.TagsToString(pe.Tags, true);
                    break;
                case AceColumnType.ExpiryTimeDateOnly:
                    if (pe.Expires) str = TimeUtil.ToDisplayStringDateOnly(pe.ExpiryTime);
                    else str = KPRes.NeverExpires;
                    break;
                case AceColumnType.Size:
                    str = StrUtil.FormatDataSizeKB(pe.GetSize());
                    break;
                case AceColumnType.HistoryCount:
                    str = pe.History.UCount.ToString();
                    break;
                default: Debug.Assert(false); break;
            }

            return str;
        }


        void qsUpdate(SearchStatus status, bool cancellationPending)
        {

            if (!cancellationPending)
            {
                this.quickSearchControl.UpdateSearchStatus(status);
            }

        }

    }


}
