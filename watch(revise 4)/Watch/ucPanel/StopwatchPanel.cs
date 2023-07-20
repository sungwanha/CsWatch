using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch.ucPanel
{
    public partial class StopwatchPanel : UserControl
    {
        private System.Windows.Forms.Timer timer;
        private TimeSpan elapsedTime;
        private CounterData counter;
        private bool isRunning = false;
        private int lap_count = 0;


        public Panel Panel1
        {
            get { return panel1; }
            set { panel1 = value; }
        }
        public Button Button1
        {
            get { return StartBtn; }
            set { StartBtn = value; }
        }
        public Button Button2
        {
            get { return StopBtn; }
            set { StopBtn = value; }
        }
        public Button Button3
        {
            get { return RecordBtn; }
            set { RecordBtn = value; }
        }
        public Button Button4
        {
            get { return ResetBtn; }
            set { ResetBtn = value; }
        }
        public StopwatchPanel()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10; // 0.1초 간격으로 타이머 실행
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromMilliseconds(timer.Interval));
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            // TimeLabel.Text = $"LAP{this.lap_count}" + elapsedTime.ToString(@"mm\:ss\:ff");
            TimeLabel.Text =  elapsedTime.ToString(@"mm\:ss\:ff");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                timer.Start();
                isRunning = true;
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                isRunning = false;
            }
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                listBox1.Items.Add($"LAP{this.lap_count} {elapsedTime.ToString(@"mm\:ss\:ff")}");
               
            }
            // 버튼이 눌리면 count를 1씩 추가하는 코드 작성
            this.lap_count++;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            isRunning = false;
            elapsedTime = TimeSpan.Zero;
            UpdateTimeLabel();
            listBox1.Items.Clear();
        }
    }
}
