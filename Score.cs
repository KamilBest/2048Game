using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2048
{
    class Score
    {
        int score;
        int bestScore = 0;
        public Score()
        {
            // writeBestScore();
            readBestScore();
            resetScore();
        }
        public int getScore()
        {
            return score;
        }
        public int getBestScore()
        {
            return bestScore;
        }
        public void writeBestScore()
        {
            using (StreamWriter streamWriter = new StreamWriter("scores.txt"))
            {
                streamWriter.Write(bestScore.ToString());
                streamWriter.Flush();
            }
        }
        private void readBestScore()
        {

            using (StreamReader read = new StreamReader("scores.txt"))
            {
                string textRow = "";
                if (new FileInfo("scores.txt").Length > 0)
                {
                    textRow = read.ReadLine();
                    bestScore = int.Parse(textRow);
                }
                else
                {
                    bestScore = 0;
                }
            }
        }
        public bool isScoreTheBest()
        {
            if (score > bestScore)
            {
                return true;
            }
            return false;
        }
        public void resetScore()
        {
            score = 0;
        }
        public void updateScore(int value)
        {
            score = value;
        }
        public void updateBestScore()
        {
            bestScore = score;
        }
        public void drawScore(Label label)
        {
            label.Text = score.ToString();
        }
        public void drawBestScore(Label label)
        {
            label.Text = bestScore.ToString();
        }
    }
}
