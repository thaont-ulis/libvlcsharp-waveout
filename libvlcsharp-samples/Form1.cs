using System;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace libvlcsharp_samples
{
    public partial class LibVLCSharp_Sample : Form
    {
        public string[] optionsAutomatic = {
                "--input-repeat=65535"
        };
        public string[] optionsWaveOut = {
                "--aout=waveout",
                "--no-waveout-float32",
                "--input-repeat=65535"
        };
        public LibVLC libVLC;
        public MediaPlayer mediaPlayer;
        public VideoView videoView;

        public int ttsleep = 0;
        private static readonly object syncLock = new object();
        public LibVLCSharp_Sample()
        {
            InitializeComponent();

            Core.Initialize();
            libVLC = new LibVLC(optionsWaveOut);
            mediaPlayer = new MediaPlayer(libVLC);

            videoView = new VideoView();
            videoView.MediaPlayer = mediaPlayer;

            videoView.Dock = DockStyle.Fill;
            vlcPanel.Controls.Add(videoView);
        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtVideo1.Text))
            {
                ResetMedia();
                mediaPlayer.PositionChanged += MediaPlayer_PositionChanged;
                mediaPlayer.Play(new Media(libVLC, txtVideo1.Text));
            }
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtVideo2.Text))
            {
                ResetMedia();
                mediaPlayer.PositionChanged += MediaPlayer_PositionChanged;
                mediaPlayer.Play(new Media(libVLC, txtVideo2.Text));
            }
        }

        private void btnPlay3_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtVideo3.Text))
            {
                ResetMedia();
                mediaPlayer.PositionChanged += MediaPlayer_PositionChanged;
                mediaPlayer.Play(new Media(libVLC, txtVideo3.Text));
            }
        }

        private void btnPlay4_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtVideo4.Text))
            {
                ResetMedia();
                mediaPlayer.PositionChanged += MediaPlayer_PositionChanged;
                mediaPlayer.Play(new Media(libVLC, txtVideo4.Text));
            }
        }

        private void btnPlay5_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtVideo5.Text))
            {
                ResetMedia();
                mediaPlayer.PositionChanged += MediaPlayer_PositionChanged;
                mediaPlayer.Play(new Media(libVLC, txtVideo5.Text));
            }
        }

        private void audioOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (audioOption.SelectedIndex == 0)
            {
                libVLC = new LibVLC(optionsAutomatic);
                mediaPlayer = new MediaPlayer(libVLC);
                videoView.MediaPlayer = mediaPlayer;
            }
            else
            {
                libVLC = new LibVLC(optionsWaveOut);
                mediaPlayer = new MediaPlayer(libVLC);
                videoView.MediaPlayer = mediaPlayer;
            }
        }

        private void ResetMedia()
        {
            audioOption.Enabled = false;
            btnPause.Text = "RESUME";
            //if (mediaPlayer.IsPlaying)
            //{
            //    mediaPlayer.Play();
            //    Thread.Sleep(ttsleep);
            //    mediaPlayer.Stop();
            //    if (mediaPlayer.Media != null)
            //    {
            //        mediaPlayer.Media.Dispose();
            //    }
            //}
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.IsPlaying)
            {
                btnPause.Text = "RESUME";
                mediaPlayer.Pause();
            }
            else
            {
                btnPause.Text = "PAUSE";
                mediaPlayer.Play();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            audioOption.Enabled = true;
            if (mediaPlayer.IsPlaying)
            {
                mediaPlayer.Stop();
            }
        }

        private void MediaPlayer_PositionChanged(object? sender, MediaPlayerPositionChangedEventArgs e)
        {
            lock (syncLock)
            {
                try
                {
                    mediaPlayer.PositionChanged -= MediaPlayer_PositionChanged;
                    mediaPlayer.Pause();
                }
                catch { }
            }
        }
    }
}
