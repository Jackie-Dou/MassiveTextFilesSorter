namespace Lab_1_GUI
{
    partial class MainForm
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
            this.btnGenerateText = new System.Windows.Forms.Button();
            this.btnSortText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerateText
            // 
            this.btnGenerateText.AutoSize = true;
            this.btnGenerateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateText.Location = new System.Drawing.Point(28, 47);
            this.btnGenerateText.Name = "btnGenerateText";
            this.btnGenerateText.Size = new System.Drawing.Size(222, 74);
            this.btnGenerateText.TabIndex = 0;
            this.btnGenerateText.Text = "Сгенерировать текст";
            this.btnGenerateText.UseVisualStyleBackColor = true;
            this.btnGenerateText.Click += new System.EventHandler(this.btnGenerateText_Click);
            // 
            // btnSortText
            // 
            this.btnSortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSortText.Location = new System.Drawing.Point(28, 173);
            this.btnSortText.Name = "btnSortText";
            this.btnSortText.Size = new System.Drawing.Size(222, 69);
            this.btnSortText.TabIndex = 1;
            this.btnSortText.Text = "Отсортировать текст";
            this.btnSortText.UseVisualStyleBackColor = true;
            this.btnSortText.Click += new System.EventHandler(this.btnSortText_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 284);
            this.Controls.Add(this.btnSortText);
            this.Controls.Add(this.btnGenerateText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateText;
        private System.Windows.Forms.Button btnSortText;
    }
}

