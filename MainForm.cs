﻿using System;
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
        public MainForm(bool option)
        {
            InitializeComponent();
            board = new Board();
            drawBoard();
            resetViewPanels();
            score = new Score();
            if (!option)
                score.resetBestScore();
            score.drawBestScore(bestScoreLabel);

        }

        private void drawBoard()
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
            drawBiggestTile();
            changeCellsBackColor();
        }

        /**
        Draw biggest cell value method.
            It shows the biggest tile under scores.
         */
        private void drawBiggestTile()
        {
            tile.Text = board.takeBiggestTile().ToString();
            changeColors(tile, board.takeBiggestTile());
        }

        /**
        Change backcolor of specified control and value.
        */
        private void changeColors(Control control, int value)
        {
            switch (value)
            {
                case 0:
                    control.BackColor = ColorTranslator.FromHtml("#ccc0b3");
                    break;
                case 2:
                    control.BackColor = ColorTranslator.FromHtml("#eee4da");
                    control.ForeColor = ColorTranslator.FromHtml("#776e65");
                    break;
                case 4:
                    control.BackColor = ColorTranslator.FromHtml("#ede0c8");
                    control.ForeColor = ColorTranslator.FromHtml("#776e65");
                    break;
                case 8:
                    control.BackColor = ColorTranslator.FromHtml("#f2b179");
                    control.ForeColor = Color.White;
                    break;
                case 16:
                    control.BackColor = ColorTranslator.FromHtml("#f59563");
                    control.ForeColor = Color.White;
                    break;
                case 32:
                    control.BackColor = ColorTranslator.FromHtml("#f67c5f");
                    control.ForeColor = Color.White;
                    break;
                case 64:
                    control.BackColor = ColorTranslator.FromHtml("#f65e3b");
                    control.ForeColor = Color.White;
                    break;
                case 128:
                    control.BackColor = ColorTranslator.FromHtml("#edcf72");
                    control.ForeColor = Color.White;
                    break;
                case 256:
                    control.BackColor = ColorTranslator.FromHtml("#f6cb5a");
                    control.ForeColor = Color.White;
                    break;
                case 512:
                    control.BackColor = ColorTranslator.FromHtml("#f7c74b");
                    control.ForeColor = Color.White;
                    break;
                case 1024:
                    control.BackColor = ColorTranslator.FromHtml("#f8c440");
                    control.ForeColor = Color.White;
                    break;
                case 2048:
                    control.BackColor = ColorTranslator.FromHtml("#eec22e");
                    control.ForeColor = Color.White;
                    break;
            }
        }

        /**
        Method change backcolor for each board cell with specified value.
        */
        private void changeCellsBackColor()
        {
            int fieldValue = 0;
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount - 1; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel1.RowCount - 1; j++)
                {
                    fieldValue = board.gameBoard[i, j].getValue();
                    Control c = this.tableLayoutPanel1.GetControlFromPosition(i, j);
                    changeColors(c, fieldValue);
                }
            }
        }

        /**
        Set Move indicators to gray backcolor.
            Using after each move.
        */
        private void resetViewPanels()
        {
            pressA.BackColor = Color.FromArgb(119, 110, 101);
            pressD.BackColor = Color.FromArgb(119, 110, 101);
            pressW.BackColor = Color.FromArgb(119, 110, 101);
            pressS.BackColor = Color.FromArgb(119, 110, 101);
        }

        /**
        Keyboard controll.
            It runs general methods.
        */
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
                        drawBoard();
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
                        drawBoard();
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
                        drawBoard();
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
                        drawBoard();
                    }
                }
                else if (board.isGameOver())
                    gameOver();
            }
            if (board.takeBiggestTile() == 2048)
            {
                congratulations.Visible = true;
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

        /**
        Shows game over message.
        */
        private void drawGameOver()
        {
            gameOverPanel.Visible = true;
            gameOverPanel.Enabled = true;
        }

        /**
            Display game over. Set best score if score is higher than current best score. 
            Runs method to write Write best score to file scores.txt
        */
        private void gameOver()
        {
            drawGameOver();
            if (score.isScoreTheBest())
            {
                score.updateBestScore();

                score.writeBestScore();
            }
        }

        /**
        Reset game method with message box with a confirmation.
        */
        private void PlayAgain_Click(object sender, EventArgs e)
        {
            gameOverPanel.Visible = false;
            gameOverPanel.Enabled = false;
            congratulations.Visible = false;
            DialogResult dialogResult = MessageBox.Show("Do You want to reset the game?", "Reset Game", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                score.resetScore();
                score.drawScore(scoreLabel);
                score.drawBestScore(bestScoreLabel);
                board.resetBoard();
                drawBoard();
            }
        }

        /**
        Play again game method after game over.
        */
        private void PlayAgain_Click_2(object sender, EventArgs e)
        {
            gameOverPanel.Visible = false;
            gameOverPanel.Enabled = false;
            congratulations.Visible = false;
            score.resetScore();
            score.drawScore(scoreLabel);
            score.drawBestScore(bestScoreLabel);
            board.resetBoard();
            drawBoard();
        }

        /**
        Change to orange backcolor on mouse enter.
          */
        private void changeToOrange(object sender, EventArgs e)
        {
            resetGameButton.BackColor = Color.Orange;
        }
        /**
      Change to gray backcolor on mouse leave.
         */
        private void changeToGray(object sender, EventArgs e)
        {
            resetGameButton.BackColor = Color.FromArgb(119, 110, 101);
        }

        /**
        Back to menu method
         */
        private void backToMenu()
        {
            DialogResult dialogResult = MessageBox.Show("Do You want to back to Menu?", "Back to Menu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
        }

        /**
        Back to menu button on click
        */
        private void menu_Click(object sender, EventArgs e)
        {
            backToMenu();
        }
        /**
        Back to menu button on click
     */
        private void backToMenuButton_Click_1(object sender, EventArgs e)
        {
            backToMenu();
        }
    }
}
