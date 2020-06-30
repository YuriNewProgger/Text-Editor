namespace RichTextBoxPractic
{
    partial class SaveWindow
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
            this.button_Save = new System.Windows.Forms.Button();
            this.buttonDoNotSave = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сохранить изменения?";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(12, 72);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // buttonDoNotSave
            // 
            this.buttonDoNotSave.Location = new System.Drawing.Point(96, 72);
            this.buttonDoNotSave.Name = "buttonDoNotSave";
            this.buttonDoNotSave.Size = new System.Drawing.Size(96, 23);
            this.buttonDoNotSave.TabIndex = 1;
            this.buttonDoNotSave.Text = "Не сохранять";
            this.buttonDoNotSave.UseVisualStyleBackColor = true;
            
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(204, 72);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            
            // 
            // SaveWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 117);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.buttonDoNotSave);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label1);
            this.Name = "SaveWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button buttonDoNotSave;
        private System.Windows.Forms.Button button_Cancel;
    }
}