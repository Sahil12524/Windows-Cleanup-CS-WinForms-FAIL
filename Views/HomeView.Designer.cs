﻿namespace Windows_Cleanup.Views
{
    partial class HomeView
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
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 130);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Dock = DockStyle.Left;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 130);
            label1.TabIndex = 0;
            label1.Text = "Home";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 766);
            Controls.Add(panel1);
            Name = "HomeView";
            Text = "HomeView";
            Load += HomeView_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
    }
}