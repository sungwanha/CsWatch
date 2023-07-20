namespace Watch.ucPanel
{
    partial class ThemePanel
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
            label1 = new Label();
            panel1 = new Panel();
            theme1Button = new Button();
            theme2Button = new Button();
            theme3Button = new Button();
            theme4Button = new Button();
            theme5Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 7);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Theme";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuText;
            panel1.BackgroundImage = Properties.Resources.gradation2;
            panel1.Location = new Point(17, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 2);
            panel1.TabIndex = 3;
            // 
            // theme1Button
            // 
            theme1Button.BackgroundImage = Properties.Resources.gradation1;
            theme1Button.BackgroundImageLayout = ImageLayout.Stretch;
            theme1Button.FlatAppearance.BorderSize = 0;
            theme1Button.FlatStyle = FlatStyle.Flat;
            theme1Button.Location = new Point(31, 60);
            theme1Button.Name = "theme1Button";
            theme1Button.Size = new Size(97, 35);
            theme1Button.TabIndex = 5;
            theme1Button.UseVisualStyleBackColor = true;
            theme1Button.Click += theme1Button_Click;
            // 
            // theme2Button
            // 
            theme2Button.BackgroundImage = Properties.Resources.gradation2;
            theme2Button.BackgroundImageLayout = ImageLayout.Stretch;
            theme2Button.FlatAppearance.BorderSize = 0;
            theme2Button.FlatStyle = FlatStyle.Flat;
            theme2Button.Location = new Point(159, 60);
            theme2Button.Name = "theme2Button";
            theme2Button.Size = new Size(97, 35);
            theme2Button.TabIndex = 6;
            theme2Button.UseVisualStyleBackColor = true;
            theme2Button.Click += theme2Button_Click;
            // 
            // theme3Button
            // 
            theme3Button.BackgroundImage = Properties.Resources.gradation3;
            theme3Button.BackgroundImageLayout = ImageLayout.Stretch;
            theme3Button.FlatAppearance.BorderSize = 0;
            theme3Button.FlatStyle = FlatStyle.Flat;
            theme3Button.Location = new Point(31, 127);
            theme3Button.Name = "theme3Button";
            theme3Button.Size = new Size(97, 35);
            theme3Button.TabIndex = 7;
            theme3Button.UseVisualStyleBackColor = true;
            theme3Button.Click += theme3Button_Click;
            // 
            // theme4Button
            // 
            theme4Button.BackgroundImage = Properties.Resources.gradation4;
            theme4Button.BackgroundImageLayout = ImageLayout.Stretch;
            theme4Button.FlatAppearance.BorderSize = 0;
            theme4Button.FlatStyle = FlatStyle.Flat;
            theme4Button.Location = new Point(159, 127);
            theme4Button.Name = "theme4Button";
            theme4Button.Size = new Size(97, 35);
            theme4Button.TabIndex = 8;
            theme4Button.UseVisualStyleBackColor = true;
            theme4Button.Click += theme4Button_Click;
            // 
            // theme5Button
            // 
            theme5Button.BackgroundImage = Properties.Resources.gradation5;
            theme5Button.BackgroundImageLayout = ImageLayout.Stretch;
            theme5Button.FlatAppearance.BorderSize = 0;
            theme5Button.FlatStyle = FlatStyle.Flat;
            theme5Button.Location = new Point(31, 198);
            theme5Button.Name = "theme5Button";
            theme5Button.Size = new Size(97, 35);
            theme5Button.TabIndex = 9;
            theme5Button.UseVisualStyleBackColor = true;
            theme5Button.Click += theme5Button_Click;
            // 
            // ThemePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(theme5Button);
            Controls.Add(theme4Button);
            Controls.Add(theme3Button);
            Controls.Add(theme2Button);
            Controls.Add(theme1Button);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ThemePanel";
            Size = new Size(297, 274);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button theme1Button;
        private Button theme2Button;
        private Button theme3Button;
        private Button theme4Button;
        private Button theme5Button;
    }
}
