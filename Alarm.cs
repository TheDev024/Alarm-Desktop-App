using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Alarm_Desktop_App
{
    public class Alarm
    {
        Form main;
        List<Alarm> alarms;
        public DateTime time;
        public int index;
        public Button cancel;
        public Timer timer;
        public Label label;
        public SoundPlayer player;

        public Alarm(Form main, List<Alarm> alarms, DateTime time, int index)
        {
            this.main = main;
            this.alarms = alarms;
            this.time = time;
            this.index = index;
            SetTimer();
            CreateLabel();
            CreateButton();
            alarms.Add(this);
            UpdateLocations();
        }

        void SetTimer()
        {
            timer = new Timer
            {
                Interval = 1000
            };
            timer.Tick += new EventHandler(CheckTime);
            timer.Start();
        }

        void CheckTime(object source, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (now.ToString("HH:mm:ss") == time.ToString("HH:mm:ss"))
            {
                RemoveAlarm();
                player = new SoundPlayer(@".\sounds\alarm.wav");
                player.Play();
                Form form = new PopupForm(this, alarms);
                form.ShowDialog();
            }
        }

        void RemoveAlarm()
        {
            timer.Stop();
            alarms.Remove(this);
            main.Controls.Remove(label);
            main.Controls.Remove(cancel);
            UpdateLocations();
        }

        private void CreateLabel()
        {
            label = new Label
            {
                Text = time.ToString("HH:mm:ss"),
                Font = new Font("Times New Roman", 24),
                ForeColor = Color.LightGray,
                AutoSize = true
            };
        }

        void CreateButton()
        {
            cancel = new Button
            {
                Text = "",
                BackgroundImage = Image.FromFile(@".\images\close.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(30, 30),
                FlatStyle = FlatStyle.Flat,
            };
            cancel.FlatAppearance.BorderSize = 0;
            cancel.Click += new EventHandler(CnacelAlarm);
        }

        void CnacelAlarm(object source, EventArgs e)
        {
            RemoveAlarm();
        }

        public void UpdateLocations()
        {
            for (int i = 0; i < alarms.Count; i++)
            {
                try
                {
                    main.Controls.Remove(alarms[i].label);
                    main.Controls.Remove(alarms[i].cancel);
                }
                finally
                {
                    int ordinate = 110 + i * 45;
                    alarms[i].label.Location = new Point(12, ordinate);
                    alarms[i].cancel.Location = new Point(150, ordinate);
                    main.Controls.Add(alarms[i].label);
                    main.Controls.Add(alarms[i].cancel);
                }
                
            }
        }
    }
}
