using NAudio.Wave;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Alarm_Clock
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        DateTime selectedTime, playingDate;
        TimeSpan remainingTime, playingTime;
        string[] sourceSoundFiles = new string[50];
        string[] soundFiles = new string[50];
        string[] soundNames = new string[50];
        WindowsMediaPlayer sound;
        int soundDuration; // second
        bool flag, alarmMode = true, haveSound = true;
        // flag: for dont play sound on form_load 
        // if alarMode = false then counter mode on 

        private string SourceDirectory
        {
            get { return Environment.CurrentDirectory + @"\Sounds"; }
        }
        private string DocumentPath
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); }
        }
        private string SoundDirectory
        {
            get { return DocumentPath + @"\Alarm Clock\Sounds"; }
        }
        private int PlayDuration
        {
            get { return Properties.Settings.Default.AlarmDuration; }
            set
            {
                Properties.Settings.Default.AlarmDuration = value;
                Properties.Settings.Default.Save();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timerNow.Start();

            if (!Directory.Exists(SoundDirectory))
            {
                Directory.CreateDirectory(SoundDirectory);
                sourceSoundFiles = Directory.GetFiles(SourceDirectory, "*.mp3");
                foreach (string soundPath in sourceSoundFiles)
                {
                    string soundName = Path.GetFileName(soundPath);
                    File.Copy(soundPath, Path.Combine(SoundDirectory, soundName));
                }
            }

            updateItems();
        }

        private void updateItems()
        {
            soundFiles = Directory.GetFiles(SoundDirectory, "*.mp3");

            if (soundFiles.Length == 0)
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

            for (int i = 0; i < soundFiles.Length; i++)
            {
                soundNames[i] = Path.GetFileNameWithoutExtension(soundFiles[i]);
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
            if (alarmMode)
            {
                selectedTime = DateTime.Parse(cmbHour.Text + ":" + cmbMin.Text);
            }
            else
            {
                selectedTime = DateTime.Now.AddMinutes((int)nmrCounter.Value);
            }

            setEnable(false);
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
            nmrCounter.Enabled = b;
        }

        #endregion
        #region Get Sound Duration (NAudio.dll)

        private void getSoundDuration(int soundIndex)
        {
            Mp3FileReader reader = new Mp3FileReader(soundFiles[soundIndex]);
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
                playingDate = DateTime.Now.AddMinutes(PlayDuration);
                timerPlaying.Start();
            }
            else
            {
                lblRemainingTime.Text = "Remaining Time :   " + remainingTime.ToString(@"hh\:mm\:ss");
            }
        }

        private void timerPlaying_Tick(object sender, EventArgs e)
        {
            sound.close();
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

        private void settings_Click(object sender, EventArgs e)
        {
            settingsFrom settingsForm = new settingsFrom();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                PlayDuration = (int)settingsForm.nmrCounter.Value;
            }
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
            sound.URL = soundFiles[soundIndex];
            sound.controls.play();
        }

        private async void cmbSounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                cmbSounds.Enabled = false;
                playSound(cmbSounds.SelectedIndex);
                await Task.Delay(TimeSpan.FromSeconds(3));
                sound.close();
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
                    File.Copy(item, Path.Combine(SoundDirectory, Path.GetFileName(item)), true);
                }
                updateItems();
            }
        }

        private void deleteSound_Click(object sender, EventArgs e)
        {
            openFD.InitialDirectory = SoundDirectory;
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
