using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class MainForm : Form
    {
        Board board;
        Score score;
        public MainForm()
        {
            InitializeComponent();
            board = new Board();
            drawTable();
            resetViewPanels();
            score = new Score();
            score.drawBestScore(bestScoreLabel);

        }
        public void drawTable()
        {
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount - 1; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel1.RowCount - 1; j++)
                {
                    Control c = this.tableLayoutPanel1.GetControlFromPosition(i, j);
                    if (board.gameBoard[i, j].getValue() > 0)
                        c.Text = board.gameBoard[i, j].getValue().ToString();
                    else
                        c.Text = " ";

                }
            }
            changeBackColors();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }


        private void changeBackColors()
        {
            int fieldValue = 0;
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount - 1; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel1.RowCount - 1; j++)
                {
                    fieldValue = board.gameBoard[i, j].getValue();
                    Control c = this.tableLayoutPanel1.GetControlFromPosition(i, j);
                    switch (fieldValue)
                    {
                        case 0:
                            c.BackColor = ColorTranslator.FromHtml("#ccc0b3");
                            break;
                        case 2:
                            c.BackColor = ColorTranslator.FromHtml("#eee4da");
                            c.ForeColor = ColorTranslator.FromHtml("#776e65");
                            break;
                        case 4:
                            c.BackColor = ColorTranslator.FromHtml("#ede0c8");
                            c.ForeColor = ColorTranslator.FromHtml("#776e65");

                            break;
                        case 8:
                            c.BackColor = ColorTranslator.FromHtml("#f2b179");
                            c.ForeColor = Color.White;
                            break;
                        case 16:
                            c.BackColor = ColorTranslator.FromHtml("#f59563");
                            c.ForeColor = Color.White;

                            break;
                        case 32:
                            c.BackColor = ColorTranslator.FromHtml("#f67c5f");
                            c.ForeColor = Color.White;

                            break;
                        case 64:
                            c.BackColor = ColorTranslator.FromHtml("#f65e3b");
                            c.ForeColor = Color.White;

                            break;
                        case 128:
                            c.BackColor = ColorTranslator.FromHtml("#edcf72");
                            c.ForeColor = Color.White;

                            break;
                        case 256:
                            c.BackColor = ColorTranslator.FromHtml("#f6cb5a");
                            c.ForeColor = Color.White;

                            break;
                        case 512:
                            c.BackColor = ColorTranslator.FromHtml("#f7c74b");
                            c.ForeColor = Color.White;

                            break;
                        case 1024:
                            c.BackColor = ColorTranslator.FromHtml("#f8c440");
                            c.ForeColor = Color.White;

                            break;
                        case 2048:
                            c.BackColor = ColorTranslator.FromHtml("#eec22e");
                            c.ForeColor = Color.White;

                            break;
                    }

                }
            }
        }
        private void resetViewPanels()
        {
            pressA.BackColor = Color.FromArgb(119,110,101);
            pressD.BackColor = Color.FromArgb(119, 110, 101);
            pressW.BackColor = Color.FromArgb(119, 110, 101);
            pressS.BackColor = Color.FromArgb(119, 110, 101);

        }
        private void MainForm_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (board.moveCellsLeft())
                {
                    resetViewPanels();
                    pressA.BackColor = Color.Orange;
                    if (!board.isGameOver())
                    {
                        
                        board.addNewField();
                        drawTable();

                    }
                }
                else if (board.isGameOver())
                    gameOver();
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (board.moveCellsRight())
                {
                    resetViewPanels();
                    pressD.BackColor = Color.Orange;
                    if (!board.isGameOver())
                    {
                        
                        board.addNewField();
                        drawTable();

                    }
                }
                else if (board.isGameOver())
                    gameOver();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (board.moveCellsUp())
                {
                    resetViewPanels();
                    pressW.BackColor = Color.Orange;
                    if (!board.isGameOver())
                    {
                    
                        board.addNewField();
                        drawTable();

                    }
                }
                else if (board.isGameOver())
                    gameOver();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (board.moveCellsDown())
                {
                    resetViewPanels();
                    pressS.BackColor = Color.Orange;
                    if (!board.isGameOver())
                    {
                   
                        board.addNewField();
                        drawTable();

                    }
                }
                else if (board.isGameOver())
                    gameOver();
            }
            score.updateScore(board.getScoreValue());
            score.drawScore(scoreLabel);
            score.drawBestScore(bestScoreLabel);

            if (score.isScoreTheBest())
            {
                score.drawScore(bestScoreLabel);
            }

           

        }
        private void drawGameOver()
        {
            gameOverPanel.Visible = true;
            gameOverPanel.Enabled = true;

        }
        private void gameOver()
        {
            drawGameOver();
            if(score.isScoreTheBest())
            {
                score.updateBestScore();

                score.writeBestScore();
            }
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You want to reset the game?", "Reset Game", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                score.resetScore();
                score.drawScore(scoreLabel);
                score.drawBestScore(bestScoreLabel);

                board.resetBoard();
           drawTable();
            }
                    
        }

        

        private void changeToOrange(object sender, EventArgs e)
        {
            resetGameButton.BackColor = Color.Orange;

        }

        private void changeToGray(object sender, EventArgs e)
        {
            resetGameButton.BackColor = Color.FromArgb(119, 110, 101);

        }

        private void PlayAgain_Click_1(object sender, EventArgs e)
        {
            gameOverPanel.Visible = false;
            gameOverPanel.Enabled = false;


            score.resetScore();
            score.drawScore(scoreLabel);

            board.resetBoard();
            drawTable();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
