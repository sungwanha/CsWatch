using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Watch.ucPanel
{
    public partial class AlarmPanel : UserControl
    {
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
            get { return button1; }
            set { button1 = value; }
        }
        public Button Button2
        {
            get { return button2; }
            set { button2 = value; }
        }
        public AlarmPanel()
        {
            InitializeComponent();
        }

        private void AlarmPanel_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 50, 50));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 50, 50));
        }
    }
}
