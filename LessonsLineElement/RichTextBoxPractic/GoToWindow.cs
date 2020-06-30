using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxPractic
{
    public partial class GoToWindow : Form
    {
        public int LineNumber { get; set; }

        public GoToWindow()
        {
            InitializeComponent();
        }

        private void Button_Cancel_Click(object sender, EventArgs e) =>
            Close();

        private void Button_GoTo_Click(object sender, EventArgs e)
        {
            if(textBox_LineNumber.Text != null)
                LineNumber = int.Parse(textBox_LineNumber.Text);
            Close();
        }
    }
}
