namespace RichTextBoxPractic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_News = new System.Windows.Forms.RichTextBox();
            this.button_Italic = new System.Windows.Forms.Button();
            this.button_Underline = new System.Windows.Forms.Button();
            this.button_Strikethrough = new System.Windows.Forms.Button();
            this.comboBox_Color = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_fontSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_SaveFile = new System.Windows.Forms.Button();
            this.button_LoadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_News
            // 
            this.richTextBox_News.Location = new System.Drawing.Point(12, 72);
            this.richTextBox_News.Name = "richTextBox_News";
            this.richTextBox_News.Size = new System.Drawing.Size(708, 216);
            this.richTextBox_News.TabIndex = 0;
            this.richTextBox_News.Text = "Коронавирус уже в России.\n\nНа сегодняшний день всем абзац.\n\nКак учёные работают н" +
    "ад созданием вакцины.\n";
            // 
            // button_Italic
            // 
            this.button_Italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Italic.Location = new System.Drawing.Point(12, 24);
            this.button_Italic.Name = "button_Italic";
            this.button_Italic.Size = new System.Drawing.Size(75, 23);
            this.button_Italic.TabIndex = 1;
            this.button_Italic.Text = "Italic";
            this.button_Italic.UseVisualStyleBackColor = true;
            this.button_Italic.Click += new System.EventHandler(this.Button_Italic_Click);
            // 
            // button_Underline
            // 
            this.button_Underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Underline.Location = new System.Drawing.Point(120, 24);
            this.button_Underline.Name = "button_Underline";
            this.button_Underline.Size = new System.Drawing.Size(75, 23);
            this.button_Underline.TabIndex = 1;
            this.button_Underline.Text = "Underline";
            this.button_Underline.UseVisualStyleBackColor = true;
            this.button_Underline.Click += new System.EventHandler(this.Button_Underline_Click);
            // 
            // button_Strikethrough
            // 
            this.button_Strikethrough.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Strikethrough.Location = new System.Drawing.Point(228, 24);
            this.button_Strikethrough.Name = "button_Strikethrough";
            this.button_Strikethrough.Size = new System.Drawing.Size(84, 23);
            this.button_Strikethrough.TabIndex = 1;
            this.button_Strikethrough.Text = "Strikethrough";
            this.button_Strikethrough.UseVisualStyleBackColor = true;
            this.button_Strikethrough.Click += new System.EventHandler(this.Button_Strikethrough_Click);
            // 
            // comboBox_Color
            // 
            this.comboBox_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Color.FormattingEnabled = true;
            this.comboBox_Color.Location = new System.Drawing.Point(384, 24);
            this.comboBox_Color.Name = "comboBox_Color";
            this.comboBox_Color.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Color.TabIndex = 2;
            this.comboBox_Color.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Color_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(336, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color";
            // 
            // comboBox_fontSize
            // 
            this.comboBox_fontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fontSize.FormattingEnabled = true;
            this.comboBox_fontSize.Location = new System.Drawing.Point(600, 24);
            this.comboBox_fontSize.Name = "comboBox_fontSize";
            this.comboBox_fontSize.Size = new System.Drawing.Size(121, 21);
            this.comboBox_fontSize.TabIndex = 4;
            this.comboBox_fontSize.SelectedIndexChanged += new System.EventHandler(this.ComboBox_fontSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(528, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Font Size";
            // 
            // button_SaveFile
            // 
            this.button_SaveFile.Location = new System.Drawing.Point(732, 72);
            this.button_SaveFile.Name = "button_SaveFile";
            this.button_SaveFile.Size = new System.Drawing.Size(108, 23);
            this.button_SaveFile.TabIndex = 6;
            this.button_SaveFile.Text = "Save File";
            this.button_SaveFile.UseVisualStyleBackColor = true;
            // 
            // button_LoadFile
            // 
            this.button_LoadFile.Location = new System.Drawing.Point(732, 108);
            this.button_LoadFile.Name = "button_LoadFile";
            this.button_LoadFile.Size = new System.Drawing.Size(108, 23);
            this.button_LoadFile.TabIndex = 7;
            this.button_LoadFile.Text = "Load File";
            this.button_LoadFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 303);
            this.Controls.Add(this.button_LoadFile);
            this.Controls.Add(this.button_SaveFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_fontSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Color);
            this.Controls.Add(this.button_Strikethrough);
            this.Controls.Add(this.button_Underline);
            this.Controls.Add(this.button_Italic);
            this.Controls.Add(this.richTextBox_News);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_News;
        private System.Windows.Forms.Button button_Italic;
        private System.Windows.Forms.Button button_Underline;
        private System.Windows.Forms.Button button_Strikethrough;
        private System.Windows.Forms.ComboBox comboBox_Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_fontSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SaveFile;
        private System.Windows.Forms.Button button_LoadFile;
    }
}

