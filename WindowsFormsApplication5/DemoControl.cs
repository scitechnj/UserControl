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
    public partial class DemoControl : UserControl
    {
        public DemoControl()
        {
            InitializeComponent();
            this.button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextSubmitted(this, new TextSubmittedEventArgs(this.textBox1.Text));
        }

        public event TextSubmittedHandler TextSubmitted;
    }

    public class TextSubmittedEventArgs : EventArgs
    {
        public TextSubmittedEventArgs(string text)
        {
            this.Text = text;
        }

        public string Text { get; private set; }
    }

    public delegate void TextSubmittedHandler(object sender, TextSubmittedEventArgs e);
}
