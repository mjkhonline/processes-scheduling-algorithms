namespace processes_scheduling_algorithms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_timer_speed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.xToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.general_timer = new System.Windows.Forms.Timer(this.components);
            this.xToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.txt_n_map = new System.Windows.Forms.NumericUpDown();
            this.btn_determine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_fcfs = new System.Windows.Forms.RadioButton();
            this.rb_sjf = new System.Windows.Forms.RadioButton();
            this.rb_priority = new System.Windows.Forms.RadioButton();
            this.rb_rr = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_n_map)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.clearLogToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.runToolStripMenuItem.Text = "&Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.clearLogToolStripMenuItem.Text = "&Clear log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "Abo&ut";
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.developerToolStripMenuItem.Text = "&Developer";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.developerToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_timer_speed,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel2,
            this.progress_bar,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1084, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 21);
            this.toolStripStatusLabel1.Text = "timer interval:";
            // 
            // lbl_timer_speed
            // 
            this.lbl_timer_speed.Name = "lbl_timer_speed";
            this.lbl_timer_speed.Size = new System.Drawing.Size(24, 21);
            this.lbl_timer_speed.Text = "1x";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem6,
            this.xToolStripMenuItem5,
            this.xToolStripMenuItem4,
            this.xToolStripMenuItem3,
            this.xToolStripMenuItem2,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem,
            this.xToolStripMenuItem7});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // xToolStripMenuItem6
            // 
            this.xToolStripMenuItem6.Name = "xToolStripMenuItem6";
            this.xToolStripMenuItem6.Size = new System.Drawing.Size(181, 26);
            this.xToolStripMenuItem6.Text = "1000x";
            this.xToolStripMenuItem6.Click += new System.EventHandler(this.xToolStripMenuItem6_Click);
            // 
            // xToolStripMenuItem5
            // 
            this.xToolStripMenuItem5.Name = "xToolStripMenuItem5";
            this.xToolStripMenuItem5.Size = new System.Drawing.Size(181, 26);
            this.xToolStripMenuItem5.Text = "100x";
            this.xToolStripMenuItem5.Click += new System.EventHandler(this.xToolStripMenuItem5_Click);
            // 
            // xToolStripMenuItem4
            // 
            this.xToolStripMenuItem4.Name = "xToolStripMenuItem4";
            this.xToolStripMenuItem4.Size = new System.Drawing.Size(181, 26);
            this.xToolStripMenuItem4.Text = "10x";
            this.xToolStripMenuItem4.Click += new System.EventHandler(this.xToolStripMenuItem4_Click);
            // 
            // xToolStripMenuItem3
            // 
            this.xToolStripMenuItem3.Name = "xToolStripMenuItem3";
            this.xToolStripMenuItem3.Size = new System.Drawing.Size(181, 26);
            this.xToolStripMenuItem3.Text = "5x";
            this.xToolStripMenuItem3.Click += new System.EventHandler(this.xToolStripMenuItem3_Click);
            // 
            // xToolStripMenuItem2
            // 
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.xToolStripMenuItem2.Text = "2x";
            this.xToolStripMenuItem2.Click += new System.EventHandler(this.xToolStripMenuItem2_Click);
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.xToolStripMenuItem1.Text = "1x";
            this.xToolStripMenuItem1.Click += new System.EventHandler(this.xToolStripMenuItem1_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.xToolStripMenuItem.Text = "1/3x";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 21);
            this.toolStripStatusLabel2.Text = "progress:";
            // 
            // progress_bar
            // 
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(100, 20);
            this.progress_bar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 21);
            // 
            // general_timer
            // 
            this.general_timer.Interval = 1000;
            this.general_timer.Tick += new System.EventHandler(this.general_timer_Tick);
            // 
            // xToolStripMenuItem7
            // 
            this.xToolStripMenuItem7.Name = "xToolStripMenuItem7";
            this.xToolStripMenuItem7.Size = new System.Drawing.Size(181, 26);
            this.xToolStripMenuItem7.Text = "1/5x";
            this.xToolStripMenuItem7.Click += new System.EventHandler(this.xToolStripMenuItem7_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txt_log);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "algorithms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_log
            // 
            this.txt_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_log.Location = new System.Drawing.Point(3, 6);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(848, 482);
            this.txt_log.TabIndex = 8;
            this.txt_log.Text = "[processes scheduling algorithms]";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb_rr);
            this.groupBox1.Controls.Add(this.rb_priority);
            this.groupBox1.Controls.Add(this.rb_sjf);
            this.groupBox1.Controls.Add(this.rb_fcfs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_determine);
            this.groupBox1.Controls.Add(this.txt_n_map);
            this.groupBox1.Controls.Add(this.btn_run);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(857, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 482);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "control panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "maximum number\r\nof process to mapped:";
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.Location = new System.Drawing.Point(6, 429);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(88, 47);
            this.btn_run.TabIndex = 6;
            this.btn_run.Text = "run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // txt_n_map
            // 
            this.txt_n_map.Location = new System.Drawing.Point(10, 81);
            this.txt_n_map.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txt_n_map.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txt_n_map.Name = "txt_n_map";
            this.txt_n_map.Size = new System.Drawing.Size(197, 32);
            this.txt_n_map.TabIndex = 1;
            this.txt_n_map.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_determine
            // 
            this.btn_determine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_determine.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_determine.Enabled = false;
            this.btn_determine.Location = new System.Drawing.Point(100, 429);
            this.btn_determine.Name = "btn_determine";
            this.btn_determine.Size = new System.Drawing.Size(107, 47);
            this.btn_determine.TabIndex = 7;
            this.btn_determine.Text = "determine";
            this.btn_determine.UseVisualStyleBackColor = true;
            this.btn_determine.Click += new System.EventHandler(this.btn_determine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "algorithm:";
            // 
            // rb_fcfs
            // 
            this.rb_fcfs.AutoSize = true;
            this.rb_fcfs.Checked = true;
            this.rb_fcfs.Location = new System.Drawing.Point(7, 161);
            this.rb_fcfs.Name = "rb_fcfs";
            this.rb_fcfs.Size = new System.Drawing.Size(209, 28);
            this.rb_fcfs.TabIndex = 2;
            this.rb_fcfs.TabStop = true;
            this.rb_fcfs.Text = "first come first served";
            this.rb_fcfs.UseVisualStyleBackColor = true;
            // 
            // rb_sjf
            // 
            this.rb_sjf.AutoSize = true;
            this.rb_sjf.Location = new System.Drawing.Point(6, 195);
            this.rb_sjf.Name = "rb_sjf";
            this.rb_sjf.Size = new System.Drawing.Size(140, 28);
            this.rb_sjf.TabIndex = 3;
            this.rb_sjf.Text = "short job first";
            this.rb_sjf.UseVisualStyleBackColor = true;
            // 
            // rb_priority
            // 
            this.rb_priority.AutoSize = true;
            this.rb_priority.Location = new System.Drawing.Point(6, 229);
            this.rb_priority.Name = "rb_priority";
            this.rb_priority.Size = new System.Drawing.Size(99, 28);
            this.rb_priority.TabIndex = 4;
            this.rb_priority.Text = "periority";
            this.rb_priority.UseVisualStyleBackColor = true;
            // 
            // rb_rr
            // 
            this.rb_rr.AutoSize = true;
            this.rb_rr.Location = new System.Drawing.Point(6, 263);
            this.rb_rr.Name = "rb_rr";
            this.rb_rr.Size = new System.Drawing.Size(124, 28);
            this.rb_rr.TabIndex = 5;
            this.rb_rr.Text = "round robin";
            this.rb_rr.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 574);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_run;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_determine;
            this.ClientSize = new System.Drawing.Size(1084, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1096, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "processes scheduling algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_n_map)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar progress_bar;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.Timer general_timer;
        private System.Windows.Forms.ToolStripStatusLabel lbl_timer_speed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_rr;
        private System.Windows.Forms.RadioButton rb_priority;
        private System.Windows.Forms.RadioButton rb_sjf;
        private System.Windows.Forms.RadioButton rb_fcfs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_determine;
        private System.Windows.Forms.NumericUpDown txt_n_map;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

