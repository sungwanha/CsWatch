using System;
using System.Windows.Forms;

namespace Watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1초마다 업데이트
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TimeLabel.Text = currentTime.ToString("hh:mm:ss tt"); // 현재 시간 표시
            DateLabel.Text = currentTime.ToString("yyyy-MM-dd"); // 현재 날짜 표시
        }

        private void 알람ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 스탑워치ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 캘린더ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 아날로그시계ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}