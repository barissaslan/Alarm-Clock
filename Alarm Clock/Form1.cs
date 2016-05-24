using NAudio.Wave;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Alarm_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime selectedTime;
        TimeSpan remainingTime;
        string[] soundLocation = new string[100];
        string[] soundNames = new string[100];
        string soundDirectory, localPath;
        int soundDuration; // second
        bool flag, alarmMode = true, haveSound = true; // flag: for dont play sound on form_load 
        WindowsMediaPlayer sound;

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            timerNow.Start();
            localPath = Environment.CurrentDirectory;
            soundDirectory = Environment.CurrentDirectory + @"\Sounds";
            if (!Directory.Exists(soundDirectory))
            {
                Directory.CreateDirectory(soundDirectory);
            }

            soundLocation = Directory.GetFiles(soundDirectory, "*.mp3");
            if (soundLocation.Length == 0)
            {
                MessageBox.Show("There was no MP3 file! Please add MP3 files from menu.", "Not Found Sound Files", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                haveSound = false;
            }

            #region Adding Minutes, Hours and Sound Names to ComboBox
            for (int i = 0; i < 60; i++)
            {
                cmbMin.Items.Add(i.ToString("00"));
            }

            for (int i = 0; i < 24; i++)
            {
                cmbHour.Items.Add(i.ToString("00"));
            }

            for (int i = 0; i < soundLocation.Length; i++)
            {
                soundNames[i] = Path.GetFileNameWithoutExtension(soundLocation[i]);
                cmbSounds.Items.Add(soundNames[i]);
            }
            #endregion
            cmbMin.SelectedIndex = 0;
            cmbHour.SelectedIndex = 0;
            cmbSounds.SelectedIndex = (haveSound) ? 0 : -1;
            flag = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            selectedTime = DateTime.Parse(cmbHour.Text + ":" + cmbMin.Text);
            getSoundDuration(cmbSounds.SelectedIndex);
            timerRemaining.Start();
        }

        private void timerRemaining_Tick(object sender, EventArgs e)
        {
            if (DateTime.Compare(selectedTime, DateTime.Now) > 0)
                remainingTime = selectedTime - DateTime.Now;
            else
                remainingTime = (selectedTime - DateTime.Now) + TimeSpan.FromDays(1);

            if (remainingTime < TimeSpan.FromSeconds(1))
            {
                timerRemaining.Stop();
                this.WindowState = FormWindowState.Normal;
                lblRemainingTime.Text = "Wake Up!";
                timerPlaying.Interval = (soundDuration + 2) * 1000;
                timerPlaying.Start();
            }
            else
            {
                lblRemainingTime.Text = "Remaining Time :   " + remainingTime.ToString(@"hh\:mm\:ss");
            }
        }

        private void timerPlaying_Tick(object sender, EventArgs e)
        {
            playSound(cmbSounds.SelectedIndex);
        }

        private void playSound(int soundIndex)
        {
            sound = new WindowsMediaPlayer();
            sound.URL = soundLocation[soundIndex];
            sound.controls.play();
        }

        private void getSoundDuration(int soundIndex)
        {
            Mp3FileReader reader = new Mp3FileReader(soundLocation[soundIndex]);
            soundDuration = (int)reader.TotalTime.TotalSeconds;
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            lblNow.Text = DateTime.Now.ToLongTimeString();
        }

        private async void cmbSounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                if (sound != null) sound.controls.stop();
                playSound(cmbSounds.SelectedIndex);
                await Task.Delay(TimeSpan.FromSeconds(3));
                sound.controls.stop();
            }
        }

        private void toolAlarmCounter_Click(object sender, EventArgs e)
        {
            panelCounter.Visible = !panelCounter.Visible;
            panelCounter.Enabled = !panelCounter.Enabled;
            panelAlarm.Enabled = !panelAlarm.Enabled;
            panelAlarm.Visible = !panelAlarm.Visible;
            alarmMode = !alarmMode;
            toolAlarm.Enabled = !toolAlarm.Enabled;
            toolCounter.Enabled = !toolCounter.Enabled;
        }

        private void addSound_Click(object sender, EventArgs e)
        {
            openFD.InitialDirectory = "C:";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in openFD.FileNames)
                {
                    // Mevcut Ses dosyalarıyla kontrol ettir.
                    File.Copy(item, Path.Combine(soundDirectory, Path.GetFileName(item)), true);
                }
            }
        }

        private void deleteSound_Click(object sender, EventArgs e)
        {
            openFD.InitialDirectory = soundDirectory;
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Dosyaları gerçekten silmek istiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (string item in openFD.FileNames)
                    {
                        File.Delete(item);
                    }
                }

            }
        }
    }
}
