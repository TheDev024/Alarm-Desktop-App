using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Alarm_Desktop_App
{
    public partial class PopupForm : Form
    {
        Alarm alarm;
        List<Alarm> alarms;
        bool snooze = false;

        public PopupForm(Alarm alarm, List<Alarm> alarms)
        {
            InitializeComponent();
            this.alarm = alarm;
            this.alarms = alarms;
            time_label.Text = alarm.time.ToString("HH:mm:ss");
        }

        void StopAlarm()
        {
            if (snooze)
            {
                alarm.time = alarm.time.AddMinutes(2);
                alarm.label.Text = alarm.time.ToString("HH:mm:ss");
                alarm.timer.Start();
                alarms.Add(alarm);
                alarm.UpdateLocations();
                snooze = false;
            }
            alarm.player.Stop();
            Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            StopAlarm();
        }

        private void snooze_button_Click(object sender, EventArgs e)
        {
            snooze = true;
            StopAlarm();
        }
    }
}
