using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch.ucPanel
{
    public partial class ScheduleForm : Form
    {
        private string selectedDate;
        private string select_info;
        //델리게이트
        public delegate void DataPassEventHandler(string data);

        //이벤트 생성
        public event DataPassEventHandler DataPassEvent;

        public ScheduleForm(string date, string info)// 선택한 날짜와 그 날짜에 저장되있었던 이전 스케줄을 인수로 받음
        {
            InitializeComponent();
            selectedDate = date;
            select_info = info;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)//label 블록을 통해 위의 인수들을 화면에 띄움
        {
            lblSelectedDate.Text = $"선택한 날짜: {selectedDate}";
            sche_label2.Text = $"스케줄 : {select_info}";
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)// 저장 버튼을 누를 시에 실행
        {
            // 입력한 스케줄을 저장하는 로직을 여기에 추가
            string schedule = txtSchedule.Text;
            DataPassEvent(schedule);// Form1으로 데이터 전송

            // 스케줄을 저장한 후 폼 닫기
            MessageBox.Show("스케줄이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();//창 닫기
        }


    }
}
