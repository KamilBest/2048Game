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

        /**
        Constructor. Read best score from file. Reset score.
        */
        public Score()
        {
            readBestScore();
            resetScore();
        }

        /**
        Get score.
        */
        public int getScore()
        {
            return score;
        }

        /**
        Get best score.
        */
        public int getBestScore()
        {
            return bestScore;
        }

        /**
        Write best score to text file named scores.txt
        */
        public void writeBestScore()
        {
            using (StreamWriter streamWriter = new StreamWriter("scores.txt"))
            {
                streamWriter.Write(bestScore.ToString());
                streamWriter.Flush();
            }
        }

        /**
        Read best score from file scores.txt.
        */
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

        /**
        Check whether score is the best.
        */
        public bool isScoreTheBest()
        {
            if (score > bestScore)
            {
                return true;
            }
            return false;
        }

        /**
        Set score to 0 (reset).
        */
        public void resetScore()
        {
            score = 0;
        }

        /**
        Set best score to 0 (reset).
        */
        public void resetBestScore()
        {
            bestScore = 0;
        }

        /**
        Update score to next given value.
        */
        public void updateScore(int value)
        {
            score = value;
        }

        /**
        Update best score to score.
        */
        public void updateBestScore()
        {
            bestScore = score;
        }

        /**
        Draw score value in label.
        */
        public void drawScore(Label label)
        {
            label.Text = score.ToString();
        }

        /**
        Draw best score value in label.
        */
        public void drawBestScore(Label label)
        {
            label.Text = bestScore.ToString();
        }
    }
}
