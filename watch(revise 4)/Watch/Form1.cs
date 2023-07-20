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
        private const string ApiKey = "2f824630adf7b458d556c341f467460b"; // OpenWeatherMap���� �߱޹��� API Ű�� �Է��ϼ���.

        public Form1()
        {
            InitializeComponent();
            //LoadWeatherData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Interval = 100; // 1�ʸ��� ������Ʈ
            timer1.Start();
            //LoadWeatherData();
        }
        private async void LoadWeatherData()
        {
            string city = "Seoul"; // ��ȸ�� ���ø��� �Է��ϼ���.
            string country = "KR"; // ���� �ڵ带 �Է��ϼ��� (��: �ѱ��� "KR", �̱��� "US" ��).

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

                        // ���� ���� ���
                        string weatherdata = $"{weatherData.Weather[0].Description}";
                        string tempdata = $"{weatherData.Main.Temp}��C";
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
                TempLabel.Text = $"���� �߻�: {ex.Message}";
                Weatherlabel.Text = $"���� �߻�: {ex.Message}";
                HumidLabel.Text = $"���� �߻�: {ex.Message}";
                CityLabel.Text = $"���� �߻�: {ex.Message}";
            }
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
            calendarPanel.DataPassEvent += new CalendarPanel.DataPassEventHandler(ScheduleReceiveEvent); // ���ڿ��� �ޱ� ���� �̺�Ʈ �ڵ鷯 ����
            pMain.Controls.Clear();
            pMain.Controls.Add(calendarPanel);
        }
        private void Memo_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            pMain.Controls.Add(textPanel);
        }
        private void �Ƴ��α׽ð�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
        }

        private void �׸�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themePanel.DataPassEvent += new ThemePanel.DataPassEventHandler(DataReceiveEvent); // ���ڿ��� �ޱ� ���� �̺�Ʈ �ڵ鷯 ����
            pMain.Controls.Clear();
            pMain.Controls.Add(themePanel);
        }
        private void DataReceiveEvent(string data)
        {
            // ���⿡ BackGroundImage�ٲٰ� ���� Panel or Button ����
            if (data != "")// ���� �����Ͱ� ������ �״�� ��
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
                // �̹��� ���ҽ����� ��� �̹����� �����ɴϴ�.
                Image backgroundImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

                // �̹��� ���ҽ��� �����ϸ� ��� �̹����� �����մϴ�.
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
                // �̹��� ���ҽ����� ��� �̹����� �����ɴϴ�.
                Image backgroundImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

                // �̹��� ���ҽ��� �����ϸ� ��� �̹����� �����մϴ�.
                if (backgroundImage != null)
                {
                    button.BackgroundImage = backgroundImage;
                }
            }
        }
        private void ScheduleReceiveEvent(string data)
        {
            //ScheduleForm���� ����ڰ� �Է��� ������ �����͸� ������ ����
            if (data != "")// ���� �����Ͱ� ������ �״�� ��
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