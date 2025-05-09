﻿namespace ML.NET_Image_Practice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            Image = new PictureBox();
            ResultLabel = new Label();
            FileSelectButton = new Button();
            ClassifyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "File Name";
            openFileDialog1.Filter = "이미지 파일 (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
            openFileDialog1.InitialDirectory = "D:";
            // 
            // Image
            // 
            Image.Location = new Point(12, 12);
            Image.Name = "Image";
            Image.Size = new Size(459, 396);
            Image.SizeMode = PictureBoxSizeMode.StretchImage;
            Image.TabIndex = 0;
            Image.TabStop = false;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("맑은 고딕", 12F);
            ResultLabel.Location = new Point(12, 563);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(71, 32);
            ResultLabel.TabIndex = 1;
            ResultLabel.Text = "Label";
            // 
            // FileSelectButton
            // 
            FileSelectButton.Font = new Font("맑은 고딕", 12F);
            FileSelectButton.Location = new Point(12, 414);
            FileSelectButton.Name = "FileSelectButton";
            FileSelectButton.Size = new Size(462, 60);
            FileSelectButton.TabIndex = 2;
            FileSelectButton.Text = "File Select";
            FileSelectButton.UseVisualStyleBackColor = true;
            FileSelectButton.Click += FileSelectButton_Click;
            // 
            // ClassifyButton
            // 
            ClassifyButton.Font = new Font("맑은 고딕", 12F);
            ClassifyButton.Location = new Point(12, 480);
            ClassifyButton.Name = "ClassifyButton";
            ClassifyButton.Size = new Size(462, 69);
            ClassifyButton.TabIndex = 3;
            ClassifyButton.Text = "Classify";
            ClassifyButton.UseVisualStyleBackColor = true;
            ClassifyButton.Click += ClassifyButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 668);
            Controls.Add(ClassifyButton);
            Controls.Add(FileSelectButton);
            Controls.Add(ResultLabel);
            Controls.Add(Image);
            Name = "Form1";
            Text = "Image Classification";
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox Image;
        private Label ResultLabel;
        private Button FileSelectButton;
        private Button ClassifyButton;
    }
}
