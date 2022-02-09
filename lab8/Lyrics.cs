using System.Collections.Generic;
using System.Linq;

namespace lab8
{
    internal class Lyrics
    {
        public string fileName;
        public int songLength;

        private Dictionary<int, string> lines = new Dictionary<int, string>();

        public Lyrics(string fileName, string[] fileLines)
        {
            this.fileName = fileName;
            string[] allLines = fileLines[0].Split(';');
            songLength = int.Parse(allLines[1]);

            for (int i = 1; i < fileLines.Length; i++)
            {
                allLines = fileLines[i].Split(';');
                lines.Add(int.Parse(allLines[0]), allLines[1]);
            }
        }

        public LyricsContent GetContent(int sec)
        {
            LyricsContent tempContent = new LyricsContent();

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines.ElementAt(i).Key < sec)
                {
                    tempContent.currentLine = lines.ElementAt(i).Value;
                }
                else
                {
                    tempContent.nextLines += lines.ElementAt(i).Value + "\n";
                }
            }

            return tempContent;
        }

        public class LyricsContent
        {
            public string currentLine;
            public string nextLines;
        }
    }
}
