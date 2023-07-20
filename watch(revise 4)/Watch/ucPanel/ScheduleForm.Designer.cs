namespace Watch.ucPanel
{
    partial class ScheduleForm
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
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.sche_label2 = new System.Windows.Forms.Label();
            this.txtSchedule = new System.Windows.Forms.TextBox();
            this.btnSaveSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.Location = new System.Drawing.Point(30, 55);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(115, 20);
            this.lblSelectedDate.TabIndex = 1;
            this.lblSelectedDate.Text = "lblSelectedDate";
            // 
            // sche_label2
            // 
            this.sche_label2.AutoSize = true;
            this.sche_label2.Location = new System.Drawing.Point(208, 55);
            this.sche_label2.Name = "sche_label2";
            this.sche_label2.Size = new System.Drawing.Size(50, 20);
            this.sche_label2.TabIndex = 4;
            this.sche_label2.Text = "label1";
            // 
            // txtSchedule
            // 
            this.txtSchedule.Location = new System.Drawing.Point(12, 100);
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.Size = new System.Drawing.Size(307, 27);
            this.txtSchedule.TabIndex = 5;
            // 
            // btnSaveSchedule
            // 
            this.btnSaveSchedule.Location = new System.Drawing.Point(329, 100);
            this.btnSaveSchedule.Name = "btnSaveSchedule";
            this.btnSaveSchedule.Size = new System.Drawing.Size(94, 29);
            this.btnSaveSchedule.TabIndex = 6;
            this.btnSaveSchedule.Text = "저장";
            this.btnSaveSchedule.UseVisualStyleBackColor = true;
            this.btnSaveSchedule.Click += new System.EventHandler(this.btnSaveSchedule_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 142);
            this.Controls.Add(this.btnSaveSchedule);
            this.Controls.Add(this.txtSchedule);
            this.Controls.Add(this.sche_label2);
            this.Controls.Add(this.lblSelectedDate);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSelectedDate;
        private Label sche_label2;
        private TextBox txtSchedule;
        private Button btnSaveSchedule;
    }
}