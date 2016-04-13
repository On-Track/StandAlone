using System.Windows.Forms;
using MetroFramework.Controls;

namespace OnTrack
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.HomeTabPage = new System.Windows.Forms.TabPage();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.lbSubjectHomeFooter2 = new MetroFramework.Controls.MetroLabel();
            this.btnTakeQuizMath = new MetroFramework.Controls.MetroButton();
            this.lbSubjectHomeFooter = new MetroFramework.Controls.MetroLabel();
            this.lbSubjectHomeBanner = new MetroFramework.Controls.MetroLabel();
            this.controlPanel = new MetroFramework.Controls.MetroPanel();
            this.btnQuizSubmit = new MetroFramework.Controls.MetroButton();
            this.btnQuizNext = new MetroFramework.Controls.MetroButton();
            this.btnQuizPrev = new MetroFramework.Controls.MetroButton();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.ReportsTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.lbInfoHeading = new MetroFramework.Controls.MetroLabel();
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
            this.btnTakeQuizMath2 = new MetroFramework.Controls.MetroButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.btnTakeQuizMath3 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeTabPage.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeTabPage
            // 
            this.HomeTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.HomeTabPage.Controls.Add(this.mainPanel);
            this.HomeTabPage.Controls.Add(this.controlPanel);
            this.HomeTabPage.ForeColor = System.Drawing.Color.White;
            this.HomeTabPage.Location = new System.Drawing.Point(4, 38);
            this.HomeTabPage.Name = "HomeTabPage";
            this.HomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTabPage.Size = new System.Drawing.Size(1036, 511);
            this.HomeTabPage.TabIndex = 0;
            this.HomeTabPage.Text = "Home";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.groupBox3);
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.lbSubjectHomeFooter2);
            this.mainPanel.Controls.Add(this.lbSubjectHomeFooter);
            this.mainPanel.Controls.Add(this.lbSubjectHomeBanner);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ForeColor = System.Drawing.Color.OrangeRed;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 6;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1030, 442);
            this.mainPanel.Style = MetroFramework.MetroColorStyle.Orange;
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // lbSubjectHomeFooter2
            // 
            this.lbSubjectHomeFooter2.AutoSize = true;
            this.lbSubjectHomeFooter2.Location = new System.Drawing.Point(22, 83);
            this.lbSubjectHomeFooter2.Name = "lbSubjectHomeFooter2";
            this.lbSubjectHomeFooter2.Size = new System.Drawing.Size(445, 19);
            this.lbSubjectHomeFooter2.Style = MetroFramework.MetroColorStyle.Orange;
            this.lbSubjectHomeFooter2.TabIndex = 5;
            this.lbSubjectHomeFooter2.Text = "This quiz will introduce you to some of the basic features of this application";
            this.lbSubjectHomeFooter2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnTakeQuizMath
            // 
            this.btnTakeQuizMath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnTakeQuizMath.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTakeQuizMath.Location = new System.Drawing.Point(15, 40);
            this.btnTakeQuizMath.Name = "btnTakeQuizMath";
            this.btnTakeQuizMath.Size = new System.Drawing.Size(140, 45);
            this.btnTakeQuizMath.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnTakeQuizMath.TabIndex = 4;
            this.btnTakeQuizMath.Text = "Quiz 1";
            this.btnTakeQuizMath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTakeQuizMath.UseCustomBackColor = true;
            this.btnTakeQuizMath.UseSelectable = true;
            this.btnTakeQuizMath.Click += new System.EventHandler(this.btnTakeQuiz_Click);
            // 
            // lbSubjectHomeFooter
            // 
            this.lbSubjectHomeFooter.AutoSize = true;
            this.lbSubjectHomeFooter.Location = new System.Drawing.Point(22, 52);
            this.lbSubjectHomeFooter.Name = "lbSubjectHomeFooter";
            this.lbSubjectHomeFooter.Size = new System.Drawing.Size(282, 19);
            this.lbSubjectHomeFooter.Style = MetroFramework.MetroColorStyle.Orange;
            this.lbSubjectHomeFooter.TabIndex = 3;
            this.lbSubjectHomeFooter.Text = "Please click below to take an introductory quiz.";
            this.lbSubjectHomeFooter.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbSubjectHomeBanner
            // 
            this.lbSubjectHomeBanner.AutoSize = true;
            this.lbSubjectHomeBanner.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbSubjectHomeBanner.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbSubjectHomeBanner.Location = new System.Drawing.Point(22, 17);
            this.lbSubjectHomeBanner.Name = "lbSubjectHomeBanner";
            this.lbSubjectHomeBanner.Size = new System.Drawing.Size(91, 25);
            this.lbSubjectHomeBanner.Style = MetroFramework.MetroColorStyle.Orange;
            this.lbSubjectHomeBanner.TabIndex = 2;
            this.lbSubjectHomeBanner.Text = "Welcome";
            this.lbSubjectHomeBanner.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // controlPanel
            // 
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.HorizontalScrollbarBarColor = true;
            this.controlPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.controlPanel.HorizontalScrollbarSize = 6;
            this.controlPanel.Location = new System.Drawing.Point(3, 445);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1030, 63);
            this.controlPanel.Style = MetroFramework.MetroColorStyle.Orange;
            this.controlPanel.TabIndex = 6;
            this.controlPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.controlPanel.VerticalScrollbarBarColor = true;
            this.controlPanel.VerticalScrollbarHighlightOnWheel = false;
            this.controlPanel.VerticalScrollbarSize = 3;
            // 
            // btnQuizSubmit
            // 
            this.btnQuizSubmit.Location = new System.Drawing.Point(233, 10);
            this.btnQuizSubmit.Name = "btnQuizSubmit";
            this.btnQuizSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnQuizSubmit.TabIndex = 4;
            this.btnQuizSubmit.Text = "Finish";
            this.btnQuizSubmit.UseSelectable = true;
            this.btnQuizSubmit.Click += new System.EventHandler(this.btnQuizSubmit_Click);
            // 
            // btnQuizNext
            // 
            this.btnQuizNext.Location = new System.Drawing.Point(119, 10);
            this.btnQuizNext.Name = "btnQuizNext";
            this.btnQuizNext.Size = new System.Drawing.Size(108, 40);
            this.btnQuizNext.TabIndex = 3;
            this.btnQuizNext.Text = "Next";
            this.btnQuizNext.UseSelectable = true;
            this.btnQuizNext.Click += new System.EventHandler(this.btnQuizNext_Click);
            // 
            // btnQuizPrev
            // 
            this.btnQuizPrev.Location = new System.Drawing.Point(16, 10);
            this.btnQuizPrev.Name = "btnQuizPrev";
            this.btnQuizPrev.Size = new System.Drawing.Size(97, 40);
            this.btnQuizPrev.TabIndex = 2;
            this.btnQuizPrev.Text = "Prev";
            this.btnQuizPrev.UseSelectable = true;
            this.btnQuizPrev.Click += new System.EventHandler(this.btnQuizPrev_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeTabPage);
            this.tabControl1.Controls.Add(this.ReportsTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControl1.Location = new System.Drawing.Point(24, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1044, 553);
            this.tabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl1.UseSelectable = true;
            this.tabControl1.UseStyleColors = true;
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
            this.SettingsTab.Controls.Add(this.lbInfoHeading);
            this.SettingsTab.ForeColor = System.Drawing.Color.White;
            this.SettingsTab.Location = new System.Drawing.Point(4, 38);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(1036, 511);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Settings";
            // 
            // lbInfoHeading
            // 
            this.lbInfoHeading.AutoSize = true;
            this.lbInfoHeading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbInfoHeading.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbInfoHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.lbInfoHeading.Location = new System.Drawing.Point(56, 27);
            this.lbInfoHeading.Name = "lbInfoHeading";
            this.lbInfoHeading.Size = new System.Drawing.Size(148, 25);
            this.lbInfoHeading.TabIndex = 2;
            this.lbInfoHeading.Text = "Your Information";
            this.lbInfoHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbInfoHeading.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbInfoHeading.UseCustomForeColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbStatus.Location = new System.Drawing.Point(31, 616);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 0);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbStatus.UseCustomForeColor = true;
            // 
            // btnTakeQuizMath2
            // 
            this.btnTakeQuizMath2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnTakeQuizMath2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTakeQuizMath2.Location = new System.Drawing.Point(15, 101);
            this.btnTakeQuizMath2.Name = "btnTakeQuizMath2";
            this.btnTakeQuizMath2.Size = new System.Drawing.Size(140, 49);
            this.btnTakeQuizMath2.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnTakeQuizMath2.TabIndex = 9;
            this.btnTakeQuizMath2.Text = "Quiz 2";
            this.btnTakeQuizMath2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTakeQuizMath2.UseCustomBackColor = true;
            this.btnTakeQuizMath2.UseSelectable = true;
            this.btnTakeQuizMath2.Click += new System.EventHandler(this.btnTakeQuiz2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.ForeColor = System.Drawing.Color.Coral;
            this.progressBar1.Location = new System.Drawing.Point(27, 239);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(140, 20);
            this.progressBar1.TabIndex = 10;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(26, 243);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(140, 20);
            this.progressBar2.TabIndex = 11;
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.Color.Coral;
            this.progressBar3.Location = new System.Drawing.Point(15, 236);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(140, 20);
            this.progressBar3.TabIndex = 12;
            // 
            // btnTakeQuizMath3
            // 
            this.btnTakeQuizMath3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnTakeQuizMath3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTakeQuizMath3.Location = new System.Drawing.Point(15, 168);
            this.btnTakeQuizMath3.Name = "btnTakeQuizMath3";
            this.btnTakeQuizMath3.Size = new System.Drawing.Size(140, 49);
            this.btnTakeQuizMath3.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnTakeQuizMath3.TabIndex = 13;
            this.btnTakeQuizMath3.Text = "Quiz 3";
            this.btnTakeQuizMath3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTakeQuizMath3.UseCustomBackColor = true;
            this.btnTakeQuizMath3.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTakeQuizMath3);
            this.groupBox1.Controls.Add(this.progressBar3);
            this.groupBox1.Controls.Add(this.btnTakeQuizMath2);
            this.groupBox1.Controls.Add(this.btnTakeQuizMath);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(45, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 274);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mathematics";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(27, 43);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(140, 45);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Quiz 1";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(27, 105);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(140, 45);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "Quiz 1";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.Location = new System.Drawing.Point(27, 172);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(140, 45);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton3.TabIndex = 17;
            this.metroButton3.Text = "Quiz 1";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton3);
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Coral;
            this.groupBox2.Location = new System.Drawing.Point(361, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 273);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Science";
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.Location = new System.Drawing.Point(26, 44);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(140, 45);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton4.TabIndex = 19;
            this.metroButton4.Text = "Quiz 1";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.Location = new System.Drawing.Point(26, 109);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(140, 45);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton5.TabIndex = 20;
            this.metroButton5.Text = "Quiz 1";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseCustomBackColor = true;
            this.metroButton5.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroButton6.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton6.Location = new System.Drawing.Point(26, 176);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(140, 45);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton6.TabIndex = 21;
            this.metroButton6.Text = "Quiz 1";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.UseCustomBackColor = true;
            this.metroButton6.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroButton6);
            this.groupBox3.Controls.Add(this.metroButton5);
            this.groupBox3.Controls.Add(this.metroButton4);
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Coral;
            this.groupBox3.Location = new System.Drawing.Point(681, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 277);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 46);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 638);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(24, 64, 24, 21);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "OnTrack";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.HomeTabPage.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabPage HomeTabPage;
        private MetroTabControl tabControl1;
        private TabPage ReportsTab;
        private TabPage SettingsTab;
        private MetroLabel lbInfoHeading;
        private MetroLabel lbStatus;
        private MetroPanel mainPanel;
        private MetroButton btnTakeQuizMath;
        private MetroLabel lbSubjectHomeFooter;
        private MetroLabel lbSubjectHomeBanner;
        private MetroLabel lbSubjectHomeFooter2;
        private MetroPanel controlPanel;
        private MetroButton btnQuizNext;
        private MetroButton btnQuizPrev;
        private MetroButton btnQuizSubmit;
        private MetroButton btnTakeQuizMath2;
        private GroupBox groupBox3;
        private MetroButton metroButton6;
        private MetroButton metroButton5;
        private MetroButton metroButton4;
        private ProgressBar progressBar2;
        private GroupBox groupBox2;
        private MetroButton metroButton3;
        private MetroButton metroButton2;
        private MetroButton metroButton1;
        private ProgressBar progressBar1;
        private GroupBox groupBox1;
        private MetroButton btnTakeQuizMath3;
        private ProgressBar progressBar3;
        private PictureBox pictureBox1;
    }
}

