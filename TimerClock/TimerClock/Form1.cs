using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerClock
{
    public partial class Form1 : Form
    {
        private DateTime start;

        bool _running = false;
        private bool running
        {
            get { return _running; }
            set
            {
                if (running)
                {
                    timer1.Stop();
                    button1.Text = "START";
                    _running = false;
                }
                else
                {
                    start = DateTime.Now;
                    timer1.Start();
                    button1.Text = "STOP";
                    _running = true;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            running = !running;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (DateTime.Now - start).ToString(@"hh\:mm\:ss");
        }
    }
}
