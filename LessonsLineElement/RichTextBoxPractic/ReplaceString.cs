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
    public partial class ReplaceString : Form
    {
        public string ReplacementString { get; set; }
        public string NewString { get; set; }

        public ReplaceString()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if(textBox_One.Text.Length != 0)
            {
                ReplacementString = textBox_One.Text;
                NewString = textBox_Two.Text;
            }
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e) =>
            Close();
    }
}
