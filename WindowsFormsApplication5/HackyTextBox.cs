using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class HackyTextBox : UserControl
    {
        public HackyTextBox()
        {
            InitializeComponent();
            this.KeyPress += HackyTextBox_KeyPress;
        }

        private void HackyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyKeyPressEventArgs args = new MyKeyPressEventArgs(e.KeyChar);

            if (KeyPressed != null)
            {
                KeyPressed(this, args);
            }
            if (!args.Handled)
            {
                this.label1.Text += e.KeyChar.ToString();     
            }
           
        }

        public event MyKeyPressBaby KeyPressed;
    }

    public delegate void MyKeyPressBaby(object sender, MyKeyPressEventArgs e);

    public class MyKeyPressEventArgs
    {
        public MyKeyPressEventArgs(char c)
        {
            this.KeyChar = c;
        }

        public char KeyChar { get; private set; }
        public bool Handled { get; set; }
    }
}
