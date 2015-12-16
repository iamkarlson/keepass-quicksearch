using System;
using System.Drawing;
using System.Windows.Forms;
using QuickSearch.Properties;
using System.Diagnostics;

namespace QuickSearch
{
    public partial class QuickSearchControl : UserControl
    {

        //public event EventHandler TextUpdate;
        public new String Text
        {
            get { return this.comboBoxSearch.Text; }
            set
            {
                this.comboBoxSearch.Text=value;
            }

        }

        public new event EventHandler TextChanged
        {
            add
            {
                this.comboBoxSearch.TextChanged += value;

            }
            remove
            {
                this.comboBoxSearch.TextChanged -= value;
            }


        }
        public QuickSearchControl()
        {
            InitializeComponent();
            this.UpdateWidth();
            this.comboBoxSearch.GotFocus += new EventHandler(comboBoxSearch_GotFocus);
            this.comboBoxSearch.LostFocus += new EventHandler(comboBoxSearch_LostFocus);

            this.Controls.Remove(this.tableLayoutPanelMain);
            //this.DoubleBuffered = true;
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            //this.BackColor = Color.Red;
            // The Dropdown has no parent form so it has no BindingContext.
            // Binding won't work for it's hosted controls
            // create a new BindingContext to solve this bug
            this.toolStripDropDownSettings.BindingContext = new BindingContext();



            // Create a host for the tableLayoutPanelMain
            // Only a ToolStripControlHost can be added to a ToolStripDropDown
            // set tableLayoutPanelMain as it's control
            ToolStripControlHost settingsPanelHost = new ToolStripControlHost(this.tableLayoutPanelMain);

            // set the Margin to zero so we don't see white lines between the border of the ControlHost and the DropDown
            settingsPanelHost.Margin = Padding.Empty;

            // set the position of the Panel
            this.tableLayoutPanelMain.Location = Point.Empty;
            // add the ToolStripControlHost to the DropDown
            this.toolStripDropDownSettings.Items.Add(settingsPanelHost);
            this.toolStripDropDownSettings.KeyDown += new KeyEventHandler(toolStripDropDownSettings_KeyDown);



        }

        void comboBoxSearch_LostFocus(object sender, EventArgs e)
        {
            Debug.WriteLine("Focus Lost");

            this.setBackColorNormal();

            this.OnLostFocus(e);
        }

        void comboBoxSearch_GotFocus(object sender, EventArgs e)
        {
            Debug.WriteLine("Got Focus");
            this.setBackColorNormal();
        }



        void toolStripDropDownSettings_KeyDown(object sender, KeyEventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Debug.WriteLine("in onPaint " + e.ClipRectangle
            //    );

            //// This example assumes the existence of a form called Form1.
            //BufferedGraphicsContext currentContext;
            //BufferedGraphics myBuffer;
            //// Gets a reference to the current BufferedGraphicsContext
            //currentContext = BufferedGraphicsManager.Current;
            //// Creates a BufferedGraphics instance associated with Form1, and with 
            //// dimensions the same size as the drawing surface of Form1.
            //myBuffer = currentContext.Allocate(e.Graphics,
            //   this.DisplayRectangle);
            ////base.OnPaint(new PaintEventArgs(myBuffer.Graphics, e.ClipRectangle));
            ////myBuffer.Render();

            base.OnPaint(e);
        }


        //void Control_ControlAdded(object sender, ControlEventArgs e)
        //{
        //    e.Control.ControlAdded += new ControlEventHandler(Control_ControlAdded);

        //    e.Control.PreviewKeyDown += new PreviewKeyDownEventHandler(Control_PreviewKeyDown);

        //}

        // this event has to be consumed by all checkboxes and the DropDown. 
        // The TableLayoutPanels and GroupBoxes don't seem to raise this event
        void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
            {
                this.toolStripDropDownSettings.Hide();
                String keyToSend = new KeysConverter().ConvertToString(e.KeyCode);
                if (!e.Shift)
                {
                    keyToSend = keyToSend.ToLowerInvariant();
                }
                this.comboBoxSearch.Focus();
                //SendKeys.Send("K");
            }

            System.Diagnostics.Debug.WriteLine("in preview");


            //this.toolStripDropDownSettings.Close();

            //String pressedKey = e.KeyCode.ToString();


            ////if (!e.Shift)
            ////{
            ////    pressedKey = pressedKey.ToLower();
            ////}
            //comboBoxSearch.SelectedText = pressedKey;


            //comboBoxSearch.SelectionStart = comboBoxSearch.Text.Length;


        }



