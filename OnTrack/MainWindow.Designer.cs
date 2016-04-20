using System.Windows.Forms;
using MetroFramework.Controls;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.HomeTabPage = new System.Windows.Forms.TabPage();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHistoryStudy = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScienceStudy = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMathStudy = new MetroFramework.Controls.MetroButton();
            this.btnTakeQuizMath = new MetroFramework.Controls.MetroButton();
            this.lbSubjectHomeBanner = new MetroFramework.Controls.MetroLabel();
            this.controlPanel = new MetroFramework.Controls.MetroPanel();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbStatus = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.HomeTabPage.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHistoryStudy);
            this.groupBox3.Controls.Add(this.metroButton4);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Coral;
            this.groupBox3.Location = new System.Drawing.Point(681, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 182);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History";
            // 
            // btnHistoryStudy
            // 
            this.btnHistoryStudy.Location = new System.Drawing.Point(22, 45);
            this.btnHistoryStudy.Name = "btnHistoryStudy";
            this.btnHistoryStudy.Size = new System.Drawing.Size(140, 42);
            this.btnHistoryStudy.TabIndex = 22;
            this.btnHistoryStudy.Text = "Study";
            this.btnHistoryStudy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnHistoryStudy.UseSelectable = true;
            this.btnHistoryStudy.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.Location = new System.Drawing.Point(22, 103);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(140, 45);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton4.TabIndex = 19;
            this.metroButton4.Text = "Quiz 1";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnScienceStudy);
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Coral;
            this.groupBox2.Location = new System.Drawing.Point(367, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 182);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Science";
            // 
            // btnScienceStudy
            // 
            this.btnScienceStudy.Location = new System.Drawing.Point(29, 45);
            this.btnScienceStudy.Name = "btnScienceStudy";
            this.btnScienceStudy.Size = new System.Drawing.Size(140, 43);
            this.btnScienceStudy.TabIndex = 18;
            this.btnScienceStudy.Text = "Study";
            this.btnScienceStudy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnScienceStudy.UseSelectable = true;
            this.btnScienceStudy.Click += new System.EventHandler(this.btnScienceStudy_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(29, 106);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(140, 45);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Quiz 1";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMathStudy);
            this.groupBox1.Controls.Add(this.btnTakeQuizMath);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(57, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 182);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mathematics";
            // 
            // btnMathStudy
            // 
            this.btnMathStudy.Location = new System.Drawing.Point(19, 45);
            this.btnMathStudy.Name = "btnMathStudy";
            this.btnMathStudy.Size = new System.Drawing.Size(140, 43);
            this.btnMathStudy.TabIndex = 14;
            this.btnMathStudy.Text = "Study";
            this.btnMathStudy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnMathStudy.UseSelectable = true;
            this.btnMathStudy.Click += new System.EventHandler(this.btnMathStudy_Click);
            // 
            // btnTakeQuizMath
            // 
            this.btnTakeQuizMath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnTakeQuizMath.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTakeQuizMath.Location = new System.Drawing.Point(19, 106);
            this.btnTakeQuizMath.Name = "btnTakeQuizMath";
            this.btnTakeQuizMath.Size = new System.Drawing.Size(140, 45);
            this.btnTakeQuizMath.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnTakeQuizMath.TabIndex = 4;
            this.btnTakeQuizMath.Text = "Quiz 1";
            this.btnTakeQuizMath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTakeQuizMath.UseCustomBackColor = true;
            this.btnTakeQuizMath.UseSelectable = true;
            this.btnTakeQuizMath.Click += new System.EventHandler(this.btnTakeQuizMath_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeTabPage);
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
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.SettingsTab.Controls.Add(this.panel1);
            this.SettingsTab.ForeColor = System.Drawing.Color.Orange;
            this.SettingsTab.Location = new System.Drawing.Point(4, 38);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(1036, 511);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 509);
            this.panel1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Coral;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1039, 509);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Settings";
            this.groupBox5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(330, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Off";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application Restriction";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(329, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Off";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporting";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Coral;
            this.groupBox4.Location = new System.Drawing.Point(108, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 201);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Please enter the administrator password to access settings:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(363, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 0;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "flat,800x800,075,f.jpg");
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
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "OnTrack";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.HomeTabPage.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabPage HomeTabPage;
        private MetroTabControl tabControl1;
        private MetroLabel lbStatus;
        private MetroPanel mainPanel;
        private MetroButton btnTakeQuizMath;
        private MetroLabel lbSubjectHomeBanner;
        private MetroPanel controlPanel;
        private GroupBox groupBox3;
        private MetroButton metroButton4;
        private GroupBox groupBox2;
        private MetroButton metroButton1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private TabPage SettingsTab;
        private Panel panel1;
        private GroupBox groupBox4;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox5;
        private Button button2;
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private ImageList imageList1;
        private MetroButton btnMathStudy;
        private MetroButton btnHistoryStudy;
        private MetroButton btnScienceStudy;
    }
}