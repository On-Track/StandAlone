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
            this.metropanel2 = new System.Windows.Forms.Panel();
            this.metropanel3 = new System.Windows.Forms.Panel();
            this.metropanel4 = new System.Windows.Forms.Panel();
            this.bckbutton3 = new System.Windows.Forms.Button();
            this.q4ra1 = new System.Windows.Forms.RadioButton();
            this.q4wa3 = new System.Windows.Forms.RadioButton();
            this.q4wa2 = new System.Windows.Forms.RadioButton();
            this.q4wa1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bckbutton2 = new System.Windows.Forms.Button();
            this.nxtbutton3 = new System.Windows.Forms.Button();
            this.q3wa3 = new System.Windows.Forms.RadioButton();
            this.q3ra1 = new System.Windows.Forms.RadioButton();
            this.q3wa2 = new System.Windows.Forms.RadioButton();
            this.q3wa1 = new System.Windows.Forms.RadioButton();
            this.question3 = new System.Windows.Forms.Label();
            this.bckbutton1 = new System.Windows.Forms.Button();
            this.nxtbutton2 = new System.Windows.Forms.Button();
            this.q2wa3 = new System.Windows.Forms.RadioButton();
            this.q2wa2 = new System.Windows.Forms.RadioButton();
            this.q2ra1 = new System.Windows.Forms.RadioButton();
            this.q2wa1 = new System.Windows.Forms.RadioButton();
            this.question2 = new System.Windows.Forms.Label();
            this.nxtbutton1 = new System.Windows.Forms.Button();
            this.q1wa3 = new System.Windows.Forms.RadioButton();
            this.q1wa2 = new System.Windows.Forms.RadioButton();
            this.q1ra1 = new System.Windows.Forms.RadioButton();
            this.q1wa1 = new System.Windows.Forms.RadioButton();
            this.question1 = new System.Windows.Forms.Label();
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
            this.metroPanel1.SuspendLayout();
            this.metropanel2.SuspendLayout();
            this.metropanel3.SuspendLayout();
            this.metropanel4.SuspendLayout();
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
            this.metroPanel1.Controls.Add(this.metropanel2);
            this.metroPanel1.Controls.Add(this.nxtbutton1);
            this.metroPanel1.Controls.Add(this.q1wa3);
            this.metroPanel1.Controls.Add(this.q1wa2);
            this.metroPanel1.Controls.Add(this.q1ra1);
            this.metroPanel1.Controls.Add(this.q1wa1);
            this.metroPanel1.Controls.Add(this.question1);
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
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metropanel2
            // 
            this.metropanel2.Controls.Add(this.metropanel3);
            this.metropanel2.Controls.Add(this.bckbutton1);
            this.metropanel2.Controls.Add(this.nxtbutton2);
            this.metropanel2.Controls.Add(this.q2wa3);
            this.metropanel2.Controls.Add(this.q2wa2);
            this.metropanel2.Controls.Add(this.q2ra1);
            this.metropanel2.Controls.Add(this.q2wa1);
            this.metropanel2.Controls.Add(this.question2);
            this.metropanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metropanel2.Location = new System.Drawing.Point(0, 0);
            this.metropanel2.Name = "metropanel2";
            this.metropanel2.Size = new System.Drawing.Size(909, 505);
            this.metropanel2.TabIndex = 8;
            this.metropanel2.Visible = false;
            // 
            // metropanel3
            // 
            this.metropanel3.Controls.Add(this.metropanel4);
            this.metropanel3.Controls.Add(this.bckbutton2);
            this.metropanel3.Controls.Add(this.nxtbutton3);
            this.metropanel3.Controls.Add(this.q3wa3);
            this.metropanel3.Controls.Add(this.q3ra1);
            this.metropanel3.Controls.Add(this.q3wa2);
            this.metropanel3.Controls.Add(this.q3wa1);
            this.metropanel3.Controls.Add(this.question3);
            this.metropanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metropanel3.Location = new System.Drawing.Point(0, 0);
            this.metropanel3.Name = "metropanel3";
            this.metropanel3.Size = new System.Drawing.Size(909, 505);
            this.metropanel3.TabIndex = 7;
            this.metropanel3.Visible = false;
            // 
            // metropanel4
            // 
            this.metropanel4.Controls.Add(this.bckbutton3);
            this.metropanel4.Controls.Add(this.q4ra1);
            this.metropanel4.Controls.Add(this.q4wa3);
            this.metropanel4.Controls.Add(this.q4wa2);
            this.metropanel4.Controls.Add(this.q4wa1);
            this.metropanel4.Controls.Add(this.label1);
            this.metropanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metropanel4.Location = new System.Drawing.Point(0, 0);
            this.metropanel4.Name = "metropanel4";
            this.metropanel4.Size = new System.Drawing.Size(909, 505);
            this.metropanel4.TabIndex = 7;
            this.metropanel4.Visible = false;
            this.metropanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.metropanel4_Paint);
            // 
            // bckbutton3
            // 
            this.bckbutton3.Location = new System.Drawing.Point(715, 414);
            this.bckbutton3.Name = "bckbutton3";
            this.bckbutton3.Size = new System.Drawing.Size(129, 42);
            this.bckbutton3.TabIndex = 6;
            this.bckbutton3.Text = "Back";
            this.bckbutton3.UseVisualStyleBackColor = true;
            this.bckbutton3.Click += new System.EventHandler(this.bckbutton3_Click);
            // 
            // q4ra1
            // 
            this.q4ra1.AutoSize = true;
            this.q4ra1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4ra1.Location = new System.Drawing.Point(345, 275);
            this.q4ra1.Name = "q4ra1";
            this.q4ra1.Size = new System.Drawing.Size(97, 22);
            this.q4ra1.TabIndex = 4;
            this.q4ra1.TabStop = true;
            this.q4ra1.Text = "Increases";
            this.q4ra1.UseVisualStyleBackColor = true;
            // 
            // q4wa3
            // 
            this.q4wa3.AutoSize = true;
            this.q4wa3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4wa3.Location = new System.Drawing.Point(345, 228);
            this.q4wa3.Name = "q4wa3";
            this.q4wa3.Size = new System.Drawing.Size(162, 22);
            this.q4wa3.TabIndex = 3;
            this.q4wa3.TabStop = true;
            this.q4wa3.Text = "Remains the same";
            this.q4wa3.UseVisualStyleBackColor = true;
            // 
            // q4wa2
            // 
            this.q4wa2.AutoSize = true;
            this.q4wa2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4wa2.Location = new System.Drawing.Point(345, 180);
            this.q4wa2.Name = "q4wa2";
            this.q4wa2.Size = new System.Drawing.Size(97, 22);
            this.q4wa2.TabIndex = 2;
            this.q4wa2.TabStop = true;
            this.q4wa2.Text = "Unknown";
            this.q4wa2.UseVisualStyleBackColor = true;
            this.q4wa2.CheckedChanged += new System.EventHandler(this.q4wa2_CheckedChanged);
            // 
            // q4wa1
            // 
            this.q4wa1.AutoSize = true;
            this.q4wa1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4wa1.Location = new System.Drawing.Point(345, 133);
            this.q4wa1.Name = "q4wa1";
            this.q4wa1.Size = new System.Drawing.Size(104, 22);
            this.q4wa1.TabIndex = 1;
            this.q4wa1.TabStop = true;
            this.q4wa1.Text = "Decreases";
            this.q4wa1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "As an object falls freely, the kinetic energy of the object";
            // 
            // bckbutton2
            // 
            this.bckbutton2.Location = new System.Drawing.Point(547, 414);
            this.bckbutton2.Name = "bckbutton2";
            this.bckbutton2.Size = new System.Drawing.Size(130, 44);
            this.bckbutton2.TabIndex = 6;
            this.bckbutton2.Text = "Back";
            this.bckbutton2.UseVisualStyleBackColor = true;
            // 
            // nxtbutton3
            // 
            this.nxtbutton3.Location = new System.Drawing.Point(697, 414);
            this.nxtbutton3.Name = "nxtbutton3";
            this.nxtbutton3.Size = new System.Drawing.Size(145, 45);
            this.nxtbutton3.TabIndex = 5;
            this.nxtbutton3.Text = "Next";
            this.nxtbutton3.UseVisualStyleBackColor = true;
            // 
            // q3wa3
            // 
            this.q3wa3.AutoSize = true;
            this.q3wa3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3wa3.Location = new System.Drawing.Point(345, 279);
            this.q3wa3.Name = "q3wa3";
            this.q3wa3.Size = new System.Drawing.Size(70, 22);
            this.q3wa3.TabIndex = 4;
            this.q3wa3.TabStop = true;
            this.q3wa3.Text = "0.34 J";
            this.q3wa3.UseVisualStyleBackColor = true;
            // 
            // q3ra1
            // 
            this.q3ra1.AutoSize = true;
            this.q3ra1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3ra1.Location = new System.Drawing.Point(345, 228);
            this.q3ra1.Name = "q3ra1";
            this.q3ra1.Size = new System.Drawing.Size(60, 22);
            this.q3ra1.TabIndex = 3;
            this.q3ra1.TabStop = true;
            this.q3ra1.Text = "3.3 J";
            this.q3ra1.UseVisualStyleBackColor = true;
            // 
            // q3wa2
            // 
            this.q3wa2.AutoSize = true;
            this.q3wa2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3wa2.Location = new System.Drawing.Point(345, 176);
            this.q3wa2.Name = "q3wa2";
            this.q3wa2.Size = new System.Drawing.Size(56, 22);
            this.q3wa2.TabIndex = 2;
            this.q3wa2.TabStop = true;
            this.q3wa2.Text = "32 J";
            this.q3wa2.UseVisualStyleBackColor = true;
            // 
            // q3wa1
            // 
            this.q3wa1.AutoSize = true;
            this.q3wa1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3wa1.Location = new System.Drawing.Point(345, 129);
            this.q3wa1.Name = "q3wa1";
            this.q3wa1.Size = new System.Drawing.Size(66, 22);
            this.q3wa1.TabIndex = 1;
            this.q3wa1.TabStop = true;
            this.q3wa1.Text = "310 J";
            this.q3wa1.UseVisualStyleBackColor = true;
            // 
            // question3
            // 
            this.question3.AutoSize = true;
            this.question3.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question3.Location = new System.Drawing.Point(41, 28);
            this.question3.Name = "question3";
            this.question3.Size = new System.Drawing.Size(838, 46);
            this.question3.TabIndex = 0;
            this.question3.Text = "An object weighing 15 newtons is lifted from the ground to a height of 0.22 meter" +
    ". \r\nThe increase in the object’s gravitational potential energy is approximately" +
    "";
            // 
            // bckbutton1
            // 
            this.bckbutton1.Location = new System.Drawing.Point(547, 414);
            this.bckbutton1.Name = "bckbutton1";
            this.bckbutton1.Size = new System.Drawing.Size(131, 47);
            this.bckbutton1.TabIndex = 6;
            this.bckbutton1.Text = "Back";
            this.bckbutton1.UseVisualStyleBackColor = true;
            // 
            // nxtbutton2
            // 
            this.nxtbutton2.Location = new System.Drawing.Point(697, 414);
            this.nxtbutton2.Name = "nxtbutton2";
            this.nxtbutton2.Size = new System.Drawing.Size(146, 46);
            this.nxtbutton2.TabIndex = 5;
            this.nxtbutton2.Text = "Next";
            this.nxtbutton2.UseVisualStyleBackColor = true;
            // 
            // q2wa3
            // 
            this.q2wa3.AutoSize = true;
            this.q2wa3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2wa3.Location = new System.Drawing.Point(345, 279);
            this.q2wa3.Name = "q2wa3";
            this.q2wa3.Size = new System.Drawing.Size(246, 22);
            this.q2wa3.TabIndex = 4;
            this.q2wa3.TabStop = true;
            this.q2wa3.Text = "\tdirection of the box’s motion";
            this.q2wa3.UseVisualStyleBackColor = true;
            // 
            // q2wa2
            // 
            this.q2wa2.AutoSize = true;
            this.q2wa2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2wa2.Location = new System.Drawing.Point(345, 228);
            this.q2wa2.Name = "q2wa2";
            this.q2wa2.Size = new System.Drawing.Size(155, 22);
            this.q2wa2.TabIndex = 3;
            this.q2wa2.TabStop = true;
            this.q2wa2.Text = "speed of the box";
            this.q2wa2.UseVisualStyleBackColor = true;
            this.q2wa2.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // q2ra1
            // 
            this.q2ra1.AutoSize = true;
            this.q2ra1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2ra1.Location = new System.Drawing.Point(345, 180);
            this.q2ra1.Name = "q2ra1";
            this.q2ra1.Size = new System.Drawing.Size(228, 22);
            this.q2ra1.TabIndex = 2;
            this.q2ra1.TabStop = true;
            this.q2ra1.Text = "distance the box is moved";
            this.q2ra1.UseVisualStyleBackColor = true;
            // 
            // q2wa1
            // 
            this.q2wa1.AutoSize = true;
            this.q2wa1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2wa1.Location = new System.Drawing.Point(345, 133);
            this.q2wa1.Name = "q2wa1";
            this.q2wa1.Size = new System.Drawing.Size(232, 22);
            this.q2wa1.TabIndex = 1;
            this.q2wa1.TabStop = true;
            this.q2wa1.Text = "\ttime taken to move the box";
            this.q2wa1.UseVisualStyleBackColor = true;
            // 
            // question2
            // 
            this.question2.AutoSize = true;
            this.question2.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2.Location = new System.Drawing.Point(37, 28);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(732, 46);
            this.question2.TabIndex = 0;
            this.question2.Text = "The amount of work done against friction to slide a box in a straight line \r\nacro" +
    "ss a uniform, horizontal floor depends most on the";
            // 
            // nxtbutton1
            // 
            this.nxtbutton1.Location = new System.Drawing.Point(697, 414);
            this.nxtbutton1.Name = "nxtbutton1";
            this.nxtbutton1.Size = new System.Drawing.Size(147, 47);
            this.nxtbutton1.TabIndex = 7;
            this.nxtbutton1.Text = "Next";
            this.nxtbutton1.UseVisualStyleBackColor = true;
            this.nxtbutton1.Click += new System.EventHandler(this.nxtbutton1_Click_1);
            // 
            // q1wa3
            // 
            this.q1wa3.AutoSize = true;
            this.q1wa3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1wa3.Location = new System.Drawing.Point(345, 275);
            this.q1wa3.Name = "q1wa3";
            this.q1wa3.Size = new System.Drawing.Size(64, 22);
            this.q1wa3.TabIndex = 6;
            this.q1wa3.TabStop = true;
            this.q1wa3.Text = "50 N";
            this.q1wa3.UseVisualStyleBackColor = true;
            // 
            // q1wa2
            // 
            this.q1wa2.AutoSize = true;
            this.q1wa2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1wa2.Location = new System.Drawing.Point(345, 228);
            this.q1wa2.Name = "q1wa2";
            this.q1wa2.Size = new System.Drawing.Size(68, 22);
            this.q1wa2.TabIndex = 5;
            this.q1wa2.TabStop = true;
            this.q1wa2.Text = "5.0 N";
            this.q1wa2.UseVisualStyleBackColor = true;
            // 
            // q1ra1
            // 
            this.q1ra1.AutoSize = true;
            this.q1ra1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1ra1.Location = new System.Drawing.Point(345, 176);
            this.q1ra1.Name = "q1ra1";
            this.q1ra1.Size = new System.Drawing.Size(68, 22);
            this.q1ra1.TabIndex = 4;
            this.q1ra1.TabStop = true;
            this.q1ra1.Text = "2.0 N";
            this.q1ra1.UseVisualStyleBackColor = true;
            // 
            // q1wa1
            // 
            this.q1wa1.AutoSize = true;
            this.q1wa1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1wa1.Location = new System.Drawing.Point(345, 129);
            this.q1wa1.Name = "q1wa1";
            this.q1wa1.Size = new System.Drawing.Size(68, 22);
            this.q1wa1.TabIndex = 3;
            this.q1wa1.TabStop = true;
            this.q1wa1.Text = "1.0 N";
            this.q1wa1.UseVisualStyleBackColor = true;
            // 
            // question1
            // 
            this.question1.AutoSize = true;
            this.question1.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1.Location = new System.Drawing.Point(37, 28);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(774, 69);
            this.question1.TabIndex = 2;
            this.question1.Text = "A net force of 10. newtons accelerates an object at 5.0 meters per second^2. \r\nWh" +
    "at net force would be required to accelerate the same object at 1.0 meter \r\nper " +
    "second^2?";
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
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeTabPage);
            this.tabControl1.Controls.Add(this.ReportsTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.lbInfoHeading.Size = new System.Drawing.Size(148, 25);
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
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metropanel2.ResumeLayout(false);
            this.metropanel2.PerformLayout();
            this.metropanel3.ResumeLayout(false);
            this.metropanel3.PerformLayout();
            this.metropanel4.ResumeLayout(false);
            this.metropanel4.PerformLayout();
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
        private System.Windows.Forms.Panel metropanel2;
        private System.Windows.Forms.RadioButton q2wa2;
        private System.Windows.Forms.RadioButton q2ra1;
        private System.Windows.Forms.RadioButton q2wa1;
        private System.Windows.Forms.Label question2;
        private System.Windows.Forms.Button nxtbutton1;
        private System.Windows.Forms.RadioButton q1wa3;
        private System.Windows.Forms.RadioButton q1wa2;
        private System.Windows.Forms.RadioButton q1ra1;
        private System.Windows.Forms.RadioButton q1wa1;
        private System.Windows.Forms.Label question1;
        private System.Windows.Forms.RadioButton q2wa3;
        private System.Windows.Forms.Panel metropanel3;
        private System.Windows.Forms.Panel metropanel4;
        private System.Windows.Forms.RadioButton q4ra1;
        private System.Windows.Forms.RadioButton q4wa3;
        private System.Windows.Forms.RadioButton q4wa2;
        private System.Windows.Forms.RadioButton q4wa1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bckbutton2;
        private System.Windows.Forms.Button nxtbutton3;
        private System.Windows.Forms.RadioButton q3wa3;
        private System.Windows.Forms.RadioButton q3ra1;
        private System.Windows.Forms.RadioButton q3wa2;
        private System.Windows.Forms.RadioButton q3wa1;
        private System.Windows.Forms.Label question3;
        private System.Windows.Forms.Button bckbutton1;
        private System.Windows.Forms.Button nxtbutton2;
        private System.Windows.Forms.Button bckbutton3;
    }
}

