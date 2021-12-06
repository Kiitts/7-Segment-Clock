using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Segment_Buttons
{
    public partial class Form1 : Form
    {
        public DateTime time;
        public string hour, min, sec, hourfd, hoursd, minfd, minsd, secfd, secsd;

        private void themeBtn_Click(object sender, EventArgs e)
        {
            if (themeBox.Visible)
            {
                themeBox.Visible = false;
            }
            else
            {
                themeBox.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Update_Clock();
        }

        public Button[] button1, button2, button3, button4, button5, button6;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1 = new Button[7] { tS1, tRS1, tLS1, mS1, bRS1, bLS1, bS1 };
            button2 = new Button[7] { tS2, tRS2, tLS2, mS2, bRS2, bLS2, bS2 };
            button3 = new Button[7] { tS3, tRS3, tLS3, mS3, bRS3, bLS3, bS3 };
            button4 = new Button[7] { tS4, tRS4, tLS4, mS4, bRS4, bLS4, bS4 };
            button5 = new Button[7] { tS5, tRS5, tLS5, mS5, bRS5, bLS5, bS5 };
            button6 = new Button[7] { tS6, tRS6, tLS6, mS6, bRS6, bLS6, bS6 };
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Update_Segment(Button[] buttons, string number)
        {
            switch(number)
            {
                case "0":
                    buttons[0].BackColor = Color.Red;
                    buttons[1].BackColor = Color.Red;
                    buttons[2].BackColor = Color.Red;
                    buttons[3].BackColor = SystemColors.ActiveCaptionText;
                    buttons[4].BackColor = Color.Red;
                    buttons[5].BackColor = Color.Red;
                    buttons[6].BackColor = Color.Red;
                    break;
                case "1":
                    buttons[0].BackColor = SystemColors.ActiveCaptionText;
                    buttons[1].BackColor = Color.Red;
                    buttons[2].BackColor = SystemColors.ActiveCaptionText;
                    buttons[3].BackColor = SystemColors.ActiveCaptionText;
                    buttons[4].BackColor = Color.Red;
                    buttons[5].BackColor = SystemColors.ActiveCaptionText;
                    buttons[6].BackColor = SystemColors.ActiveCaptionText;
                    break;
                case "2":
                    buttons[0].BackColor = Color.Red;
                    buttons[1].BackColor = Color.Red;
                    buttons[2].BackColor = SystemColors.ActiveCaptionText;
                    buttons[3].BackColor = Color.Red;
                    buttons[4].BackColor = SystemColors.ActiveCaptionText;
                    buttons[5].BackColor = Color.Red;
                    buttons[6].BackColor = Color.Red;
                    break;
                case "3":
                    buttons[0].BackColor = Color.Red;
                    buttons[1].BackColor = Color.Red;
                    buttons[2].BackColor = SystemColors.ActiveCaptionText;
                    buttons[3].BackColor = Color.Red;
                    buttons[4].BackColor = Color.Red;
                    buttons[5].BackColor = SystemColors.ActiveCaptionText;
                    buttons[6].BackColor = Color.Red;
                    break;
                case "4":
                    buttons[0].BackColor = SystemColors.ActiveCaptionText;
                    buttons[1].BackColor = Color.Red;
                    buttons[2].BackColor = Color.Red;
                    buttons[3].BackColor = Color.Red;
                    buttons[4].BackColor = Color.Red;
                    buttons[5].BackColor = SystemColors.ActiveCaptionText;
                    buttons[6].BackColor = SystemColors.ActiveCaptionText;
                    break;
                case "5":
                    buttons[0].BackColor = Color.Red;
                    buttons[1].BackColor = SystemColors.ActiveCaptionText;
                    buttons[2].BackColor = Color.Red;
                    buttons[3].BackColor = Color.Red;
                    buttons[4].BackColor = Color.Red;
                    buttons[5].BackColor = SystemColors.ActiveCaptionText;
                    buttons[6].BackColor = Color.Red;
                    break;
                case "6":
                    buttons[0].BackColor = Color.Red;
                    buttons[1].BackColor = SystemColors.ActiveCaptionText;
                    buttons[2].BackColor = Color.Red;
                    buttons[3].BackColor = Color.Red;
                    buttons[4].BackColor = Color.Red;
                    buttons[5].BackColor = Color.Red;
                    buttons[6].BackColor = Color.Red;
                    break;
                case "7":
                    buttons[0].BackColor = Color.Red;
                    buttons[1].BackColor = Color.Red;
                    buttons[2].BackColor = SystemColors.ActiveCaptionText;
                    buttons[3].BackColor = SystemColors.ActiveCaptionText;
                    buttons[4].BackColor = Color.Red;
                    buttons[5].BackColor = SystemColors.ActiveCaptionText;
                    buttons[6].BackColor = SystemColors.ActiveCaptionText;
                    break;
                case "8":
                    buttons[0].BackColor = Color.Red;
                    buttons[1].BackColor = Color.Red;
                    buttons[2].BackColor = Color.Red;
                    buttons[3].BackColor = Color.Red;
                    buttons[4].BackColor = Color.Red;
                    buttons[5].BackColor = Color.Red;
                    buttons[6].BackColor = Color.Red;
                    break;
                case "9":
                    buttons[0].BackColor = Color.Red;
                    buttons[1].BackColor = Color.Red;
                    buttons[2].BackColor = Color.Red;
                    buttons[3].BackColor = Color.Red;
                    buttons[4].BackColor = Color.Red;
                    buttons[5].BackColor = SystemColors.ActiveCaptionText;
                    buttons[6].BackColor = Color.Red;
                    break;
            }
        }

        public void Update_Clock()
        {
            time = DateTime.Now;
            hour = $"{time:hh}";
            min = $"{time:mm}";
            sec = $"{time:ss}";
            hourfd = hour.Substring(0, 1);
            hoursd = hour.Substring(1, 1);
            minfd = min.Substring(0, 1);
            minsd = min.Substring(1, 1);
            secfd = sec.Substring(0, 1);
            secsd = sec.Substring(1, 1);
            Update_Segment(button1, hourfd);
            Update_Segment(button2, hoursd);
            Update_Segment(button3, minfd);
            Update_Segment(button4, minsd);
            Update_Segment(button5, secfd);
            Update_Segment(button6, secsd);
        }

    }
}
