namespace Windows_Cleanup.Views
{
    partial class BasicToolsView
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
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            btnTempFilesRemove = new Button();
            btnWindowsUpdateCacheClean = new Button();
            btnCHKDSK = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label8 = new Label();
            label9 = new Label();
            btnSSDTrim = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1314, 130);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Dock = DockStyle.Left;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 130);
            label1.TabIndex = 0;
            label1.Text = "Basic Tools";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(1314, 586);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel4.Controls.Add(btnTempFilesRemove, 1, 0);
            tableLayoutPanel4.Controls.Add(btnWindowsUpdateCacheClean, 1, 1);
            tableLayoutPanel4.Controls.Add(btnCHKDSK, 1, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel4.Controls.Add(btnSSDTrim, 1, 3);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(1314, 552);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(782, 123);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(340, 48);
            label2.TabIndex = 1;
            label2.Text = "Temp files remove";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(776, 75);
            label3.TabIndex = 3;
            label3.Text = "Clean temporary files from Temp, %temp%, Prefetch all at once.\r\nMakes computer feels responisive.\r\nNote: Do not use this Button while any software installer is running!";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 144);
            tableLayoutPanel3.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(782, 123);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(585, 48);
            label5.TabIndex = 1;
            label5.Text = "Windows Update Cache Remove";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 48);
            label4.Name = "label4";
            label4.Size = new Size(776, 75);
            label4.TabIndex = 3;
            label4.Text = "Delete all Downloaded Windows Updates.\r\nHelps save C:\\ Drive Space after a Windows Update.\r\nNote: Do not use this Button while Windows is updating.";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 285);
            tableLayoutPanel1.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(782, 123);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(585, 48);
            label6.TabIndex = 1;
            label6.Text = "Check Disk Errors (C Drive Only)";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoEllipsis = true;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 48);
            label7.Name = "label7";
            label7.Size = new Size(776, 75);
            label7.TabIndex = 3;
            label7.Text = "If your System is having problem, working slow,\r\nthis button will try to detect errors and possibly fix them\r\nNote: Only works after a full computer restart.";
            // 
            // btnTempFilesRemove
            // 
            btnTempFilesRemove.Anchor = AnchorStyles.None;
            btnTempFilesRemove.AutoEllipsis = true;
            btnTempFilesRemove.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnTempFilesRemove.Location = new Point(966, 39);
            btnTempFilesRemove.Name = "btnTempFilesRemove";
            btnTempFilesRemove.Size = new Size(170, 50);
            btnTempFilesRemove.TabIndex = 2;
            btnTempFilesRemove.Text = "Clean";
            btnTempFilesRemove.UseVisualStyleBackColor = true;
            btnTempFilesRemove.Click += btnTempFilesRemove_Click;
            // 
            // btnWindowsUpdateCacheClean
            // 
            btnWindowsUpdateCacheClean.Anchor = AnchorStyles.None;
            btnWindowsUpdateCacheClean.AutoEllipsis = true;
            btnWindowsUpdateCacheClean.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnWindowsUpdateCacheClean.Location = new Point(966, 174);
            btnWindowsUpdateCacheClean.Name = "btnWindowsUpdateCacheClean";
            btnWindowsUpdateCacheClean.Size = new Size(170, 50);
            btnWindowsUpdateCacheClean.TabIndex = 5;
            btnWindowsUpdateCacheClean.Text = "Clean";
            btnWindowsUpdateCacheClean.UseVisualStyleBackColor = true;
            btnWindowsUpdateCacheClean.Click += btnWindowsUpdateCacheClean_Click;
            // 
            // btnCHKDSK
            // 
            btnCHKDSK.Anchor = AnchorStyles.None;
            btnCHKDSK.AutoEllipsis = true;
            btnCHKDSK.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCHKDSK.Location = new Point(966, 315);
            btnCHKDSK.Name = "btnCHKDSK";
            btnCHKDSK.Size = new Size(170, 50);
            btnCHKDSK.TabIndex = 2;
            btnCHKDSK.Text = "Check";
            btnCHKDSK.UseVisualStyleBackColor = true;
            btnCHKDSK.Click += btnCHKDSK_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label8, 0, 0);
            tableLayoutPanel5.Controls.Add(label9, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 426);
            tableLayoutPanel5.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(782, 123);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(443, 48);
            label8.TabIndex = 1;
            label8.Text = "SSD Trim (C Drive Only)";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoEllipsis = true;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(3, 48);
            label9.Name = "label9";
            label9.Size = new Size(776, 75);
            label9.TabIndex = 3;
            label9.Text = "Every SSD requires to trim once every 2 days to maintain\r\nthe health and performance of the SSD.\r\nNote: Only SSD user should use this! Hard Disk Drive (HDD) users will not benefit.";
            // 
            // btnSSDTrim
            // 
            btnSSDTrim.Anchor = AnchorStyles.None;
            btnSSDTrim.AutoEllipsis = true;
            btnSSDTrim.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSSDTrim.Location = new Point(966, 456);
            btnSSDTrim.Name = "btnSSDTrim";
            btnSSDTrim.Size = new Size(170, 50);
            btnSSDTrim.TabIndex = 8;
            btnSSDTrim.Text = "Trim";
            btnSSDTrim.UseVisualStyleBackColor = true;
            btnSSDTrim.Click += btnSSDTrim_Click;
            // 
            // BasicToolsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 716);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BasicToolsView";
            Text = "BasicToolsView";
            Load += BasicToolsView_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label7;
        private Button btnTempFilesRemove;
        private Button btnWindowsUpdateCacheClean;
        private Button btnCHKDSK;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private Label label9;
        private Button btnSSDTrim;
    }
}