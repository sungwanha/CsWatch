using System;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Globalization;
using Watch.ucPanel;
using System.Data;

namespace Watch
{
    public partial class Form1 : Form
    {
        ucPanel.AlarmPanel alarmPanel = new ucPanel.AlarmPanel();
        ucPanel.StopwatchPanel stopwatchPanel = new ucPanel.StopwatchPanel();
        ucPanel.CalendarPanel calendarPanel = new ucPanel.CalendarPanel();
        ucPanel.ThemePanel themePanel = new ucPanel.ThemePanel();
        ucPanel.TextPanel textPanel = new ucPanel.TextPanel();
        private const string ApiKey = "2f824630adf7b458d556c341f467460b"; // OpenWeatherMap에서 발급받은 API 키를 입력하세요.

        public Form1()
        {
            InitializeComponent();
            //LoadWeatherData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Interval = 100; // 1초마다 업데이트
            timer1.Start();
            //LoadWeatherData();
        }
        private async void LoadWeatherData()
        {
            string city = "Seoul"; // 조회할 도시명을 입력하세요.
            string country = "KR"; // 국가 코드를 입력하세요 (예: 한국은 "KR", 미국은 "US" 등).

            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city},{country}&appid={ApiKey}&units=metric";

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                    string responseData = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseData);

                        // 날씨 정보 출력
                        string weatherdata = $"{weatherData.Weather[0].Description}";
                        string tempdata = $"{weatherData.Main.Temp}°C";
                        string humiddata = $"{weatherData.Main.Humidity}%";
                        string citydata = $"{weatherData.Name}";
                        string winddata = $"{weatherData.Wind.Speed} m/s";
                        TempLabel.Text = tempdata;
                        Weatherlabel.Text = weatherdata;
                        HumidLabel.Text = humiddata;
                        CityLabel.Text = citydata;
                    }
                    else
                    {
                        TempLabel.Text = "?";
                        Weatherlabel.Text = "?";
                        HumidLabel.Text = "?";
                        CityLabel.Text = "?";
                    }
                }
            }
            catch (Exception ex)
            {
                TempLabel.Text = $"오류 발생: {ex.Message}";
                Weatherlabel.Text = $"오류 발생: {ex.Message}";
                HumidLabel.Text = $"오류 발생: {ex.Message}";
                CityLabel.Text = $"오류 발생: {ex.Message}";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            TimeLabel.Text = currentTime.ToString("hh:mm:ss tt"); // 현재 시간 표시
            DateLabel.Text = currentTime.ToString("yyyy-MM-dd"); // 현재 날짜 표시
        }

        private void 알람ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(alarmPanel);
        }

        private void 스탑워치ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(stopwatchPanel);
        }

        private void 캘린더ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendarPanel.DataPassEvent += new CalendarPanel.DataPassEventHandler(ScheduleReceiveEvent); // 문자열을 받기 위한 이벤트 핸들러 실행
            pMain.Controls.Clear();
            pMain.Controls.Add(calendarPanel);
        }
        private void Memo_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(textPanel);
        }
        private void 아날로그시계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
        }

        private void 테마ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themePanel.DataPassEvent += new ThemePanel.DataPassEventHandler(DataReceiveEvent); // 문자열을 받기 위한 이벤트 핸들러 실행
            pMain.Controls.Clear();
            pMain.Controls.Add(themePanel);
        }
        private void DataReceiveEvent(string data)
        {
            // 여기에 BackGroundImage바꾸고 싶은 Panel or Button 설정
            if (data != "")// 받은 데이터가 없으면 그대로 둠
            {
                BackgroundImageManager.SetBackgroundImage(DigitalClockPanel, data);
                BackgroundImageManager.SetBackgroundImage(DownPanel, data);
                BackgroundImageManager.SetBackgroundImage(themePanel.Panel1, data);
                BackgroundImageManager.SetBackgroundImage(calendarPanel.Panel1, data);
                BackgroundImageManager.SetBackgroundImage(stopwatchPanel.Panel1, data);
                BackgroundImageManager_button.SetBackgroundImage(alarmPanel.Button1, data);
                BackgroundImageManager_button.SetBackgroundImage(alarmPanel.Button2, data);
                BackgroundImageManager_button.SetBackgroundImage(calendarPanel.Button1, data);
                BackgroundImageManager_button.SetBackgroundImage(stopwatchPanel.Button1, data);
                BackgroundImageManager_button.SetBackgroundImage(stopwatchPanel.Button2, data);
                BackgroundImageManager_button.SetBackgroundImage(stopwatchPanel.Button3, data);
                BackgroundImageManager_button.SetBackgroundImage(stopwatchPanel.Button4, data);

            }
        }
        public static class BackgroundImageManager
        {
            public static void SetBackgroundImage(Panel panel, string imageName)
            {
                // 이미지 리소스에서 배경 이미지를 가져옵니다.
                Image backgroundImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

                // 이미지 리소스가 존재하면 배경 이미지로 설정합니다.
                if (backgroundImage != null)
                {
                    panel.BackgroundImage = backgroundImage;
                }
            }
        }
        public static class BackgroundImageManager_button
        {
            public static void SetBackgroundImage(Button button, string imageName)
            {
                // 이미지 리소스에서 배경 이미지를 가져옵니다.
                Image backgroundImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

                // 이미지 리소스가 존재하면 배경 이미지로 설정합니다.
                if (backgroundImage != null)
                {
                    button.BackgroundImage = backgroundImage;
                }
            }
        }
        private void ScheduleReceiveEvent(string data)
        {
            //ScheduleForm에서 사용자가 입력한 스케줄 데이터를 받으면 실행
            if (data != "")// 받은 데이터가 없으면 그대로 둠
            {
                ScheduleLabel.Text = $"-{data}";
            }
        }

    }
    public class WeatherData
    {
        public string Name { get; set; }
        public Weather[] Weather { get; set; }
        public MainInfo Main { get; set; }
        public Wind Wind { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
    }

    public class MainInfo
    {
        public double Temp { get; set; }
        public int Humidity { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
    }

}