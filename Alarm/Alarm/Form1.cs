using System.Media;
using System.Timers;

namespace Alarm
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += TimerElapsed;
        }

        SoundPlayer soundPlayer = new SoundPlayer();
        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    soundPlayer.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    soundPlayer.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pozor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSpustit_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnZastavit_Click(object sender, EventArgs e)
        {
            timer.Stop();
            soundPlayer.Stop();
        }
    }
}