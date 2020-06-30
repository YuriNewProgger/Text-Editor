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
    public partial class FindString : Form
    {
        public string SearchString { get; set; }

        public FindString()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if(textBox_FindString.Text.Length != 0) 
                SearchString = textBox_FindString.Text;
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e) =>
            Close();
        
    }
}
