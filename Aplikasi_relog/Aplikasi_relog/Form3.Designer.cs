﻿namespace Aplikasi_relog
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Coolvetica Rg", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 124);
            label1.Name = "label1";
            label1.Size = new Size(279, 44);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Coolvetica Rg", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 168);
            label2.Name = "label2";
            label2.Size = new Size(439, 44);
            label2.TabIndex = 1;
            label2.Text = "Di Aplikasi Data Mahasiswa!";
            // 
            // button1
            // 
            button1.Location = new Point(314, 251);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 336);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
    }
}