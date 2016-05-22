using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        protected void drawField()
        {
            int row, column;
            do
            {
                row = random.Next(0, BOARD_SIZE);
                column = random.Next(0, BOARD_SIZE);
                if (gameBoard[row, column].getValue() == 2)
                    gameBoard[row, column].doubleValue();
                else {
                    gameBoard[row, column].setFirstValue();
                    break;
                }
            } while (true);

        }
        public void moveRight()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 3; i >= 0; i--)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (gameBoard[k,j].getValue() == 0)
                        {
                            continue;
                        }
                        else if (gameBoard[k,j].getValue() == gameBoard[i,j].getValue())
                        {
                            gameBoard[i,j].doubleValue();
                            gameBoard[k,j].resetValue();
                            break;
                        }
                        else
                        {
                            if (gameBoard[i,j].getValue() == 0 && gameBoard[k,j].getValue() != 0)
                            {
                                gameBoard[i, j].setValue(gameBoard[k, j].getValue());
                                gameBoard[k,j].resetValue();
                                i++;
                                break;
                            }
                            else if (gameBoard[i,j].getValue() != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
        public void moveUp()
        {
            
                
            
        }
    }
}
  