        public void UpdateSearchStatus(SearchStatus status)
        {
            switch (status)
            {
                case SearchStatus.Success:
                    this.setBackColorSuccess();
                    break;
                case SearchStatus.Error:
                    this.setBackColorError();
                    break;
                case SearchStatus.Pending:
                    this.setBackColorSearching();
                    break;
                case SearchStatus.Normal:
                    this.setBackColorNormal();
                    break;
                default:
                    break;
            }
        }



        private void buttonConfig_MouseEnter(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Mouse Enter event");
            this.ButtonDropdownSettings.ImageIndex = 1;
            //this.setBackColorError();
            //this.ButtonDropdownSettings.BackColor = Color.Red;
        }

        private void buttonConfig_MouseLeave(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Mouse Leave event");
            if (this.toolStripDropDownSettings.Visible == false)
            {
                this.ButtonDropdownSettings.ImageIndex = 0;

            }
            //this.setBackColorNormalUnFocused();
        }





        private void ButtonDropdownSettings_Click(object sender, EventArgs e)
        {
            //Stopwatch sw = Stopwatch.StartNew();
            // show the DropDown
            this.toolStripDropDownSettings.Show(ButtonDropdownSettings, 0, ButtonDropdownSettings.Bottom);
            //Debug.WriteLine("show toolstip ms: " + sw.ElapsedMilliseconds);
            // disable the button so that clicking again will close the DropDown but not raise this event again
            this.ButtonDropdownSettings.Enabled = false;
            //Properties.Settings.Default.SearchInTitle = false;
        }




        private void toolStripDropDownSettings_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            this.ButtonDropdownSettings.Enabled = true;
            // we need to check if mouse is over config button. Otherwise icon would be resetted although mouse is over config button.
            // get a mouse position relative to the Button
            Point mousePosition = ButtonDropdownSettings.PointToClient(Control.MousePosition);
            if (!ButtonDropdownSettings.ClientRectangle.IntersectsWith(new Rectangle(mousePosition, System.Drawing.Size.Empty)))
            {
                ButtonDropdownSettings.ImageIndex = 0;
            }
            ButtonDropdownSettings.Enabled = true;
            //System.Diagnostics.Debug.WriteLine("dropdown closed");

        }

        void SetBackColor(Color color)
        {
            this.comboBoxSearch.BackColor = color;
            this.ButtonDropdownSettings.BackColor = color;
            this.ButtonDropdownSettings.FlatAppearance.MouseDownBackColor = color;
            this.ButtonDropdownSettings.FlatAppearance.MouseOverBackColor = color;

        }

        void setBackColorError()
        {
            this.SetBackColor(Settings.Default.BackColorOnError);
            //this.comboBoxSearch.BackColor = Settings.Default.BackColorOnError;
            //this.ButtonDropdownSettings.BackColor = Settings.Default.BackColorOnError;
            //this.ButtonDropdownSettings.FlatAppearance.MouseDownBackColor = Settings.Default.BackColorOnError;
            //this.ButtonDropdownSettings.FlatAppearance.MouseOverBackColor = Settings.Default.BackColorOnError;
            ////this.ButtonDropdownSettings.FlatAppearance.BorderColor= Settings.Default.BackColorError;



        }

        void setBackColorSearching()
        {
            this.SetBackColor(Settings.Default.BackColorSearching);
        }

        void setBackColorSuccess()
        {
            this.SetBackColor(Settings.Default.BackColorSuccess);
        }

        void setBackColorNormal()
        {
            if (this.comboBoxSearch.Focused)
            {
                this.SetBackColor(Settings.Default.BackColorNormalFocused);
            }
            else
            {
                this.SetBackColor(Settings.Default.BackColorNormalUnFocused);
            }
            //this.comboBoxSearch.BackColor = Color.White;
            //this.ButtonDropdownSettings.BackColor = Color.White;
            //this.ButtonDropdownSettings.FlatAppearance.MouseDownBackColor = Color.White;
            //this.ButtonDropdownSettings.FlatAppearance.MouseOverBackColor = Color.White;
            ////this.ButtonDropdownSettings.FlatAppearance.BorderColor = Color.White;
        }



        public void UpdateWidth()
        {
            this.Width = Settings.Default.ControlWidth;
            this.comboBoxSearch.Invalidate();
            //this.DoubleBuffered = true;
            //this.Parent.


            //this.comboBoxSearch.Invalidate();
            //this.Invalidate();
        }

































    }
}
