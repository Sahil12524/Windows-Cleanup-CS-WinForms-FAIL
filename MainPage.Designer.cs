namespace Windows_Cleanup
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNetTools = new Button();
            btnBasicTools = new Button();
            btnHome = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSettings = new Button();
            panel3 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnNetTools, 0, 2);
            tableLayoutPanel1.Controls.Add(btnBasicTools, 0, 1);
            tableLayoutPanel1.Controls.Add(btnHome, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(284, 126);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNetTools
            // 
            btnNetTools.AutoEllipsis = true;
            btnNetTools.Dock = DockStyle.Fill;
            btnNetTools.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNetTools.Location = new Point(3, 87);
            btnNetTools.Name = "btnNetTools";
            btnNetTools.Size = new Size(278, 36);
            btnNetTools.TabIndex = 2;
            btnNetTools.Text = "Net Tools";
            btnNetTools.TextAlign = ContentAlignment.MiddleLeft;
            btnNetTools.UseVisualStyleBackColor = true;
            btnNetTools.Click += btnNetTools_Click;
            // 
            // btnBasicTools
            // 
            btnBasicTools.AutoEllipsis = true;
            btnBasicTools.Dock = DockStyle.Fill;
            btnBasicTools.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBasicTools.Location = new Point(3, 45);
            btnBasicTools.Name = "btnBasicTools";
            btnBasicTools.Size = new Size(278, 36);
            btnBasicTools.TabIndex = 1;
            btnBasicTools.Text = "Basic Tools";
            btnBasicTools.TextAlign = ContentAlignment.MiddleLeft;
            btnBasicTools.UseVisualStyleBackColor = true;
            btnBasicTools.Click += btnBasicTools_Click;
            // 
            // btnHome
            // 
            btnHome.AutoEllipsis = true;
            btnHome.Dock = DockStyle.Fill;
            btnHome.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(278, 36);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 40);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 761);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnSettings, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 719);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(284, 42);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.AutoEllipsis = true;
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Location = new Point(3, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(278, 36);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(284, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 0, 0, 0);
            panel3.Size = new Size(920, 761);
            panel3.TabIndex = 3;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1204, 761);
            Controls.Add(panel3);
            Controls.Add(panel2);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            Text = "Windows Cleanup";
            Load += MainPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnHome;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnSettings;
        private Button btnBasicTools;
        private Button btnNetTools;
    }
}