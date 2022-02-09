using System;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        public string songPath;
        public string lyricsPath;

        public Form1()
        {
            InitializeComponent();

            Karaoke.Load(currentLine_tb, nextLines_rtb);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openSong.ShowDialog() == DialogResult.OK)
            {
                songPath = openSong.FileName;
            }
            else
            {
                MessageBox.Show("Choose the song!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (openLyrics.ShowDialog() == DialogResult.OK)
            {
                lyricsPath = openLyrics.FileName;
            }
            else
            {
                MessageBox.Show("Choose the lirycs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Karaoke.Open(songPath, lyricsPath);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Karaoke.Play();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Karaoke.Stop();
        }
    }
}
