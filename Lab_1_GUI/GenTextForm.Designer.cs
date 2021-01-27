namespace Lab_1_GUI
{
    partial class GenTextForm
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
            this.txtboxSize = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.saveGenFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveGenFile = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxSize
            // 
            this.txtboxSize.Location = new System.Drawing.Point(18, 99);
            this.txtboxSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxSize.Name = "txtboxSize";
            this.txtboxSize.Size = new System.Drawing.Size(220, 30);
            this.txtboxSize.TabIndex = 0;
            this.txtboxSize.TextChanged += new System.EventHandler(this.txtboxSize_TextChanged);
            this.txtboxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxSize_KeyPress);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(13, 33);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(465, 50);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Введите размер файла в байтах или введите 0, \r\nчтобы был сгенерирован файл размер" +
    "ов в 1ГБ:";
            // 
            // SaveGenFile
            // 
            this.SaveGenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveGenFile.Location = new System.Drawing.Point(18, 188);
            this.SaveGenFile.Name = "SaveGenFile";
            this.SaveGenFile.Size = new System.Drawing.Size(179, 36);
            this.SaveGenFile.TabIndex = 2;
            this.SaveGenFile.Text = "Сгенерировать";
            this.SaveGenFile.UseVisualStyleBackColor = true;
            this.SaveGenFile.Click += new System.EventHandler(this.SaveGenFile_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(13, 151);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 25);
            this.lblWarning.TabIndex = 3;
            // 
            // GenTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 236);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.SaveGenFile);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtboxSize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "GenTextForm";
            this.Text = "GenTextForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxSize;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.SaveFileDialog saveGenFileDialog;
        private System.Windows.Forms.Button SaveGenFile;
        private System.Windows.Forms.Label lblWarning;
    }
}