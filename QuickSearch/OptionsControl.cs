using System;
using System.Windows.Forms;
using QuickSearch.Properties;

namespace QuickSearch
{
    public partial class OptionsControl : UserControl
    {
        public OptionsControl()
        {
            InitializeComponent();
            this.ControlWidth.Value = Settings.Default.ControlWidth;
            this.chBoxFocusOnOpen.Checked = Settings.Default.FocusOnOpen;
            this.chBoxRemoveQuickFind.Checked = !Settings.Default.ShowQuickFind;
            this.colorSelectButtonError.Color = Settings.Default.BackColorOnError;
            this.colorSelectButtonFocused.Color = Settings.Default.BackColorNormalFocused;
            this.colorSelectButtonPending.Color = Settings.Default.BackColorSearching;
            this.colorSelectButtonUnfocused.Color = Settings.Default.BackColorNormalUnFocused;
            this.colorSelectButtonSuccess.Color = Settings.Default.BackColorSuccess;


        }

        public void OKButtonPressed(Object sender, EventArgs e)
        {
            Settings.Default.ControlWidth = (int)this.ControlWidth.Value;
            Settings.Default.FocusOnOpen = this.chBoxFocusOnOpen.Checked;
            Settings.Default.ShowQuickFind = !this.chBoxRemoveQuickFind.Checked;
            Settings.Default.BackColorOnError = this.colorSelectButtonError.Color;
            Settings.Default.BackColorNormalFocused = this.colorSelectButtonFocused.Color;
            Settings.Default.BackColorSearching = this.colorSelectButtonPending.Color;
            Settings.Default.BackColorNormalUnFocused = this.colorSelectButtonUnfocused.Color;
            Settings.Default.BackColorSuccess = this.colorSelectButtonSuccess.Color;

        }


    }
}
