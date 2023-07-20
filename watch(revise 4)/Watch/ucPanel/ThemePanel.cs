using System.Runtime.InteropServices;

namespace Watch.ucPanel
{
    public partial class ThemePanel : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse);

        //델리게이트
        public delegate void DataPassEventHandler(string data);
        //이벤트 생성
        public event DataPassEventHandler DataPassEvent;
        public Panel Panel1
        {
            get { return panel1; }
            set { panel1 = value; }
        }
        public ThemePanel()
        {
            InitializeComponent();
            theme1Button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, theme1Button.Width, theme1Button.Height, 40, 40));
            theme2Button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, theme2Button.Width, theme2Button.Height, 40, 40));
            theme3Button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, theme3Button.Width, theme3Button.Height, 40, 40));
            theme4Button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, theme4Button.Width, theme4Button.Height, 40, 40));
            theme5Button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, theme5Button.Width, theme5Button.Height, 40, 40));
        }

        private void theme1Button_Click(object sender, EventArgs e)
        {
            string schedule = "gradation1";
            DataPassEvent(schedule);
        }

        private void theme2Button_Click(object sender, EventArgs e)
        {
            string schedule = "gradation2";
            DataPassEvent(schedule);

        }

        private void theme3Button_Click(object sender, EventArgs e)
        {
            string schedule = "gradation3";
            DataPassEvent(schedule);
        }

        private void theme4Button_Click(object sender, EventArgs e)
        {
            string schedule = "gradation4";
            DataPassEvent(schedule);
        }

        private void theme5Button_Click(object sender, EventArgs e)
        {
            string schedule = "gradation5";
            DataPassEvent(schedule);
        }
    }
}

