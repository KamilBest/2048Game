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
        Game game;
        public MainForm()
        {
            InitializeComponent();
            board = new Board();
            game = new Game();
            drawTable();
            resetViewPanels();
        }
        public void drawTable( )
        {
            for (int i = 0; i <= this.tableLayoutPanel1.ColumnCount-1; i++)
            {
                for (int j = 0; j <= this.tableLayoutPanel1.RowCount-1; j++)
                {
                    Control c = this.tableLayoutPanel1.GetControlFromPosition(i, j);
                    if (board.gameBoard[i, j].getValue() > 0)
                        c.Text = board.gameBoard[i, j].getValue().ToString();
                    else
                        c.Text = " ";

                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
         
          
        }

        
        private void resetViewPanels()
        {
            pressA.BackColor = Color.LightGray;
            pressD.BackColor = Color.LightGray;
            pressW.BackColor = Color.LightGray;
            pressS.BackColor = Color.LightGray;

        }
        private void MainForm_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                resetViewPanels();
                pressA.BackColor = Color.Orange;
                //pressA.BackColor = Color.Orange;


            
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                resetViewPanels();
                pressD.BackColor = Color.Orange;
                board.moveRight();
                drawTable();

            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                resetViewPanels();
                pressW.BackColor = Color.Orange;


            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                resetViewPanels();
                pressS.BackColor = Color.Orange;

            }
        }
    }
}
