namespace Alarm_Desktop_App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.time_panel = new System.Windows.Forms.Panel();
            this.time_label = new System.Windows.Forms.Label();
            this.clock_picture = new System.Windows.Forms.PictureBox();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.set_alarm_button = new System.Windows.Forms.Button();
            this.alarm_picker = new System.Windows.Forms.DateTimePicker();
            this.time_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clock_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // time_panel
            // 
            this.time_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.time_panel.Controls.Add(this.time_label);
            this.time_panel.Controls.Add(this.clock_picture);
            this.time_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.time_panel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_panel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.time_panel.Location = new System.Drawing.Point(0, 0);
            this.time_panel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.time_panel.Name = "time_panel";
            this.time_panel.Size = new System.Drawing.Size(305, 73);
            this.time_panel.TabIndex = 0;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(78, 9);
            this.time_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(192, 55);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "00:00:00";
            // 
            // clock_picture
            // 
            this.clock_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clock_picture.Image = ((System.Drawing.Image)(resources.GetObject("clock_picture.Image")));
            this.clock_picture.Location = new System.Drawing.Point(20, 13);
            this.clock_picture.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.clock_picture.Name = "clock_picture";
            this.clock_picture.Size = new System.Drawing.Size(48, 48);
            this.clock_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.clock_picture.TabIndex = 0;
            this.clock_picture.TabStop = false;
            // 
            // clock_timer
            // 
            this.clock_timer.Tick += new System.EventHandler(this.clock_timer_Tick);
            // 
            // set_alarm_button
            // 
            this.set_alarm_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("set_alarm_button.BackgroundImage")));
            this.set_alarm_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.set_alarm_button.FlatAppearance.BorderSize = 0;
            this.set_alarm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_alarm_button.Location = new System.Drawing.Point(150, 80);
            this.set_alarm_button.Name = "set_alarm_button";
            this.set_alarm_button.Size = new System.Drawing.Size(29, 29);
            this.set_alarm_button.TabIndex = 1;
            this.set_alarm_button.UseVisualStyleBackColor = true;
            this.set_alarm_button.Click += new System.EventHandler(this.set_alarm_button_Click);
            // 
            // alarm_picker
            // 
            this.alarm_picker.CustomFormat = "HH:mm:ss";
            this.alarm_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.alarm_picker.Location = new System.Drawing.Point(20, 80);
            this.alarm_picker.Name = "alarm_picker";
            this.alarm_picker.Size = new System.Drawing.Size(100, 29);
            this.alarm_picker.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(305, 262);
            this.Controls.Add(this.alarm_picker);
            this.Controls.Add(this.set_alarm_button);
            this.Controls.Add(this.time_panel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "Alarm";
            this.time_panel.ResumeLayout(false);
            this.time_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clock_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel time_panel;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.PictureBox clock_picture;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.Button set_alarm_button;
        private System.Windows.Forms.DateTimePicker alarm_picker;
    }
}

