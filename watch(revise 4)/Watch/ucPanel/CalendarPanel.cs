using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Watch.ucPanel
{
    public partial class CalendarPanel : UserControl
    {
        //델리게이트
        public delegate void DataPassEventHandler(string data);
        //이벤트 생성
        public event DataPassEventHandler DataPassEvent;

        private string selectedDate = string.Empty; // 달력에서 선택한 날짜를 저장하는 변수
        private string searchedData = string.Empty; // 현재 저장된 스케줄에서 날짜에 맞는 스케줄을 찾아 저장할 변수
        private Calander calander;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse);

        public Panel Panel1
        {
            get { return panel1; }
            set { panel1 = value; }
        }
        public Button Button1
        {
            get { return btnAddSchedule; }
            set { btnAddSchedule = value; }
        }
        public CalendarPanel()
        {
            InitializeComponent();
            calander = new Calander();
        }

        private void CalendarPanel_Load(object sender, EventArgs e)
        {
            MonthCalendar1.DateChanged += MonthCalendar1_DateChanged;
            btnAddSchedule.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAddSchedule.Width, btnAddSchedule.Height, 30, 30));
        }
        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // 달력에서 선택한 날짜를 문자열로 저장
            selectedDate = e.Start.ToShortDateString();
            searchedData = calander.Search_info(selectedDate);
            sche_label.Text = $"스케줄 :{searchedData} ";

            // 현재 날짜가 오늘인지 확인하여 오늘 스케줄이 있을 경우 데이터를 전달
            DateTime today = DateTime.Today;
            if (e.Start == today && !string.IsNullOrEmpty(searchedData))
            {
                // 오늘의 스케줄을 이벤트를 통해 전달
                DataPassEvent(searchedData);
            }
        }
        private void DataReceiveEvent(string data)
        {
            //ScheduleForm에서 사용자가 입력한 스케줄 데이터를 받으면 실행
            if (data != "")// 받은 데이터가 없으면 그대로 둠
            {
                calander.Delete(selectedDate);
                calander.Insert(selectedDate, data);
            }
        }
        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            // 선택한 날짜로 스케줄 입력 폼을 띄움
            if (!string.IsNullOrEmpty(selectedDate))
            {
                searchedData = calander.Search_info(selectedDate);// 만일 이전에 저장된 스케줄이 있으면 다음 폼에서 그 스케줄을 띄울수있게 인수로 전송해 줌
                using (var scheduleForm = new ScheduleForm(selectedDate, searchedData))
                {
                    scheduleForm.DataPassEvent += new ScheduleForm.DataPassEventHandler(DataReceiveEvent);//문자열을 받기 위한 이벤트 실행
                    scheduleForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("날짜를 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        class Calander
        {
            string[] schedule_time; // 스케쥴이 담긴 일정을 저장해주는 배열 
            string[] schedule_info;// 일정에 대한 상세 스케쥴 내용을 저장하는 배열
            int last_schedule; // 위 배열의 크기를 저장(insert를 하기 위함)
            public Calander()
            {
                this.schedule_time = new string[100];
                this.schedule_info = new string[100];
                this.last_schedule = 0;
            }
            public void Insert(string select_time, string info)// 스케줄을 저장하는 함수
            {
                this.schedule_time[last_schedule] = select_time;
                this.schedule_info[last_schedule] = info;
                this.last_schedule++;
            }
            public int Search(string select_time)//시간객체 입력을 받으면 저장된 일정에 해당시간이 있는 지 파악하고
            {                                        //일정이 있으면 저장된 배열의 해당 순서 반환, 없으면 -1 반환
                int result = -1;
                for (int i = 0; i < this.last_schedule; i++)
                {
                    if (this.schedule_time[i] == select_time)
                    {
                        result = i;
                        break;
                    }
                }
                return result;
            }
            public string Search_info(string select_time)// 날짜에 맞는 스케줄 일정을 반환하는 함수
            {
                int num = Search(select_time);
                if (num >= 0)
                {
                    return this.schedule_info[num];
                }
                else
                {
                    return "";
                }
            }
            public void Delete(string select_time)// 시간을 넣으면 그 시간에 담긴 일정을 삭제하는 함수
            {
                int num = Search(select_time);
                if (num >= 0)
                {
                    for (int i = num; i < this.last_schedule - 1; i++)
                    {
                        this.schedule_time[i] = this.schedule_time[i + 1];
                        this.schedule_info[i] = this.schedule_info[i + 1];
                    }
                }
            }
        }

    }
}
