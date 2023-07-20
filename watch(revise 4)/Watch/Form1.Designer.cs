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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.알람ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스탑워치ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.캘린더ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아날로그시계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Memo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.테마ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DigitalClockPanel = new System.Windows.Forms.Panel();
            this.ScheduleLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DownPanel = new System.Windows.Forms.Panel();
            this.HumidLabel = new System.Windows.Forms.Label();
            this.Weatherlabel = new System.Windows.Forms.Label();
            this.TempLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pMain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.DigitalClockPanel.SuspendLayout();
            this.DownPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.기능ToolStripMenuItem,
            this.옵션ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(382, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 기능ToolStripMenuItem
            // 
            this.기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.알람ToolStripMenuItem,
            this.스탑워치ToolStripMenuItem,
            this.캘린더ToolStripMenuItem,
            this.아날로그시계ToolStripMenuItem,
            this.Memo,
            this.toolStripSeparator1,
            this.정보ToolStripMenuItem});
            this.기능ToolStripMenuItem.Name = "기능ToolStripMenuItem";
            this.기능ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.기능ToolStripMenuItem.Text = "기능";
            // 
            // 알람ToolStripMenuItem
            // 
            this.알람ToolStripMenuItem.Name = "알람ToolStripMenuItem";
            this.알람ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.알람ToolStripMenuItem.Text = "알람";
            this.알람ToolStripMenuItem.Click += new System.EventHandler(this.알람ToolStripMenuItem_Click);
            // 
            // 스탑워치ToolStripMenuItem
            // 
            this.스탑워치ToolStripMenuItem.Name = "스탑워치ToolStripMenuItem";
            this.스탑워치ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.스탑워치ToolStripMenuItem.Text = "스탑워치";
            this.스탑워치ToolStripMenuItem.Click += new System.EventHandler(this.스탑워치ToolStripMenuItem_Click);
            // 
            // 캘린더ToolStripMenuItem
            // 
            this.캘린더ToolStripMenuItem.Name = "캘린더ToolStripMenuItem";
            this.캘린더ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.캘린더ToolStripMenuItem.Text = "캘린더";
            this.캘린더ToolStripMenuItem.Click += new System.EventHandler(this.캘린더ToolStripMenuItem_Click);
            // 
            // 아날로그시계ToolStripMenuItem
            // 
            this.아날로그시계ToolStripMenuItem.Name = "아날로그시계ToolStripMenuItem";
            this.아날로그시계ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.아날로그시계ToolStripMenuItem.Text = "아날로그시계";
            this.아날로그시계ToolStripMenuItem.Click += new System.EventHandler(this.아날로그시계ToolStripMenuItem_Click);
            // 
            // Memo
            // 
            this.Memo.Name = "Memo";
            this.Memo.Size = new System.Drawing.Size(182, 26);
            this.Memo.Text = "메모";
            this.Memo.Click += new System.EventHandler(this.Memo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 옵션ToolStripMenuItem
            // 
            this.옵션ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.테마ToolStripMenuItem});
            this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.옵션ToolStripMenuItem.Text = "옵션";
            // 
            // 테마ToolStripMenuItem
            // 
            this.테마ToolStripMenuItem.Name = "테마ToolStripMenuItem";
            this.테마ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.테마ToolStripMenuItem.Text = "테마";
            this.테마ToolStripMenuItem.Click += new System.EventHandler(this.테마ToolStripMenuItem_Click);
            // 
            // DigitalClockPanel
            // 
            this.DigitalClockPanel.BackgroundImage = global::Watch.Properties.Resources.gradation5;
            this.DigitalClockPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DigitalClockPanel.Controls.Add(this.ScheduleLabel);
            this.DigitalClockPanel.Controls.Add(this.DateLabel);
            this.DigitalClockPanel.Controls.Add(this.TimeLabel);
            this.DigitalClockPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DigitalClockPanel.Location = new System.Drawing.Point(0, 30);
            this.DigitalClockPanel.Name = "DigitalClockPanel";
            this.DigitalClockPanel.Size = new System.Drawing.Size(382, 167);
            this.DigitalClockPanel.TabIndex = 1;
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.AutoSize = true;
            this.ScheduleLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScheduleLabel.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScheduleLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ScheduleLabel.Location = new System.Drawing.Point(30, 123);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(0, 23);
            this.ScheduleLabel.TabIndex = 2;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.DateLabel.Location = new System.Drawing.Point(30, 91);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(102, 28);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "DateLabel";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.Color.Snow;
            this.TimeLabel.Location = new System.Drawing.Point(21, 27);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(258, 67);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "TimeLabel";
            // 
            // DownPanel
            // 
            this.DownPanel.BackgroundImage = global::Watch.Properties.Resources.gradation5;
            this.DownPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownPanel.Controls.Add(this.HumidLabel);
            this.DownPanel.Controls.Add(this.Weatherlabel);
            this.DownPanel.Controls.Add(this.TempLabel);
            this.DownPanel.Controls.Add(this.CityLabel);
            this.DownPanel.Controls.Add(this.BottomLabel);
            this.DownPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownPanel.Location = new System.Drawing.Point(0, 564);
            this.DownPanel.Name = "DownPanel";
            this.DownPanel.Size = new System.Drawing.Size(382, 89);
            this.DownPanel.TabIndex = 3;
            // 
            // HumidLabel
            // 
            this.HumidLabel.AutoSize = true;
            this.HumidLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumidLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HumidLabel.Location = new System.Drawing.Point(134, 31);
            this.HumidLabel.Name = "HumidLabel";
            this.HumidLabel.Size = new System.Drawing.Size(71, 20);
            this.HumidLabel.TabIndex = 5;
            this.HumidLabel.Text = "Humidity";
            // 
            // Weatherlabel
            // 
            this.Weatherlabel.AutoSize = true;
            this.Weatherlabel.BackColor = System.Drawing.Color.Transparent;
            this.Weatherlabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Weatherlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Weatherlabel.Location = new System.Drawing.Point(18, 60);
            this.Weatherlabel.Name = "Weatherlabel";
            this.Weatherlabel.Size = new System.Drawing.Size(69, 20);
            this.Weatherlabel.TabIndex = 4;
            this.Weatherlabel.Text = "Weather";
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.BackColor = System.Drawing.Color.Transparent;
            this.TempLabel.Font = new System.Drawing.Font("맑은 고딕", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TempLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TempLabel.Location = new System.Drawing.Point(12, 11);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(94, 41);
            this.TempLabel.TabIndex = 3;
            this.TempLabel.Text = "Temp";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.BackColor = System.Drawing.Color.Transparent;
            this.CityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CityLabel.Location = new System.Drawing.Point(312, 19);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 20);
            this.CityLabel.TabIndex = 2;
            this.CityLabel.Text = "City";
            // 
            // BottomLabel
            // 
            this.BottomLabel.AutoSize = true;
            this.BottomLabel.BackColor = System.Drawing.Color.Transparent;
            this.BottomLabel.Font = new System.Drawing.Font("맑은 고딕", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BottomLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.BottomLabel.Location = new System.Drawing.Point(207, 63);
            this.BottomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(171, 17);
            this.BottomLabel.TabIndex = 0;
            this.BottomLabel.Text = "협동로봇 SI교육 C# Project";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pMain.Location = new System.Drawing.Point(0, 197);
            this.pMain.Margin = new System.Windows.Forms.Padding(4);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(382, 367);
            this.pMain.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 653);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.DownPanel);
            this.Controls.Add(this.DigitalClockPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DigitalClockPanel.ResumeLayout(false);
            this.DigitalClockPanel.PerformLayout();
            this.DownPanel.ResumeLayout(false);
            this.DownPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel DigitalClockPanel;
        private Label TimeLabel;
        private Label DateLabel;
        private Panel DownPanel;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem 기능ToolStripMenuItem;
        private ToolStripMenuItem 알람ToolStripMenuItem;
        private ToolStripMenuItem 스탑워치ToolStripMenuItem;
        private ToolStripMenuItem 캘린더ToolStripMenuItem;
        private ToolStripMenuItem 아날로그시계ToolStripMenuItem;
        private Label BottomLabel;
        private Panel pMain;
        private Label TempLabel;
        private Label CityLabel;
        private Label HumidLabel;
        private Label Weatherlabel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 정보ToolStripMenuItem;
        private ToolStripMenuItem 옵션ToolStripMenuItem;
        private ToolStripMenuItem 테마ToolStripMenuItem;
        private ToolStripMenuItem Memo;
        private Label ScheduleLabel;
    }
}