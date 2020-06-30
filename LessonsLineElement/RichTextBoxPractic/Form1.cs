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
    public partial class Form1 : Form
    {
        IList<Color> colors;

        IList<int> fontSize;

        public Form1()
        {
            InitializeComponent();

            colors = new []
            {
                Color.DarkBlue,
                Color.Red,
                Color.Purple,
                Color.Black,
                Color.Yellow
            };

            fontSize = new[]
            {
                8,10,12,14,15,18
            };

            foreach (Color color in colors)
                comboBox_Color.Items.Add(color);

            foreach (int size in fontSize)
                comboBox_fontSize.Items.Add(size);
        }

        private void Button_Italic_Click(object sender, EventArgs e)
        {
            richTextBox_News.SelectionFont = new Font(richTextBox_News.SelectionFont,
                richTextBox_News.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void Button_Underline_Click(object sender, EventArgs e)
        {
            richTextBox_News.SelectionFont = new Font(richTextBox_News.SelectionFont,
                richTextBox_News.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void Button_Strikethrough_Click(object sender, EventArgs e)
        {
            richTextBox_News.SelectionFont = new Font(richTextBox_News.SelectionFont,
                richTextBox_News.SelectionFont.Style ^ FontStyle.Strikeout);
        }

        private void ComboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox_News.SelectionColor = (Color)comboBox_Color.SelectedItem;

        }

        private void ComboBox_fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox_News.SelectionFont = new Font(richTextBox_News.SelectionFont.FontFamily,
                (int)comboBox_fontSize.SelectedItem, richTextBox_News.SelectionFont.Style);
        }
    }
}
