namespace DZ_NA_22._03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxTitle = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonLoadImages = new System.Windows.Forms.Button();
            this.buttonSaveImages = new System.Windows.Forms.Button();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(194, 40);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(125, 22);
            this.textBoxTitle.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(194, 93);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(171, 81);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // buttonLoadImages
            // 
            this.buttonLoadImages.Location = new System.Drawing.Point(377, 40);
            this.buttonLoadImages.Name = "buttonLoadImages";
            this.buttonLoadImages.Size = new System.Drawing.Size(107, 23);
            this.buttonLoadImages.TabIndex = 3;
            this.buttonLoadImages.Text = "Загрузить изображения";
            this.buttonLoadImages.UseVisualStyleBackColor = true;
            this.buttonLoadImages.Click += new System.EventHandler(this.btnLoadImages_Click);
            // 
            // buttonSaveImages
            // 
            this.buttonSaveImages.Location = new System.Drawing.Point(194, 304);
            this.buttonSaveImages.Name = "buttonSaveImages";
            this.buttonSaveImages.Size = new System.Drawing.Size(85, 23);
            this.buttonSaveImages.TabIndex = 4;
            this.buttonSaveImages.Text = "Сохранить";
            this.buttonSaveImages.UseVisualStyleBackColor = true;
            this.buttonSaveImages.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 16;
            this.listBoxImages.Location = new System.Drawing.Point(192, 180);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(173, 100);
            this.listBoxImages.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxImages);
            this.Controls.Add(this.buttonSaveImages);
            this.Controls.Add(this.buttonLoadImages);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textBoxTitle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonLoadImages;
        private System.Windows.Forms.Button buttonSaveImages;
        private System.Windows.Forms.ListBox listBoxImages;
    }
}

