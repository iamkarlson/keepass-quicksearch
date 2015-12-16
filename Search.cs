using System;
using System.Collections.Generic;
using System.Text;
using KeePassLib;
using KeePassLib.Security;
using QuickSearch.Properties;
using System.Diagnostics;
using System.ComponentModel;

namespace QuickSearch
{
    public class Search
    {
        /// <summary>
        /// the text the user put into the search box
        /// </summary>
        string userSeachString;

        /// <summary>
        /// the splitted user input text
        /// </summary>
        string[] searchStrings;

        /// <summary>
        /// names of the standard fields that will be searched in a Password entry. 
        /// </summary>
        List<string> searchFields;

        StringComparison searchStringComparison;

        bool SearchInTitle;
        bool SearchInUrl;
        bool SearchInUserName;
        bool SearchInNotes;
        bool SearchInPassword;
        bool searchInOther;
        bool SearchExcludeExpired;

        public List<PwEntry> resultEntries;



        Properties.Settings searchSettings = Properties.Settings.Default;

        PwGroup rootGroup;
        public Search(String userSearchText)
        {
            this.SearchInTitle = Settings.Default.SearchInTitle;
            this.SearchInUrl = Settings.Default.SearchInUrl;
            this.SearchInUserName = Settings.Default.SearchInUserName;
            this.SearchInNotes = Settings.Default.SearchInNotes;
            this.SearchInPassword = Settings.Default.SearchInPassword;
            this.searchInOther = Settings.Default.SearchInOther;
            this.SearchExcludeExpired = Settings.Default.SearchExcludeExpired;
            if (Settings.Default.SearchCaseSensitive)
            {
                this.searchStringComparison = StringComparison.Ordinal;
            }
            else
            {
                this.searchStringComparison = StringComparison.OrdinalIgnoreCase;
            }
            this.userSeachString = userSearchText;
            this.searchStrings = this.userSeachString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            this.resultEntries = new List<PwEntry>();
        }
        public Search(PwGroup rootGroup)
        {
            this.rootGroup = rootGroup;

            this.SearchInTitle = Settings.Default.SearchInTitle;
            this.SearchInUrl = Settings.Default.SearchInUrl;
            this.SearchInUserName = Settings.Default.SearchInUserName;
            this.SearchInNotes = Settings.Default.SearchInNotes;
            this.SearchInPassword = Settings.Default.SearchInPassword;
            this.searchInOther = Settings.Default.SearchInOther;
        }

        public void performSearch(List<PwEntry> entries, BackgroundWorker worker)
        {
            this.searchInList(entries, worker);

        }

        public void performSearch(PwGroup pwGroup, BackgroundWorker worker)
        {
            Debug.WriteLine("Starting a new Search in Group");
            Stopwatch sw = Stopwatch.StartNew();


            if (pwGroup != null)
            {
                searchInList(pwGroup.Entries, worker);
                foreach (PwGroup group in pwGroup.Groups)
                {
                    this.performSearch(group, worker);
                }
            }
            Debug.WriteLine("End of Search in Group. Worker cancelled: " + worker.CancellationPending + ". elapsed Ticks: " + sw.ElapsedTicks.ToString() + " elapsed ms: " + sw.ElapsedMilliseconds);
        }

