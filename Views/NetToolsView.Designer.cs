namespace Windows_Cleanup.Views
{
    partial class NetToolsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetToolsView));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            btnDisableNet = new Button();
            btnFlushDNS = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            label12 = new Label();
            label13 = new Label();
            btnResetIP = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            btnEnableNet = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label8 = new Label();
            label9 = new Label();
            btnPacketLossTest = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1056, 130);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Dock = DockStyle.Left;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 130);
            label1.TabIndex = 0;
            label1.Text = "Net Tools";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(1056, 498);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDisableNet, 1, 0);
            tableLayoutPanel1.Controls.Add(btnFlushDNS, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel1.Controls.Add(btnResetIP, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(btnEnableNet, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel1.Controls.Add(btnPacketLossTest, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1039, 743);
            tableLayoutPanel1.TabIndex = 0;
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
            tableLayoutPanel2.Size = new Size(617, 123);
            tableLayoutPanel2.TabIndex = 5;
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
            label2.Text = "Disable Net";
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
            label3.Size = new Size(611, 75);
            label3.TabIndex = 3;
            label3.Text = "Use this button to disable the internet in other words\r\ndisconnect the computer from internet.\r\nNote: Do not use this button if Downloading is running in background";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 144);
            tableLayoutPanel3.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(617, 123);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(340, 48);
            label4.TabIndex = 1;
            label4.Text = "Flush DNS";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoEllipsis = true;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 48);
            label5.Name = "label5";
            label5.Size = new Size(611, 75);
            label5.TabIndex = 3;
            label5.Text = "Use this button to flush the DNS cache, it gives the advantage to\r\nPC gamers having very high PING issue\r\nNote: Just use no side effects :P";
            // 
            // btnDisableNet
            // 
            btnDisableNet.Anchor = AnchorStyles.None;
            btnDisableNet.AutoEllipsis = true;
            btnDisableNet.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisableNet.Location = new Point(746, 39);
            btnDisableNet.Name = "btnDisableNet";
            btnDisableNet.Size = new Size(170, 50);
            btnDisableNet.TabIndex = 9;
            btnDisableNet.Text = "Disable";
            btnDisableNet.UseVisualStyleBackColor = true;
            btnDisableNet.Click += btnDisableNet_Click;
            // 
            // btnFlushDNS
            // 
            btnFlushDNS.Anchor = AnchorStyles.None;
            btnFlushDNS.AutoEllipsis = true;
            btnFlushDNS.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnFlushDNS.Location = new Point(746, 174);
            btnFlushDNS.Name = "btnFlushDNS";
            btnFlushDNS.Size = new Size(170, 50);
            btnFlushDNS.TabIndex = 10;
            btnFlushDNS.Text = "Flush";
            btnFlushDNS.UseVisualStyleBackColor = true;
            btnFlushDNS.Click += btnFlushDNS_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.AutoSize = true;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label12, 0, 0);
            tableLayoutPanel7.Controls.Add(label13, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 285);
            tableLayoutPanel7.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.Size = new Size(617, 123);
            tableLayoutPanel7.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoEllipsis = true;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(340, 48);
            label12.TabIndex = 1;
            label12.Text = "IP Reset";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoEllipsis = true;
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 48);
            label13.Name = "label13";
            label13.Size = new Size(611, 75);
            label13.TabIndex = 3;
            label13.Text = "Use this button to reset IP addresses, it gives the advantage to\r\nPC gamers having very high PING issue, packetlosses etc.\r\nNote: Restart your computer after resetting.";
            // 
            // btnResetIP
            // 
            btnResetIP.Anchor = AnchorStyles.None;
            btnResetIP.AutoEllipsis = true;
            btnResetIP.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetIP.Location = new Point(746, 315);
            btnResetIP.Name = "btnResetIP";
            btnResetIP.Size = new Size(170, 50);
            btnResetIP.TabIndex = 14;
            btnResetIP.Text = "Reset IP";
            btnResetIP.UseVisualStyleBackColor = true;
            btnResetIP.Click += btnResetIP_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(label7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 426);
            tableLayoutPanel4.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(617, 123);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoEllipsis = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(340, 48);
            label6.TabIndex = 1;
            label6.Text = "Enable Net";
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
            label7.Size = new Size(611, 75);
            label7.TabIndex = 3;
            label7.Text = "If you disabled the Net and want to Re enable the internet,\r\nuse this button to Enable the Net again\r\nNote: -";
            // 
            // btnEnableNet
            // 
            btnEnableNet.Anchor = AnchorStyles.None;
            btnEnableNet.AutoEllipsis = true;
            btnEnableNet.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnableNet.Location = new Point(746, 456);
            btnEnableNet.Name = "btnEnableNet";
            btnEnableNet.Size = new Size(170, 50);
            btnEnableNet.TabIndex = 11;
            btnEnableNet.Text = "Enable";
            btnEnableNet.UseVisualStyleBackColor = true;
            btnEnableNet.Click += btnEnableNet_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label8, 0, 0);
            tableLayoutPanel5.Controls.Add(label9, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 567);
            tableLayoutPanel5.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(617, 173);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(340, 48);
            label8.TabIndex = 1;
            label8.Text = "Packet Loss Tester";
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
            label9.Size = new Size(611, 125);
            label9.TabIndex = 3;
            label9.Text = resources.GetString("label9.Text");
            // 
            // btnPacketLossTest
            // 
            btnPacketLossTest.Anchor = AnchorStyles.None;
            btnPacketLossTest.AutoEllipsis = true;
            btnPacketLossTest.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPacketLossTest.Location = new Point(746, 622);
            btnPacketLossTest.Name = "btnPacketLossTest";
            btnPacketLossTest.Size = new Size(170, 50);
            btnPacketLossTest.TabIndex = 12;
            btnPacketLossTest.Text = "Test Now";
            btnPacketLossTest.UseVisualStyleBackColor = true;
            btnPacketLossTest.Click += btnPacketLossTest_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label10, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(194, 20);
            label10.TabIndex = 1;
            label10.Text = "Flush DNS";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoEllipsis = true;
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(3, 48);
            label11.Name = "label11";
            label11.Size = new Size(194, 200);
            label11.TabIndex = 3;
            label11.Text = "Use this button to flush the DNS cache, it gives the advantage to\r\nPC gamers having very high PING issue\r\nNote: Just use no side effects :P";
            // 
            // NetToolsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 628);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NetToolsView";
            Text = "NetToolsView";
            Load += NetToolsView_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label8;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private Label label7;
        private Button btnDisableNet;
        private Button btnFlushDNS;
        private Button btnEnableNet;
        private Button btnPacketLossTest;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label12;
        private Label label13;
        private Button btnResetIP;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label10;
        private Label label11;
    }
}