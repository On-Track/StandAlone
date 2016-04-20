namespace OnTrack
{
    partial class Quiz
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
            this.quizControlPanel = new MetroFramework.Controls.MetroPanel();
            this.quizFinish = new MetroFramework.Controls.MetroButton();
            this.quizNext = new MetroFramework.Controls.MetroButton();
            this.quizPrev = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.quizControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizControlPanel
            // 
            this.quizControlPanel.Controls.Add(this.quizFinish);
            this.quizControlPanel.Controls.Add(this.quizNext);
            this.quizControlPanel.Controls.Add(this.quizPrev);
            this.quizControlPanel.HorizontalScrollbarBarColor = true;
            this.quizControlPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.quizControlPanel.HorizontalScrollbarSize = 10;
            this.quizControlPanel.Location = new System.Drawing.Point(2, 438);
            this.quizControlPanel.Name = "quizControlPanel";
            this.quizControlPanel.Size = new System.Drawing.Size(897, 49);
            this.quizControlPanel.TabIndex = 0;
            this.quizControlPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.quizControlPanel.VerticalScrollbarBarColor = true;
            this.quizControlPanel.VerticalScrollbarHighlightOnWheel = false;
            this.quizControlPanel.VerticalScrollbarSize = 10;
            // 
            // quizFinish
            // 
            this.quizFinish.Location = new System.Drawing.Point(243, 12);
            this.quizFinish.Name = "quizFinish";
            this.quizFinish.Size = new System.Drawing.Size(75, 23);
            this.quizFinish.TabIndex = 4;
            this.quizFinish.Text = "Finish";
            this.quizFinish.UseSelectable = true;
            this.quizFinish.Click += new System.EventHandler(this.quizFinish_Click);
            // 
            // quizNext
            // 
            this.quizNext.Location = new System.Drawing.Point(132, 12);
            this.quizNext.Name = "quizNext";
            this.quizNext.Size = new System.Drawing.Size(75, 23);
            this.quizNext.TabIndex = 3;
            this.quizNext.Text = "Next";
            this.quizNext.UseSelectable = true;
            this.quizNext.Click += new System.EventHandler(this.quizNext_Click);
            // 
            // quizPrev
            // 
            this.quizPrev.Location = new System.Drawing.Point(21, 13);
            this.quizPrev.Name = "quizPrev";
            this.quizPrev.Size = new System.Drawing.Size(75, 23);
            this.quizPrev.TabIndex = 2;
            this.quizPrev.Text = "Prev";
            this.quizPrev.UseSelectable = true;
            this.quizPrev.Click += new System.EventHandler(this.quizPrev_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(2, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(894, 368);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 488);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.quizControlPanel);
            this.Name = "Quiz";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Quiz";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.quizControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel quizControlPanel;
        private MetroFramework.Controls.MetroButton quizFinish;
        private MetroFramework.Controls.MetroButton quizNext;
        private MetroFramework.Controls.MetroButton quizPrev;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}