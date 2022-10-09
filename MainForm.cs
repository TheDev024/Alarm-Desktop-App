using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alarm_Desktop_App
{
    public partial class MainForm : Form
    {
        List<Alarm> alarms = new List<Alarm> { };

        public MainForm()
        {
            InitializeComponent();
            clock_timer.Start();
        }

        private void clock_timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            time_label.Text = now.ToString("HH:mm:ss");
        }

        private void set_alarm_button_Click(object sender, EventArgs e)
        {
            DateTime picked_time = alarm_picker.Value;
            new Alarm(this, alarms, picked_time, alarms.Count);
        }
    }
}
