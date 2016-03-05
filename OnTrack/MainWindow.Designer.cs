namespace OnTrack
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Chapter 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Chapter2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Chapter3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Chapter4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Chapter5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Chapter6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Subject", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.HomeTabPage = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.ReportsTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lbInfoHeading = new MetroFramework.Controls.MetroLabel();
            this.lbName = new MetroFramework.Controls.MetroLabel();
            this.txName = new MetroFramework.Controls.MetroTextBox();
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HomeTabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeTabPage
            // 
            this.HomeTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.HomeTabPage.Controls.Add(this.metroPanel1);
            this.HomeTabPage.Controls.Add(this.treeView1);
            this.HomeTabPage.Location = new System.Drawing.Point(4, 38);
            this.HomeTabPage.Name = "HomeTabPage";
            this.HomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTabPage.Size = new System.Drawing.Size(1036, 511);
            this.HomeTabPage.TabIndex = 0;
            this.HomeTabPage.Text = "Home";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 6;
            this.metroPanel1.Location = new System.Drawing.Point(124, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(909, 505);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Chapter 1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Chapter2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Chapter3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Chapter4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Chapter5";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Chapter6";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Subject";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(121, 505);
            this.treeView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeTabPage);
            this.tabControl1.Controls.Add(this.ReportsTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(24, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(1044, 553);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl1.UseSelectable = true;
            // 
            // ReportsTab
            // 
            this.ReportsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.ReportsTab.ForeColor = System.Drawing.Color.White;
            this.ReportsTab.Location = new System.Drawing.Point(4, 38);
            this.ReportsTab.Name = "ReportsTab";
            this.ReportsTab.Size = new System.Drawing.Size(1036, 511);
            this.ReportsTab.TabIndex = 1;
            this.ReportsTab.Text = "Reports";
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.SettingsTab.Controls.Add(this.metroButton1);
            this.SettingsTab.Controls.Add(this.lbInfoHeading);
            this.SettingsTab.Controls.Add(this.lbName);
            this.SettingsTab.Controls.Add(this.txName);
            this.SettingsTab.Location = new System.Drawing.Point(4, 38);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(1036, 511);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Settings";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(252, 120);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(80, 25);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Submit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lbInfoHeading
            // 
            this.lbInfoHeading.AutoSize = true;
            this.lbInfoHeading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbInfoHeading.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbInfoHeading.ForeColor = System.Drawing.Color.Green;
            this.lbInfoHeading.Location = new System.Drawing.Point(30, 30);
            this.lbInfoHeading.Name = "lbInfoHeading";
            this.lbInfoHeading.Size = new System.Drawing.Size(146, 25);
            this.lbInfoHeading.TabIndex = 2;
            this.lbInfoHeading.Text = "Your Information";
            this.lbInfoHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbInfoHeading.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbName.Location = new System.Drawing.Point(51, 80);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 19);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Your Name";
            this.lbName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txName
            // 
            // 
            // 
            // 
            this.txName.CustomButton.Image = null;
            this.txName.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txName.CustomButton.Name = "";
            this.txName.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txName.CustomButton.TabIndex = 1;
            this.txName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txName.CustomButton.UseSelectable = true;
            this.txName.CustomButton.Visible = false;
            this.txName.Lines = new string[] {
        "John O\'Grady"};
            this.txName.Location = new System.Drawing.Point(140, 80);
            this.txName.MaxLength = 32767;
            this.txName.Name = "txName";
            this.txName.PasswordChar = '\0';
            this.txName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txName.SelectedText = "";
            this.txName.SelectionLength = 0;
            this.txName.SelectionStart = 0;
            this.txName.Size = new System.Drawing.Size(190, 20);
            this.txName.TabIndex = 0;
            this.txName.Text = "John O\'Grady";
            this.txName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txName.UseSelectable = true;
            this.txName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbStatus.Location = new System.Drawing.Point(31, 616);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 0);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbStatus.UseCustomForeColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 638);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(24, 64, 24, 21);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "OnTrack";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.HomeTabPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage HomeTabPage;
        private MetroFramework.Controls.MetroTabControl tabControl1;
        private System.Windows.Forms.TabPage ReportsTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TreeView treeView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txName;
        private MetroFramework.Controls.MetroLabel lbName;
        private MetroFramework.Controls.MetroLabel lbInfoHeading;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel lbStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

