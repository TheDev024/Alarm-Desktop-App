namespace Alarm_Desktop_App
{
    partial class PopupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupForm));
            this.title_panel = new System.Windows.Forms.Panel();
            this.time_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.snooze_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.title_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.title_panel.Controls.Add(this.time_label);
            this.title_panel.Controls.Add(this.title_label);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_panel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(227, 125);
            this.title_panel.TabIndex = 0;
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(12, 45);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(200, 55);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "00:00:00";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(60, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(104, 36);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Alarm";
            // 
            // snooze_button
            // 
            this.snooze_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("snooze_button.BackgroundImage")));
            this.snooze_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snooze_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snooze_button.Location = new System.Drawing.Point(49, 152);
            this.snooze_button.Name = "snooze_button";
            this.snooze_button.Size = new System.Drawing.Size(45, 45);
            this.snooze_button.TabIndex = 1;
            this.snooze_button.UseMnemonic = false;
            this.snooze_button.UseVisualStyleBackColor = true;
            this.snooze_button.Click += new System.EventHandler(this.snooze_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_button.BackgroundImage")));
            this.cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Location = new System.Drawing.Point(133, 152);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(45, 45);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.UseMnemonic = false;
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(227, 226);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.snooze_button);
            this.Controls.Add(this.title_panel);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PopupForm";
            this.Text = "Alarm";
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button snooze_button;
        private System.Windows.Forms.Button cancel_button;
    }
}