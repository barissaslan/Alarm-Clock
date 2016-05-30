namespace Alarm_Clock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbMin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbSounds = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timerRemaining = new System.Windows.Forms.Timer(this.components);
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.lblNow = new System.Windows.Forms.Label();
            this.timerPlaying = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddSound = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteSound = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAddSound = new System.Windows.Forms.ToolStripButton();
            this.toolCounter = new System.Windows.Forms.ToolStripButton();
            this.toolAlarm = new System.Windows.Forms.ToolStripButton();
            this.toolDeleteSound = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSettings = new System.Windows.Forms.ToolStripButton();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.panelCounter = new System.Windows.Forms.Panel();
            this.nmrCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelAlarm.SuspendLayout();
            this.panelCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMin
            // 
            this.cmbMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMin.FormattingEnabled = true;
            this.cmbMin.Location = new System.Drawing.Point(92, 27);
            this.cmbMin.Name = "cmbMin";
            this.cmbMin.Size = new System.Drawing.Size(67, 23);
            this.cmbMin.TabIndex = 4;
            this.cmbMin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // cmbHour
            // 
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(5, 27);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbHour.Size = new System.Drawing.Size(67, 23);
            this.cmbHour.TabIndex = 3;
            this.cmbHour.TabStop = false;
            // 
            // cmbSounds
            // 
            this.cmbSounds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSounds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSounds.FormattingEnabled = true;
            this.cmbSounds.Location = new System.Drawing.Point(25, 173);
            this.cmbSounds.Name = "cmbSounds";
            this.cmbSounds.Size = new System.Drawing.Size(154, 23);
            this.cmbSounds.TabIndex = 2;
            this.cmbSounds.TabStop = false;
            this.cmbSounds.SelectedIndexChanged += new System.EventHandler(this.cmbSounds_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alarm Time";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(24, 202);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(103, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timerRemaining
            // 
            this.timerRemaining.Interval = 250;
            this.timerRemaining.Tick += new System.EventHandler(this.timerRemaining_Tick);
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemainingTime.Location = new System.Drawing.Point(22, 229);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(0, 13);
            this.lblRemainingTime.TabIndex = 1;
            // 
            // timerNow
            // 
            this.timerNow.Interval = 250;
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNow.Location = new System.Drawing.Point(31, 52);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(94, 28);
            this.lblNow.TabIndex = 1;
            this.lblNow.Text = "00:00:00";
            // 
            // timerPlaying
            // 
            this.timerPlaying.Tick += new System.EventHandler(this.timerPlaying_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(211, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddSound,
            this.menuDeleteSound,
            this.toolStripSeparator1,
            this.menuSettings});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuAddSound
            // 
            this.menuAddSound.Image = global::Alarm_Clock.Properties.Resources.plus;
            this.menuAddSound.Name = "menuAddSound";
            this.menuAddSound.Size = new System.Drawing.Size(144, 22);
            this.menuAddSound.Text = "Add Sound";
            this.menuAddSound.Click += new System.EventHandler(this.addSound_Click);
            // 
            // menuDeleteSound
            // 
            this.menuDeleteSound.Image = global::Alarm_Clock.Properties.Resources.cancel;
            this.menuDeleteSound.Name = "menuDeleteSound";
            this.menuDeleteSound.Size = new System.Drawing.Size(144, 22);
            this.menuDeleteSound.Text = "Delete Sound";
            this.menuDeleteSound.Click += new System.EventHandler(this.deleteSound_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // menuSettings
            // 
            this.menuSettings.Image = global::Alarm_Clock.Properties.Resources.settings;
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(144, 22);
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.settings_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddSound,
            this.toolCounter,
            this.toolAlarm,
            this.toolDeleteSound,
            this.toolStripSeparator2,
            this.toolSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(211, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAddSound
            // 
            this.toolAddSound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddSound.Image = global::Alarm_Clock.Properties.Resources.plus;
            this.toolAddSound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddSound.Name = "toolAddSound";
            this.toolAddSound.Size = new System.Drawing.Size(23, 22);
            this.toolAddSound.ToolTipText = "Add Sound";
            this.toolAddSound.Click += new System.EventHandler(this.addSound_Click);
            // 
            // toolCounter
            // 
            this.toolCounter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolCounter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCounter.Image = global::Alarm_Clock.Properties.Resources.counter2;
            this.toolCounter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCounter.Name = "toolCounter";
            this.toolCounter.Size = new System.Drawing.Size(23, 22);
            this.toolCounter.Text = "Counter";
            this.toolCounter.ToolTipText = "Counter";
            this.toolCounter.Click += new System.EventHandler(this.toolAlarmCounter_Click);
            // 
            // toolAlarm
            // 
            this.toolAlarm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolAlarm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAlarm.Enabled = false;
            this.toolAlarm.Image = global::Alarm_Clock.Properties.Resources.clock;
            this.toolAlarm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAlarm.Name = "toolAlarm";
            this.toolAlarm.Size = new System.Drawing.Size(23, 22);
            this.toolAlarm.Text = "Alarm";
            this.toolAlarm.ToolTipText = "Alarm";
            this.toolAlarm.Click += new System.EventHandler(this.toolAlarmCounter_Click);
            // 
            // toolDeleteSound
            // 
            this.toolDeleteSound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDeleteSound.Image = global::Alarm_Clock.Properties.Resources.cancel;
            this.toolDeleteSound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDeleteSound.Name = "toolDeleteSound";
            this.toolDeleteSound.Size = new System.Drawing.Size(23, 22);
            this.toolDeleteSound.Text = "toolStripButton1";
            this.toolDeleteSound.ToolTipText = "Delete Sound";
            this.toolDeleteSound.Click += new System.EventHandler(this.deleteSound_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSettings
            // 
            this.toolSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSettings.Image = global::Alarm_Clock.Properties.Resources.settings;
            this.toolSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSettings.Name = "toolSettings";
            this.toolSettings.Size = new System.Drawing.Size(23, 22);
            this.toolSettings.Text = "Settings";
            this.toolSettings.Click += new System.EventHandler(this.settings_Click);
            // 
            // openFD
            // 
            this.openFD.DefaultExt = "*.mp3";
            this.openFD.Filter = "MP3 Files|*.mp3";
            this.openFD.Multiselect = true;
            // 
            // panelAlarm
            // 
            this.panelAlarm.Controls.Add(this.cmbMin);
            this.panelAlarm.Controls.Add(this.cmbHour);
            this.panelAlarm.Controls.Add(this.label1);
            this.panelAlarm.Controls.Add(this.label3);
            this.panelAlarm.Location = new System.Drawing.Point(19, 90);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(171, 58);
            this.panelAlarm.TabIndex = 7;
            // 
            // panelCounter
            // 
            this.panelCounter.Controls.Add(this.nmrCounter);
            this.panelCounter.Controls.Add(this.label4);
            this.panelCounter.Enabled = false;
            this.panelCounter.Location = new System.Drawing.Point(19, 90);
            this.panelCounter.Name = "panelCounter";
            this.panelCounter.Size = new System.Drawing.Size(171, 58);
            this.panelCounter.TabIndex = 8;
            this.panelCounter.Visible = false;
            // 
            // nmrCounter
            // 
            this.nmrCounter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrCounter.Location = new System.Drawing.Point(55, 27);
            this.nmrCounter.Name = "nmrCounter";
            this.nmrCounter.Size = new System.Drawing.Size(51, 23);
            this.nmrCounter.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Minute";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDay.Location = new System.Drawing.Point(125, 61);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(65, 19);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 262);
            this.Controls.Add(this.panelCounter);
            this.Controls.Add(this.panelAlarm);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbSounds);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblNow);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelAlarm.ResumeLayout(false);
            this.panelAlarm.PerformLayout();
            this.panelCounter.ResumeLayout(false);
            this.panelCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.ComboBox cmbSounds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer timerRemaining;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.Label lblNow;
        private System.Windows.Forms.Timer timerPlaying;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddSound;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteSound;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAddSound;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Panel panelAlarm;
        private System.Windows.Forms.Panel panelCounter;
        private System.Windows.Forms.NumericUpDown nmrCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton toolCounter;
        private System.Windows.Forms.ToolStripButton toolAlarm;
        private System.Windows.Forms.ToolStripButton toolDeleteSound;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolSettings;
    }
}

