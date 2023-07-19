namespace Watch.ucPanel
{
    partial class StopwatchPanel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopwatchPanel));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            timer3 = new System.Windows.Forms.Timer(components);
            Stop = new Button();
            Record = new Button();
            Start = new Button();
            Reset = new Button();
            colorDialog1 = new ColorDialog();
            imageList1 = new ImageList(components);
            pictureBox6 = new PictureBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Stopwatch";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuText;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(22, 33);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 3);
            panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 61);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(255, 275);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(336, 316);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 61);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 221);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Stop
            // 
            Stop.BackgroundImage = Properties.Resources.gradation2;
            Stop.Location = new Point(98, 235);
            Stop.Name = "Stop";
            Stop.Size = new Size(86, 29);
            Stop.TabIndex = 4;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            // 
            // Record
            // 
            Record.BackgroundImage = Properties.Resources.gradation2;
            Record.Location = new Point(193, 235);
            Record.Name = "Record";
            Record.Size = new Size(86, 29);
            Record.TabIndex = 5;
            Record.Text = "Record";
            Record.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            Start.BackgroundImage = Properties.Resources.gradation2;
            Start.Location = new Point(6, 235);
            Start.Name = "Start";
            Start.Size = new Size(86, 29);
            Start.TabIndex = 6;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            Reset.BackgroundImage = Properties.Resources.gradation2;
            Reset.Location = new Point(285, 235);
            Reset.Name = "Reset";
            Reset.Size = new Size(86, 29);
            Reset.TabIndex = 8;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(255, 200, 200);
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.Location = new Point(89, 43);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(188, 185);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(22, 265);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(336, 84);
            listBox1.TabIndex = 10;
            // 
            // StopwatchPanel
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImage = Properties.Resources.gradation2;
            Controls.Add(listBox1);
            Controls.Add(pictureBox6);
            Controls.Add(Reset);
            Controls.Add(Start);
            Controls.Add(Record);
            Controls.Add(Stop);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StopwatchPanel";
            Size = new Size(382, 365);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button Stop;
        private Button Record;
        private Button Start;
        private Button Reset;
        private ColorDialog colorDialog1;
        private ImageList imageList1;
        private PictureBox pictureBox6;
        private ListBox listBox1;
    }
}
