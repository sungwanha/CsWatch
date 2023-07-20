using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch.ucPanel
{
    public partial class TextPanel : UserControl
    {
        // private string path = @"..\..\..\testtext.txt";
        private string path = @"C:\Users\정재현\Desktop\watch(수정4)\Watch\test.txt";
        private string textValue;
        public TextPanel()
        {
            InitializeComponent();
            textValue = System.IO.File.ReadAllText(path);
            richTextBox1.Text = textValue;
        }

        private void TextPanel_Load(object sender, EventArgs e)
        {
            textValue = System.IO.File.ReadAllText(path);
            richTextBox1.Text = textValue;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(path, richTextBox1.Text);
        }
    }
}