        private void searchInList(IEnumerable<PwEntry> pWList, BackgroundWorker worker)
        {
            foreach (PwEntry entry in pWList)
            {
                // check if cancellation was requested. In this case don't continue with the search
                if (worker.CancellationPending)
                {
                    return;
                }

                if (this.SearchExcludeExpired && entry.Expires && entry.ExpiryTime >= DateTime.Now)
                {
                    break;
                }


                foreach (KeyValuePair<string, ProtectedString> pair in entry.Strings)
                {
                    // check if cancellation was requested. In this case don't continue with the search
                    if (worker.CancellationPending)
                    {
                        return;
                    }

                    //sw = Stopwatch.StartNew();
                    //if (searchFields.Contains(pair.Key) || (searchOtherFields && !PwDefs.IsStandardField(pair.Key)))
                    if (
                           (this.SearchInTitle && pair.Key.Equals(PwDefs.TitleField))
                        || (this.SearchInUrl && pair.Key.Equals(PwDefs.UrlField))
                        || (this.SearchInUserName && pair.Key.Equals(PwDefs.UserNameField))
                        || (this.SearchInNotes && pair.Key.Equals(PwDefs.NotesField))
                        || (this.SearchInPassword && pair.Key.Equals(PwDefs.PasswordField))
                        || (this.searchInOther && !PwDefs.IsStandardField(pair.Key))
                        )
                    {
                        //Debug.WriteLine("if key "+sw.ElapsedTicks);
                        bool allSearchStringsMatched = true;
                        foreach (String searchString in searchStrings)
                        {
                            // check if cancellation was requested. In this case don't continue with the search
                            if (worker.CancellationPending)
                            {
                                return;
                            }
                            //sw = Stopwatch.StartNew();
                            if (pair.Value.ReadString().IndexOf(searchString, this.searchStringComparison) < 0)
                            {
                                //Debug.WriteLine("if value " + sw.ElapsedTicks);
                                // no match in this field
                                // continue with next field
                                allSearchStringsMatched = false;
                                break;


                            }
                            // if no break occured all words have been found. This entry is a match

                        }
                        if (allSearchStringsMatched)
                        {
                            this.resultEntries.Add(entry);
                            // this entry was a match. The other fields can be skipped
                            // continue with the next entry
                            break;
                        }

                    }
                }
            }
        }



        //update the parametes relevant to the search, but not the search string
        void updateParams()
        {
            this.SearchInTitle = Settings.Default.SearchInTitle = true;
            this.SearchInUrl = Settings.Default.SearchInUrl = true;
            this.SearchInUserName = Settings.Default.SearchInUserName = true;
            this.SearchInNotes = Settings.Default.SearchInNotes = true;
            this.SearchInPassword = Settings.Default.SearchInPassword = true;
            this.searchInOther = Settings.Default.SearchInOther = true;

            this.searchFields = new List<string>();
            if (Settings.Default.SearchInTitle)
            {
                searchFields.Add(PwDefs.TitleField);
            }
            if (Settings.Default.SearchInUrl)
            {
                searchFields.Add(PwDefs.UrlField);
            }

            //for testing only
            searchFields.Add(PwDefs.NotesField);
            searchFields.Add(PwDefs.PasswordField);
            searchFields.Add(PwDefs.UserNameField);



        }

        //public void performSearch(String searchText)
        //{

        //    this.updateParams();
        //    this.resultEntries = new List<PwEntry>();
        //    this.searchStrings = searchText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        //    sw.Start();
        //    this.performSearch(rootGroup);
        //    System.Diagnostics.Debug.WriteLine("elapsed Ticks: " + sw.ElapsedTicks.ToString() + " elapsed ms: " + sw.ElapsedMilliseconds);
        //    //foreach (PwEntry entry in this.resultEntries)
        //    //{
        //    //    System.Diagnostics.Debug.WriteLine(entry.Strings.ReadSafe(PwDefs.TitleField));
        //    //}
        //    //System.Diagnostics.Debug.WriteLine(this.resultEntries.ToString());
        //}
        public bool SettingsEquals(Search search)
        {
            return this.SearchInTitle == search.SearchInTitle &&
            this.SearchInUrl == search.SearchInUrl &&
            this.SearchInUserName == search.SearchInUserName &&
            this.SearchInNotes == search.SearchInNotes &&
            this.SearchInPassword == search.SearchInPassword &&
            this.searchInOther == search.searchInOther &&
            this.SearchExcludeExpired == search.SearchExcludeExpired &&
            this.searchStringComparison == search.searchStringComparison;
        }

        /// <summary>
        /// checks if the search specific settings are equal and if the search text is more specific
        /// </summary>
        /// <param name="search"></param>
        /// <returns>true if search is a refinement of this</returns>
        public bool IsRefinedSearch(Search search)
        {

            return this.SettingsEquals(search) && search.userSeachString.Contains(this.userSeachString);
        }

        public bool ParamEquals(Search search)
        {
            return this.userSeachString.Equals(search.userSeachString) && this.SettingsEquals(search);

        }

    }
}
