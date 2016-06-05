using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2048
{
    class Board
    {
        const int BOARD_SIZE = 4;
        public Cell[,] gameBoard;
        Random random = new Random();
        int cellAddValue=0;
        public Board()
        {
            gameBoard = new Cell[BOARD_SIZE, BOARD_SIZE];
            resetBoard();
           
        }
        /**
         Rest Board - clear board.
        */
        public void resetBoard()
        {
            cellAddValue = 0;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    gameBoard[i, j] = new Cell();
                }
            }
            addNewField();
            addNewField();
          
        }

        /**
        draw field and set there beggining value value 
            if field has 2 as a value double it and draw another field.
        */
        public void addNewField()
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
        public int takeBiggestTile()
        {
            int max = gameBoard[0, 0].getValue();
            for(int i=0;i<BOARD_SIZE;i++)
            {
                for(int j=0;j<BOARD_SIZE;j++)
                {
                    if (gameBoard[i, j].getValue() > max)
                        max = gameBoard[i, j].getValue();
                }
            }
            return max;
        }

        /**
        Check whether game is over. 
            If grid is full and we can't do any move.
    */
        public bool isGameOver()
        {
            return isGridFull() && !isMovePossible();
        }
        public bool is2048()
        {
            if (takeBiggestTile() == 2048)
                return true;
            return false;
        }

        /**
        Check whether grid is full. (Every single cell can't be 0 value).
        */
        private bool isGridFull()
        {
            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                for (int columns = 0; columns < BOARD_SIZE; columns++)
                {
                    if (gameBoard[rows, columns].isZeroValue())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /**
        Check whether move is possible.
            First loops for checking right and left move, second for up and down move.
        */
        private bool isMovePossible()
        {
            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                for (int columns = 0; columns < (BOARD_SIZE - 1); columns++)
                {
                    int columnsPlus = columns + 1;
                    if (gameBoard[rows, columns].getValue() == gameBoard[rows, columnsPlus].getValue())
                    {
                        return true;
                    }
                }
            }

            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                for (int rows = 0; rows < (BOARD_SIZE - 1); rows++)
                {
                    int rowsPlus = rows + 1;
                    if (gameBoard[rows, columns].getValue() == gameBoard[rowsPlus, columns].getValue())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /**
        Move cells up.
        */
        public bool moveCellsUp()
        {
            bool dirty = false;

            if (moveCellsUpLoop())
                dirty = true;

            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                for (int columns = 0; columns < (BOARD_SIZE - 1); columns++)
                {
                    int columnsPlus = columns + 1;
                    dirty = combineCells(rows, columnsPlus, rows, columns, dirty);
                }
            }

            if (moveCellsUpLoop())
                dirty = true;

            return dirty;
        }
        /**
        Looped move cells up.

        */
        private bool moveCellsUpLoop()
        {
            bool dirty = false;

            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                bool columnDirty = false;
                do
                {
                    columnDirty = false;
                    for (int columns = 0; columns < (BOARD_SIZE - 1); columns++)
                    {
                        int columnsPlus = columns + 1;
                        bool cellDirty = moveCell(rows, columnsPlus, rows, columns);
                        if (cellDirty)
                        {
                            columnDirty = true;
                            dirty = true;
                        }
                    }
                } while (columnDirty);
            }

            return dirty;
        }

        /**
        Move cells down.
        */
        public bool moveCellsDown()
        {
            bool dirty = false;

            if (moveCellsDownLoop()) dirty = true;

            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                for (int columns = BOARD_SIZE - 1; columns > 0; columns--)
                {
                    int columnsPlus = columns - 1;
                    dirty = combineCells(rows, columnsPlus, rows, columns, dirty);
                }
            }

            if (moveCellsDownLoop()) dirty = true;

            return dirty;
        }
        /**
       Looped move cells down.

       */
        private bool moveCellsDownLoop()
        {
            bool dirty = false;

            for (int rows = 0; rows < BOARD_SIZE; rows++)
            {
                bool columnDirty = false;
                do
                {
                    columnDirty = false;
                    for (int columns = BOARD_SIZE - 1; columns > 0; columns--)
                    {
                        int columnsPlus = columns - 1;
                        bool cellDirty = moveCell(rows, columnsPlus, rows, columns);
                        if (cellDirty)
                        {
                            columnDirty = true;
                            dirty = true;
                        }
                    }
                } while (columnDirty);
            }

            return dirty;
        }
        /**
        Move cells left.
        */
        public bool moveCellsLeft()
        {
            bool dirty = false;

            if (moveCellsLeftLoop()) dirty = true;

            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                for (int rows = 0; rows < (BOARD_SIZE - 1); rows++)
                {
                    int rowsPlus = rows + 1;
                    dirty = combineCells(rowsPlus, columns, rows, columns, dirty);
                }
            }

            if (moveCellsLeftLoop()) dirty = true;

            return dirty;
        }
        /**
       Looped move cells left.

       */
        private bool moveCellsLeftLoop()
        {
            bool dirty = false;

            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                bool rowDirty = false;
                do
                {
                    rowDirty = false;
                    for (int rows = 0; rows < (BOARD_SIZE - 1); rows++)
                    {
                        int rowsPlus = rows + 1;
                        bool cellDirty = moveCell(rowsPlus, columns, rows, columns);
                        if (cellDirty)
                        {
                            rowDirty = true;
                            dirty = true;
                        }
                    }
                } while (rowDirty);
            }

            return dirty;
        }
        /**
        Move cells right.
        */
        public bool moveCellsRight()
        {
            bool dirty = false;

            if (moveCellsRightLoop()) dirty = true;

            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                for (int rows = (BOARD_SIZE - 1); rows > 0; rows--)
                {
                    int rowsPlus = rows - 1;
                    dirty = combineCells(rowsPlus, columns, rows, columns, dirty);
                }
            }

            if (moveCellsRightLoop()) dirty = true;

            return dirty;
        }
        /**
       Looped move cells right.

       */
        private bool moveCellsRightLoop()
        {
            bool dirty = false;

            for (int columns = 0; columns < BOARD_SIZE; columns++)
            {
                bool rowDirty = false;
                do
                {
                    rowDirty = false;
                    for (int rows = (BOARD_SIZE - 1); rows > 0; rows--)
                    {
                        int rowsPlus = rows - 1;
                        bool cellDirty = moveCell(rowsPlus, columns, rows, columns);
                        if (cellDirty)
                        {
                            rowDirty = true;
                            dirty = true;
                        }
                    }
                } while (rowDirty);
            }

            return dirty;
        }

        /**
        Combine/merge cells with the same values
        */
        private bool combineCells(int x1, int y1, int x2, int y2,
                bool dirty)
        {
            if (!gameBoard[x1, y1].isZeroValue())
            {
                int value = gameBoard[x1, y1].getValue();
                if (gameBoard[x2, y2].getValue() == value)
                {
                    int newValue = value + value;
                    gameBoard[x2, y2].setValue(newValue);
                    gameBoard[x1, y1].setZeroValue();
                    cellAddValue += newValue;
                    dirty = true;
                }
            }
            return dirty;
        }
       
        public int getScoreValue()
        {
            return cellAddValue;
        }

        /**
        Move cell when there are empty cells (zero value cells).
        */
        private bool moveCell(int x1, int y1, int x2, int y2)
        {
            bool dirty = false;
            if (!gameBoard[x1, y1].isZeroValue()
                    && (gameBoard[x2, y2].isZeroValue()))
            {
                int value = gameBoard[x1, y1].getValue();
                gameBoard[x2, y2].setValue(value);
                gameBoard[x1, y1].setValue(0);
                dirty = true;
            }
            return dirty;
        }



       

    }

}


