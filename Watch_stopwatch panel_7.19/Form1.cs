using System;
using System.Windows.Forms;

namespace Watch
{
    public partial class Form1 : Form
    {
        ucPanel.AlarmPanel alarmPanel = new ucPanel.AlarmPanel();
        ucPanel.StopwatchPanel stopwatchPanel = new ucPanel.StopwatchPanel();
        ucPanel.CalendarPanel calendarPanel = new ucPanel.CalendarPanel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Interval = 100; // 1�ʸ��� ������Ʈ
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TimeLabel.Text = currentTime.ToString("hh:mm:ss tt"); // ���� �ð� ǥ��
            DateLabel.Text = currentTime.ToString("yyyy-MM-dd"); // ���� ��¥ ǥ��
        }

        private void �˶�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(alarmPanel);
        }

        private void ��ž��ġToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(stopwatchPanel);
        }

        private void Ķ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(calendarPanel);
        }

        private void �Ƴ��α׽ð�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
        }
    }
}