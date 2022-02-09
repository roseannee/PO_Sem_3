using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Windows.Threading;

namespace lab8
{
    internal class Karaoke
    {
        private static TextBox currentLine_tb;
        private static RichTextBox nextLines_rtb;

        private static Lyrics lyrics;

        private static SoundPlayer player;
        private static DispatcherTimer timer;

        private static bool isPlaying = false;
        private static int duration = 0;

        public static void Load(TextBox currentLine, RichTextBox nextLines)
        {
            currentLine_tb = currentLine;
            nextLines_rtb = nextLines;

            timer = new DispatcherTimer();
            timer.Tick += UpdateTimer;
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        public static void Open(string songPath, string lyricsPath)
        {
            Stop();

            player = new SoundPlayer(songPath);
            lyrics = new Lyrics(Path.GetFileNameWithoutExtension(songPath), File.ReadAllLines(lyricsPath));
        }

        public static bool Play()
        {
            if (player == null)
            {
                return false;
            }

            if (lyrics == null)
            {
                return false;
            }

            player.Play();
            timer.Start();
            isPlaying = true;
            duration = 1;

            return true;
        }

        public static void Stop()
        {
            if (player == null)
            {
                return;
            }

            player.Stop();
            timer.Stop();
            isPlaying = false;
            duration = 0;
            UpdateTimer(null, null);
        }

        private static void UpdateTimer(object sender, EventArgs e)
        {
            duration++;

            if (duration >= lyrics.songLength)
            {
                isPlaying = false;
            }

            if (!isPlaying)
            {
                currentLine_tb.Text = "";
                nextLines_rtb.Text = "";

                timer.Stop();
                duration = 0;
                return;
            }

            Lyrics.LyricsContent content = lyrics.GetContent(duration);
            currentLine_tb.Text = content.currentLine;
            nextLines_rtb.Text = content.nextLines;
        }
    }
}
