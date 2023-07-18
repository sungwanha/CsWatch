namespace Watch
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            옵션ToolStripMenuItem = new ToolStripMenuItem();
            알람ToolStripMenuItem = new ToolStripMenuItem();
            스탑워치ToolStripMenuItem = new ToolStripMenuItem();
            캘린더ToolStripMenuItem = new ToolStripMenuItem();
            아날로그시계ToolStripMenuItem = new ToolStripMenuItem();
            DigitalClockPanel = new Panel();
            DateLabel = new Label();
            TimeLabel = new Label();
            DownPanel = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            pMain = new Panel();
            BottomLabel = new Label();
            menuStrip1.SuspendLayout();
            DigitalClockPanel.SuspendLayout();
            DownPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 옵션ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(297, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 옵션ToolStripMenuItem
            // 
            옵션ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 알람ToolStripMenuItem, 스탑워치ToolStripMenuItem, 캘린더ToolStripMenuItem, 아날로그시계ToolStripMenuItem });
            옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            옵션ToolStripMenuItem.Size = new Size(43, 20);
            옵션ToolStripMenuItem.Text = "옵션";
            // 
            // 알람ToolStripMenuItem
            // 
            알람ToolStripMenuItem.Name = "알람ToolStripMenuItem";
            알람ToolStripMenuItem.Size = new Size(146, 22);
            알람ToolStripMenuItem.Text = "알람";
            알람ToolStripMenuItem.Click += 알람ToolStripMenuItem_Click;
            // 
            // 스탑워치ToolStripMenuItem
            // 
            스탑워치ToolStripMenuItem.Name = "스탑워치ToolStripMenuItem";
            스탑워치ToolStripMenuItem.Size = new Size(146, 22);
            스탑워치ToolStripMenuItem.Text = "스탑워치";
            스탑워치ToolStripMenuItem.Click += 스탑워치ToolStripMenuItem_Click;
            // 
            // 캘린더ToolStripMenuItem
            // 
            캘린더ToolStripMenuItem.Name = "캘린더ToolStripMenuItem";
            캘린더ToolStripMenuItem.Size = new Size(146, 22);
            캘린더ToolStripMenuItem.Text = "캘린더";
            캘린더ToolStripMenuItem.Click += 캘린더ToolStripMenuItem_Click;
            // 
            // 아날로그시계ToolStripMenuItem
            // 
            아날로그시계ToolStripMenuItem.Name = "아날로그시계ToolStripMenuItem";
            아날로그시계ToolStripMenuItem.Size = new Size(146, 22);
            아날로그시계ToolStripMenuItem.Text = "아날로그시계";
            아날로그시계ToolStripMenuItem.Click += 아날로그시계ToolStripMenuItem_Click;
            // 
            // DigitalClockPanel
            // 
            DigitalClockPanel.BackgroundImage = (Image)resources.GetObject("DigitalClockPanel.BackgroundImage");
            DigitalClockPanel.Controls.Add(DateLabel);
            DigitalClockPanel.Controls.Add(TimeLabel);
            DigitalClockPanel.Dock = DockStyle.Top;
            DigitalClockPanel.Location = new Point(0, 24);
            DigitalClockPanel.Margin = new Padding(2);
            DigitalClockPanel.Name = "DigitalClockPanel";
            DigitalClockPanel.Size = new Size(297, 125);
            DigitalClockPanel.TabIndex = 1;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.BackColor = Color.Transparent;
            DateLabel.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.ForeColor = SystemColors.Window;
            DateLabel.Location = new Point(23, 68);
            DateLabel.Margin = new Padding(2, 0, 2, 0);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(83, 21);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "DateLabel";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.BackColor = Color.Transparent;
            TimeLabel.Font = new Font("맑은 고딕", 30F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = Color.Snow;
            TimeLabel.Location = new Point(16, 20);
            TimeLabel.Margin = new Padding(2, 0, 2, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(205, 54);
            TimeLabel.TabIndex = 0;
            TimeLabel.Text = "TimeLabel";
            // 
            // DownPanel
            // 
            DownPanel.BackgroundImage = (Image)resources.GetObject("DownPanel.BackgroundImage");
            DownPanel.Controls.Add(BottomLabel);
            DownPanel.Dock = DockStyle.Bottom;
            DownPanel.Location = new Point(0, 423);
            DownPanel.Margin = new Padding(2);
            DownPanel.Name = "DownPanel";
            DownPanel.Size = new Size(297, 67);
            DownPanel.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pMain
            // 
            pMain.Dock = DockStyle.Fill;
            pMain.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pMain.Location = new Point(0, 149);
            pMain.Name = "pMain";
            pMain.Size = new Size(297, 274);
            pMain.TabIndex = 4;
            // 
            // BottomLabel
            // 
            BottomLabel.AutoSize = true;
            BottomLabel.BackColor = Color.Transparent;
            BottomLabel.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BottomLabel.ForeColor = SystemColors.Window;
            BottomLabel.Location = new Point(114, 36);
            BottomLabel.Name = "BottomLabel";
            BottomLabel.Size = new Size(171, 17);
            BottomLabel.TabIndex = 0;
            BottomLabel.Text = "협동로봇 SI교육 C# Project";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 490);
            Controls.Add(pMain);
            Controls.Add(DownPanel);
            Controls.Add(DigitalClockPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            DigitalClockPanel.ResumeLayout(false);
            DigitalClockPanel.PerformLayout();
            DownPanel.ResumeLayout(false);
            DownPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel DigitalClockPanel;
        private Label TimeLabel;
        private Label DateLabel;
        private Panel DownPanel;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem 옵션ToolStripMenuItem;
        private ToolStripMenuItem 알람ToolStripMenuItem;
        private ToolStripMenuItem 스탑워치ToolStripMenuItem;
        private ToolStripMenuItem 캘린더ToolStripMenuItem;
        private ToolStripMenuItem 아날로그시계ToolStripMenuItem;
        private Button button1;
        private Label BottomLabel;
        private Panel pMain;
    }
}