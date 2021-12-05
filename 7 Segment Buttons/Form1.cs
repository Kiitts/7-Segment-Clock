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

        private void label1_Click(object sender, EventArgs e)
        {
            Update_Clock();
            label1.Text = secsd;
        }

        public Form1()
        {
            InitializeComponent();
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
        }

    }
}
