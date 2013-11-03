using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DemoControl ctl = new DemoControl();
            ctl.Size = new Size(400, 200);
            this.Controls.Add(ctl);
            //ctl.TextSubmitted += TextSubmitted;

            this.textBox1.KeyPress += textBox1_KeyPress;

        }

        void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }


        private void TextSubmitted(object sender, TextSubmittedEventArgs e)
        {
            MessageBox.Show(e.Text);
        }
    }
}
