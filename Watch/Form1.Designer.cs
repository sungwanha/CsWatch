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
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.알람ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.스탑워치ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.캘린더ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.아날로그시계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DigitalClockPanel = new System.Windows.Forms.Panel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.OptionPanel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.DigitalClockPanel.SuspendLayout();
            this.OptionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.옵션ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 옵션ToolStripMenuItem
            // 
            this.옵션ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.알람ToolStripMenuItem,
            this.스탑워치ToolStripMenuItem,
            this.캘린더ToolStripMenuItem,
            this.아날로그시계ToolStripMenuItem});
            this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.옵션ToolStripMenuItem.Text = "옵션";
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
            // DigitalClockPanel
            // 
            this.DigitalClockPanel.BackgroundImage = global::Watch.Properties.Resources.gradation;
            this.DigitalClockPanel.Controls.Add(this.DateLabel);
            this.DigitalClockPanel.Controls.Add(this.TimeLabel);
            this.DigitalClockPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DigitalClockPanel.Location = new System.Drawing.Point(0, 28);
            this.DigitalClockPanel.Name = "DigitalClockPanel";
            this.DigitalClockPanel.Size = new System.Drawing.Size(382, 167);
            this.DigitalClockPanel.TabIndex = 1;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.DateLabel.Location = new System.Drawing.Point(30, 90);
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
            this.TimeLabel.Location = new System.Drawing.Point(20, 26);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(258, 67);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "TimeLabel";
            // 
            // OptionPanel1
            // 
            this.OptionPanel1.Controls.Add(this.button1);
            this.OptionPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionPanel1.Location = new System.Drawing.Point(0, 195);
            this.OptionPanel1.Name = "OptionPanel1";
            this.OptionPanel1.Size = new System.Drawing.Size(382, 458);
            this.OptionPanel1.TabIndex = 2;
            this.OptionPanel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 117);
            this.panel2.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OptionPanel1);
            this.Controls.Add(this.DigitalClockPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DigitalClockPanel.ResumeLayout(false);
            this.DigitalClockPanel.PerformLayout();
            this.OptionPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel DigitalClockPanel;
        private Label TimeLabel;
        private Panel OptionPanel1;
        private Label DateLabel;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem 옵션ToolStripMenuItem;
        private ToolStripMenuItem 알람ToolStripMenuItem;
        private ToolStripMenuItem 스탑워치ToolStripMenuItem;
        private ToolStripMenuItem 캘린더ToolStripMenuItem;
        private ToolStripMenuItem 아날로그시계ToolStripMenuItem;
        private Button button1;
    }
}