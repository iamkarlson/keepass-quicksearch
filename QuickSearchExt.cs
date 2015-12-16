using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


using KeePass.Plugins;
using KeePass.Forms;
using KeePass.UI;
using KeePass.Resources;

using KeePassLib;
using KeePassLib.Security;
using QuickSearch.Properties;

using System.Drawing;
namespace QuickSearch
{
    public class QuickSearchExt : Plugin
    {
        public static IPluginHost host;

        public static Search search;

        QuickSearchControl qsControl;

        public override bool Initialize(IPluginHost host)
        {
            QuickSearchExt.host = host;
            //if (Settings.Default.RemoveQuickFind)
            //{
                //removeBuiltinQuickFind(host);
            //}
            updateQuickFindControl();
            //toolStrip.Refresh();
            this.qsControl = addQuickSearchControl(host);
            new ActiveControllerManager(host, this.qsControl);
            //host.CustomConfig.SetBool("QuickSearch.testvalue", true);

            //Settings.Default.SearchInTitle = false;

            //test --------------
            //Settings set = new Settings();


            ////set.tsetting.Add("bla", "blu");
            //set.tsetting = new System.Collections.Specialized.StringDictionary();
            //set.tsetting.Add("alpha", "alphavalue");
            //set.tsetting.Add("beta", "betavalue");
            //set.Settingbool = false;
            ////Debug.WriteLine(set.tsetting.ToString());
            //set.Save();

            //testend ------------

            GlobalWindowManager.WindowAdded += new EventHandler<GwmWindowEventArgs>(GlobalWindowManager_WindowAdded);

            return true;
            //return base.Initialize(host);
        }

        void GlobalWindowManager_WindowAdded(object sender, GwmWindowEventArgs e)
        {
            OptionsForm optionsForm = e.Form as OptionsForm;
            if (optionsForm != null)
            {

                TabPage tp = new TabPage("QuickSearch");
                tp.BackColor = SystemColors.Window;
                tp.AutoScroll = true;
                OptionsControl optionsControl = new OptionsControl();
                //optionsControl.BackColor = SystemColors.Control;
                tp.Controls.Add(optionsControl);
                TabControl tc = optionsForm.Controls.Find("m_tabMain", false)[0] as TabControl;
                //System.Drawing.Image image = Resources.search_icon_16;
                //tc.ImageList.Images.Add("QuickSearch", image);
                //tp.ImageKey = "QuickSearch";
                tc.TabPages.Add(tp);
                //optionsForm.VisibleChanged += new EventHandler(delegate(object o, EventArgs em)
                //{
                //    em.
                //});
                optionsControl.Dock = DockStyle.Top;
                Button buttonOK = optionsForm.Controls.Find("m_btnOK", false)[0] as Button;
                buttonOK.Click += delegate(object senderr, EventArgs evtarg) {
                    optionsControl.OKButtonPressed(senderr, evtarg);
                    //removeBuiltinQuickFind(host);
                    this.qsControl.UpdateWidth();
                    //this.qsControl.
                    
                };
                //buttonOK.Click += new EventHandler(optionsControl.OKButtonPressed);

            }
        }





        private QuickSearchControl addQuickSearchControl(IPluginHost host)
        {
            QuickSearchControl myControl = new QuickSearchControl();
            //myControl.Enabled = false;
            ToolStripControlHost myToolStripControlHost = new ToolStripControlHost(myControl);
            myToolStripControlHost.AutoSize = true;

            Control.ControlCollection mainWindowControls = host.MainWindow.Controls;
            CustomToolStripEx toolStrip = (CustomToolStripEx)mainWindowControls["m_toolMain"];
            toolStrip.Items.Add(myToolStripControlHost);
            //host.MainWindow.FileOpened += new EventHandler<FileOpenedEventArgs>(MainWindow_FileOpened);


            //host.MainWindow.Shown += delegate(object o, EventArgs e) { myControl.ParentForm.ActiveControl = myControl.comboBoxSearch; };
            //myControl.comboBox.TextChanged += new EventHandler(comboBox1_TextChanged);
            return myControl;
        }

        //void MainWindow_FileOpened(object sender, FileOpenedEventArgs e)
        //{
        //    myControl.ParentForm.ActiveControl = myControl.comboBoxSearch; };
        //}





        //static void comboBox1_TextChanged(object sender, EventArgs e)
        //{
        //    foreach (PwEntry entry in host.Database.RootGroup.Entries)
        //    {




        //        foreach (KeyValuePair<string,ProtectedString> kv in entry.Strings)
        //        {
        //            if (kv.Value.ReadString().Contains("uiedriaenn234aai"))
        //            {
        //                System.Diagnostics.Debug.WriteLine("gefunden");
        //            }

        //        }
        //    }

        //}


        void updateQuickFindControl()
        {
            Control.ControlCollection mainWindowControls = host.MainWindow.Controls;
            CustomToolStripEx toolStrip = (CustomToolStripEx)mainWindowControls["m_toolMain"];
            ToolStripItem comboBox = toolStrip.Items["m_tbQuickFind"];

            Binding binding = new Binding("Visible", Settings.Default, "ShowQuickFind");
            ((ToolStripComboBox)comboBox).ComboBox.DataBindings.Add(binding);
            //if (Settings.Default.HideQuickFind)
            //{
            //    comboBox.Visible = false;
            //}
            //else
            //{
            //    comboBox.Visible = true;
            //}

        }
        /// <summary>
        /// Removes the builtin "QuickFind" ComboBox
        /// </summary>
        /// <param name="host"></param>
        private static void removeBuiltinQuickFind(IPluginHost host)
        {
            Control.ControlCollection mainWindowControls = host.MainWindow.Controls;
            CustomToolStripEx toolStrip = (CustomToolStripEx)mainWindowControls["m_toolMain"];
            ToolStripItem comboBox = toolStrip.Items["m_tbQuickFind"];
            //Debug.Assert(comboBox != null);
            if (comboBox!=null)
            {
                comboBox.Visible = false;
                //toolStrip.Items.Remove(comboBox);
                comboBox.Enabled = false; 
            }
        }


        public override Image SmallIcon
        {
            get
            {
                return Resources.search_icon_16;
            }
        }


        public override void Terminate()
        {
            Settings.Default.Save();
            base.Terminate();
        }
    }
}
