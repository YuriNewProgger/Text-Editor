namespace RichTextBoxPractic
{
    partial class GoToWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_LineNumber = new System.Windows.Forms.TextBox();
            this.button_GoTo = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter line number";
            // 
            // textBox_LineNumber
            // 
            this.textBox_LineNumber.Location = new System.Drawing.Point(10, 30);
            this.textBox_LineNumber.Name = "textBox_LineNumber";
            this.textBox_LineNumber.Size = new System.Drawing.Size(145, 20);
            this.textBox_LineNumber.TabIndex = 1;
            // 
            // button_GoTo
            // 
            this.button_GoTo.Location = new System.Drawing.Point(30, 60);
            this.button_GoTo.Name = "button_GoTo";
            this.button_GoTo.Size = new System.Drawing.Size(55, 23);
            this.button_GoTo.TabIndex = 2;
            this.button_GoTo.Text = "GoTo";
            this.button_GoTo.UseVisualStyleBackColor = true;
            this.button_GoTo.Click += new System.EventHandler(this.Button_GoTo_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(100, 60);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(55, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // GoToWindow
            // 
            this.AcceptButton = this.button_GoTo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(170, 95);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_GoTo);
            this.Controls.Add(this.textBox_LineNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GoToWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoToWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LineNumber;
        private System.Windows.Forms.Button button_GoTo;
        private System.Windows.Forms.Button button_Cancel;
    }
}