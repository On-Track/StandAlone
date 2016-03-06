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
            this.HomeTabPage = new System.Windows.Forms.TabPage();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.lbSubjectHomeFooter2 = new MetroFramework.Controls.MetroLabel();
            this.btnTakeQuiz = new MetroFramework.Controls.MetroButton();
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
            this.HomeTabPage.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SettingsTab.SuspendLayout();
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
            this.mainPanel.Controls.Add(this.lbSubjectHomeFooter2);
            this.mainPanel.Controls.Add(this.btnTakeQuiz);
            this.mainPanel.Controls.Add(this.lbSubjectHomeFooter);
            this.mainPanel.Controls.Add(this.lbSubjectHomeBanner);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 6;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1030, 442);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 3;
            // 
            // lbSubjectHomeFooter2
            // 
            this.lbSubjectHomeFooter2.AutoSize = true;
            this.lbSubjectHomeFooter2.Location = new System.Drawing.Point(22, 83);
            this.lbSubjectHomeFooter2.Name = "lbSubjectHomeFooter2";
            this.lbSubjectHomeFooter2.Size = new System.Drawing.Size(445, 19);
            this.lbSubjectHomeFooter2.TabIndex = 5;
            this.lbSubjectHomeFooter2.Text = "This quiz will introduce you to some of the basic features of this application";
            // 
            // btnTakeQuiz
            // 
            this.btnTakeQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.btnTakeQuiz.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTakeQuiz.Location = new System.Drawing.Point(38, 112);
            this.btnTakeQuiz.Name = "btnTakeQuiz";
            this.btnTakeQuiz.Size = new System.Drawing.Size(114, 41);
            this.btnTakeQuiz.TabIndex = 4;
            this.btnTakeQuiz.Text = "Take the Quiz";
            this.btnTakeQuiz.UseCustomBackColor = true;
            this.btnTakeQuiz.UseSelectable = true;
            this.btnTakeQuiz.Click += new System.EventHandler(this.btnTakeQuiz_Click);
            // 
            // lbSubjectHomeFooter
            // 
            this.lbSubjectHomeFooter.AutoSize = true;
            this.lbSubjectHomeFooter.Location = new System.Drawing.Point(22, 52);
            this.lbSubjectHomeFooter.Name = "lbSubjectHomeFooter";
            this.lbSubjectHomeFooter.Size = new System.Drawing.Size(282, 19);
            this.lbSubjectHomeFooter.TabIndex = 3;
            this.lbSubjectHomeFooter.Text = "Please click below to take an introductory quiz.";
            // 
            // lbSubjectHomeBanner
            // 
            this.lbSubjectHomeBanner.AutoSize = true;
            this.lbSubjectHomeBanner.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbSubjectHomeBanner.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbSubjectHomeBanner.Location = new System.Drawing.Point(22, 17);
            this.lbSubjectHomeBanner.Name = "lbSubjectHomeBanner";
            this.lbSubjectHomeBanner.Size = new System.Drawing.Size(91, 25);
            this.lbSubjectHomeBanner.TabIndex = 2;
            this.lbSubjectHomeBanner.Text = "Welcome";
            // 
            // controlPanel
            // 
            /**
            this.controlPanel.Controls.Add(this.btnQuizSubmit);
            this.controlPanel.Controls.Add(this.btnQuizNext);
            this.controlPanel.Controls.Add(this.btnQuizPrev);
            **/
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.HorizontalScrollbarBarColor = true;
            this.controlPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.controlPanel.HorizontalScrollbarSize = 6;
            this.controlPanel.Location = new System.Drawing.Point(3, 445);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1030, 63);
            this.controlPanel.TabIndex = 6;
            this.controlPanel.VerticalScrollbarBarColor = true;
            this.controlPanel.VerticalScrollbarHighlightOnWheel = false;
            this.controlPanel.VerticalScrollbarSize = 4;
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
            this.lbInfoHeading.Size = new System.Drawing.Size(146, 25);
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
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
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
        private MetroButton btnTakeQuiz;
        private MetroLabel lbSubjectHomeFooter;
        private MetroLabel lbSubjectHomeBanner;
        private MetroLabel lbSubjectHomeFooter2;
        private MetroPanel controlPanel;
        private MetroButton btnQuizNext;
        private MetroButton btnQuizPrev;
        private MetroButton btnQuizSubmit;
    }
}

