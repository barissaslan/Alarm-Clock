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

        DateTime selectedTime, playingDate;
        TimeSpan remainingTime, playingTime;
        string[] soundsPath = new string[100];
        string[] soundNames = new string[100];
        string soundDirectory, localPath;
        WindowsMediaPlayer sound;
        int soundDuration; // second
        bool flag, alarmMode = true, haveSound = true;
        // flag: for dont play sound on form_load 
        // if alarMode = false then counter mode on 

        private void Form1_Load(object sender, EventArgs e)
        {
            timerNow.Start();
            localPath = Environment.CurrentDirectory;
            soundDirectory = Environment.CurrentDirectory + @"\Sounds";

            if (!Directory.Exists(soundDirectory))
            {
                Directory.CreateDirectory(soundDirectory);
            }

            updateItems();
        }

        private void updateItems()
        {
            soundsPath = Directory.GetFiles(soundDirectory, "*.mp3");

            if (soundsPath.Length == 0)
            {
                MessageBox.Show("There was no MP3 file! Please add MP3 files from menu.", "Not Found Sound Files", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                haveSound = false;
            }

            flag = false;
            #region Adding Minutes, Hours and Sound Names to ComboBox
            cmbMin.Items.Clear();
            cmbHour.Items.Clear();
            cmbSounds.Items.Clear();
            for (int i = 0; i < 60; i++)
            {
                cmbMin.Items.Add(i.ToString("00"));
            }

            for (int i = 0; i < 24; i++)
            {
                cmbHour.Items.Add(i.ToString("00"));
            }

            for (int i = 0; i < soundsPath.Length; i++)
            {
                soundNames[i] = Path.GetFileNameWithoutExtension(soundsPath[i]);
                cmbSounds.Items.Add(soundNames[i]);
            }
            #endregion
            cmbHour.SelectedIndex = DateTime.Now.Hour;
            cmbMin.SelectedIndex = DateTime.Now.Minute;
            cmbSounds.SelectedIndex = (haveSound) ? 0 : -1;
            flag = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            setEnable(false);
            selectedTime = DateTime.Parse(cmbHour.Text + ":" + cmbMin.Text);
            getSoundDuration(cmbSounds.SelectedIndex);
            timerRemaining.Start();
        }

        #region Set Enable

        private void setEnable(bool b)
        {
            cmbMin.Enabled = b;
            cmbHour.Enabled = b;
            cmbSounds.Enabled = b;
            btnStart.Enabled = b;
        }

        #endregion
        #region Get Sound Duration (NAudio.dll)

        private void getSoundDuration(int soundIndex)
        {
            Mp3FileReader reader = new Mp3FileReader(soundsPath[soundIndex]);
            soundDuration = (int)reader.TotalTime.TotalSeconds;
        }

        #endregion

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
                playSound(cmbSounds.SelectedIndex);
                timerPlaying.Interval = (soundDuration + 2) * 1000;
                playingDate = DateTime.Now.AddMinutes(5);
                timerPlaying.Start();
            }
            else
            {
                lblRemainingTime.Text = "Remaining Time :   " + remainingTime.ToString(@"hh\:mm\:ss");
            }
        }

        private void timerPlaying_Tick(object sender, EventArgs e)
        {
            playingTime = playingDate - DateTime.Now;

            if (playingTime > TimeSpan.FromSeconds(1))
                playSound(cmbSounds.SelectedIndex);
            else
                timerPlaying.Stop();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            lblNow.Text = DateTime.Now.ToLongTimeString();
            lblDay.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timerRemaining.Stop();
            timerPlaying.Stop();
            lblRemainingTime.Text = "";
            setEnable(true);
            updateItems();
        }

        private void playSound(int soundIndex)
        {
            sound = new WindowsMediaPlayer();
            sound.URL = soundsPath[soundIndex];
            sound.controls.play();
        }

        private async void cmbSounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                cmbSounds.Enabled = false;
                playSound(cmbSounds.SelectedIndex);
                await Task.Delay(TimeSpan.FromSeconds(3));
                sound.controls.stop();
                cmbSounds.Enabled = true;
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
            openFD.Title = "Add";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in openFD.FileNames)
                {
                    File.Copy(item, Path.Combine(soundDirectory, Path.GetFileName(item)), true);
                }
                updateItems();
            }
        }

        private void deleteSound_Click(object sender, EventArgs e)
        {
            openFD.InitialDirectory = soundDirectory;
            openFD.Title = "Remove";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Do you want to remove sound files?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (string item in openFD.FileNames)
                    {
                        File.Delete(item);
                    }
                    updateItems();
                }
            }
        }
    }
}
