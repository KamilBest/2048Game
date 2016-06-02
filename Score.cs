using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2048
{
    class Score
    {
        int score;
        int bestScore;
        public Score()
        {
            resetScore();
        }
        public void resetScore()
        {
            score = 0;
        }
        public void updateScore(int value)
        {
            score += value;
        }
        public void drawScore(Label label)
        {
            label.Text = score.ToString();
        }
    }
}
