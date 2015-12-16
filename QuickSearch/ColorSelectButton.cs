using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickSearch
{
    public partial class ColorSelectButton : UserControl
    {


        public Color Color
        {
            get { return this.BackColor; }
            set
            {

                this.BackColor = value;
            }
        }

        public ColorSelectButton()
        {
            InitializeComponent();
        }
        public ColorSelectButton(Color color)
            : this()
        {
            this.Color = color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = this.Color;
            this.colorDialog.ShowDialog();
            this.BackColor = this.colorDialog.Color;
            this.Color = this.colorDialog.Color;
        }
    }
}
