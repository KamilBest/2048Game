using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2048
{
    class Board : Cell
    {
        const int BOARD_SIZE = 4;
        public Cell[,] gameBoard;
        Random random = new Random();

        public Board()
        {

            gameBoard = new Cell[BOARD_SIZE, BOARD_SIZE];
            resetBoard();
        }
        /**
         Rest Board - clear board.
        */
        private void resetBoard()
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    gameBoard[i, j] = new Cell();
                }
            }
            drawField();
            drawField();
        }

        /**
        draw field and set there beggining value value 
            if field has 2 as a value double it and draw another field.
        */
        public void drawField()
        {
            int row, column, value;
            bool notValid = true;
            while (notValid)
            {
                row = random.Next(0, BOARD_SIZE);
                column = random.Next(0, BOARD_SIZE);
                if (gameBoard[row, column].getValue() == 0)
                {
                    value = random.Next(10) < 9 ? 2 : 4;
                    gameBoard[row, column].setValue(value);
                    notValid = false;
                }
            }
        }
        public bool checkGameOver()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i - 1 >= 0)
                    {
                        if (gameBoard[i - 1, j].getValue() == gameBoard[i, j].getValue())
                        {
                            return false;
                        }
                    }

                    if (i + 1 < 4)
                    {
                        if (gameBoard[i + 1, j].getValue() == gameBoard[i, j].getValue())
                        {
                            return false;
                        }
                    }

                    if (j - 1 >= 0)
                    {
                        if (gameBoard[i, j - 1].getValue() == gameBoard[i, j].getValue())
                        {
                            return false;
                        }
                    }

                    if (j + 1 < 4)
                    {
                        if (gameBoard[i, j + 1].getValue() == gameBoard[i, j].getValue())
                        {
                            return false;
                        }
                    }

                    if (gameBoard[i, j].getValue() == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void moveUp()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (gameBoard[i, k].getValue() == 0)
                        {
                            continue;
                        }
                        else if (gameBoard[i, k].getValue() == gameBoard[i, j].getValue())
                        {
                            gameBoard[i, j].doubleValue();
                            gameBoard[i, k].resetValue();
                            break;
                        }
                        else
                        {
                            if (gameBoard[i, j].getValue() == 0 && gameBoard[i, k].getValue() != 0)
                            {
                                gameBoard[i, j].setValue(gameBoard[i, k].getValue());
                                gameBoard[i, k].resetValue();
                                j--;
                                break;
                            }
                            else if (gameBoard[i, j].getValue() != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
        public void moveRight()
        {

            for (int j = 0; j < 4; j++)
            {
                for (int i = 3; i >= 0; i--)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (gameBoard[k, j].getValue() == 0)
                        {
                            continue;
                        }
                        else if (gameBoard[k, j].getValue() == gameBoard[i, j].getValue())
                        {
                            gameBoard[i, j].doubleValue();
                            gameBoard[k, j].resetValue();
                            break;
                        }
                        else
                        {
                            if (gameBoard[i, j].getValue() == 0 && gameBoard[k, j].getValue() != 0)
                            {
                                gameBoard[i, j].setValue(gameBoard[k, j].getValue());
                                gameBoard[k, j].resetValue();
                                i++;
                                break;
                            }
                            else if (gameBoard[i, j].getValue() != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
        public void moveBottom()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (gameBoard[i, k].getValue() == 0)
                        {
                            continue;
                        }
                        else if (gameBoard[i, k] == gameBoard[i, j])
                        {
                            gameBoard[i, j].doubleValue();
                            gameBoard[i, k].resetValue();
                            break;
                        }
                        else
                        {
                            if (gameBoard[i, j].getValue() == 0 && gameBoard[i, k].getValue() != 0)
                            {
                                gameBoard[i, j].setValue(gameBoard[i, k].getValue());
                                gameBoard[i, k].resetValue(); ;
                                j++;
                                break;
                            }
                            else if (gameBoard[i, j].getValue() != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
        public void moveLeft()
        {

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int k = i + 1; k < 4; k++)
                    {
                        if (gameBoard[k, j].getValue() == 0)
                        {
                            continue;
                        }
                        else if (gameBoard[k, j] == gameBoard[i, j])
                        {
                            gameBoard[i, j].doubleValue();
                            gameBoard[k, j].resetValue();
                            break;
                        }
                        else
                        {
                            if (gameBoard[i, j].getValue() == 0 && gameBoard[k, j].getValue() != 0)
                            {
                                gameBoard[i, j].setValue(gameBoard[k, j].getValue());
                                gameBoard[k, j].resetValue();
                                i--;
                                break;
                            }
                            else if (gameBoard[i, j].getValue() != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }


    }
}

