using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxPractic
{
    enum SaveMode { Continue, Cancel}

    public partial class CatAndCat : Form
    {
        
        private string FileName { get; set; }
        private bool IsChange { get; set; }
        private string find;
        private int pos;


        private IList<string> recentFiles = new List<string> { };


        public CatAndCat()
        {
            InitializeComponent();                      

            ReadRecentFiles();
            DynamicCreation();


            richTextBox_News.SelectionFont = new Font(richTextBox_News.SelectionFont.FontFamily,
                (int)numericUpDown_Font.Value, richTextBox_News.SelectionFont.Style);
            
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

        private void NumericUpDown_Font_ValueChanged(object sender, EventArgs e)
        {
            richTextBox_News.SelectionFont = new Font(richTextBox_News.SelectionFont.FontFamily,
                (int)numericUpDown_Font.Value, richTextBox_News.SelectionFont.Style);
        }

        private void SaveFile_Click(object sender, EventArgs e) => 
            SaveAs();
        
        private void Font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBox_News.SelectionFont = fontDialog.Font;

            IsChange = true;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
                richTextBox_News.SelectionColor = colorDialog.Color;

            IsChange = true;
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            ResultSave();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Загрузка документа";
            openFileDialog.Filter = "Текстовый документ (*.rtf)|*.rtf|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                richTextBox_News.LoadFile(openFileDialog.FileName);

                AddRecentFiles();
            }
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            
            ResultSave();
            richTextBox_News.Clear();
            FileName = null;
            IsChange = false;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Текстовый документ (*.rtf)|*.rtf";

            if (FileName != null)
            {
                richTextBox_News.SaveFile(FileName);
                IsChange = false;
                AddRecentFiles();
            }
            else
            {
                SaveAs();
            }
                
            
        }

        private void RichTextBox_News_TextChanged(object sender, EventArgs e) =>
            IsChange = true;

        private void SaveAs()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Текстовый документ (*.rtf)|*.rtf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFile.FileName;
                richTextBox_News.SaveFile(saveFile.FileName);
                IsChange = false;
                ReadRecentFiles();
            }
        }

        private SaveMode ResultSave()
        {
            if (IsChange)
            {
                SaveWindow saveWindow = new SaveWindow();
                switch (MessageBox.Show("Сохранить изменения?", "Information",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        SaveAs();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return SaveMode.Cancel;
                    default: throw new InvalidOperationException();
                }
            }
            return SaveMode.Continue;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ResultSave() == SaveMode.Continue)
                return;

            e.Cancel = true;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) =>
            Application.Exit();

        
        private void AddRecentFiles()
        {
            recentFiles.Add(Path.GetFileName(FileName));

            if (recentFiles.Count > 10)
                recentFiles.RemoveAt(0);

            WriteRecentFiles();
            ReadRecentFiles();
            DynamicCreation();
        }

        private void DynamicCreation()
        {
            recentFilesToolStripMenuItem.DropDownItems.Clear();

            recentFilesToolStripMenuItem.DropDownItems.AddRange(recentFiles
                .Select(filename => new ToolStripMenuItem { Text = filename, Size = new Size(190, 22) })
                .ToArray());
        }
        
        private void ReadRecentFiles()
        {
            if(File.Exists("Test.txt"))
                recentFiles = File.ReadAllLines("Test.txt").ToList();
        }
        
        private void WriteRecentFiles() =>
            File.WriteAllLines("Test.txt", recentFiles);
        

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_News.Undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_News.Redo();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_News.SelectAll();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_News.Copy();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_News.Cut();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_News.Paste();
        }

        private void FindeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindString findString = new FindString();
            findString.ShowDialog();
            find = findString.SearchString;
            
            if (find != null)
                pos = richTextBox_News.Find(find);
            
        }

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceString replaceString = new ReplaceString();
            replaceString.ShowDialog();

            if (replaceString.ReplacementString == null)
                return;

            if (richTextBox_News.Find(replaceString.ReplacementString) == -1)
            {
                MessageBox.Show("This line does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for(int i = 0; i < richTextBox_News.Lines.Length; i++)
            {
                richTextBox_News.Find(replaceString.ReplacementString);
                if (richTextBox_News.SelectedText.Length > 0)
                    richTextBox_News.SelectedText = replaceString.NewString;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void PrintToolStripButton_Click(object sender, EventArgs e) =>
            MessageBox.Show("This function is temporarily not available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        private void GoToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToWindow goToWindow = new GoToWindow();
            goToWindow.ShowDialog();
            
            int lineNumber = goToWindow.LineNumber;            

            richTextBox_News.SelectionStart = richTextBox_News.GetFirstCharIndexFromLine(lineNumber - 1);

        }

        private void FindeNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos = richTextBox_News.Find(find, pos + find.Length, RichTextBoxFinds.MatchCase);
        }
    }
}
