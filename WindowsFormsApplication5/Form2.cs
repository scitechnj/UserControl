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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.hackyTextBox1.KeyPressed += hackyTextBox1_KeyPressed;
        }

        void hackyTextBox1_KeyPressed(object sender, MyKeyPressEventArgs e)
        {
            e.Handled = true;
            //MessageBox.Show(e.KeyChar.ToString());
        }
    }
}
