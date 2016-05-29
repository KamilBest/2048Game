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
        public MainForm()
        {
            InitializeComponent();
            board = new Board();
            drawTable();
            resetViewPanels();
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

        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }


        private void changeBackColours()
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
                            c.BackColor = ColorTranslator.FromHtml("#fff");
                            break;
                        case 2:
                            c.BackColor = ColorTranslator.FromHtml("#ebebeb");

                            break;
                        case 4:
                            c.BackColor = ColorTranslator.FromHtml("#d6d6d6");

                            break;
                        case 8:
                            c.BackColor = ColorTranslator.FromHtml("#c2c2c2");

                            break;
                        case 16:
                            c.BackColor = ColorTranslator.FromHtml("#adadad");

                            break;
                        case 32:
                            c.BackColor = ColorTranslator.FromHtml("#999999");

                            break;
                        case 64:
                            c.BackColor = ColorTranslator.FromHtml("#858585");

                            break;
                        case 128:
                            c.BackColor = ColorTranslator.FromHtml("#707070");

                            break;
                        case 256:
                            c.BackColor = ColorTranslator.FromHtml("#5c5c5c");

                            break;
                        case 512:
                            c.BackColor = ColorTranslator.FromHtml("#474747");

                            break;
                        case 1024:
                            c.BackColor = ColorTranslator.FromHtml("#333333");

                            break;
                        case 2048:
                            c.BackColor = ColorTranslator.FromHtml("#141414");

                            break;
                    }

                }
            }
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
                board.moveLeft();
                board.drawField();
                drawTable();


            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                resetViewPanels();
                pressD.BackColor = Color.Orange;
                board.moveRight();
                board.drawField();

                drawTable();

            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                resetViewPanels();
                pressW.BackColor = Color.Orange;
                board.moveUp();
                board.drawField();

                drawTable();


            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                resetViewPanels();
                pressS.BackColor = Color.Orange;
                board.moveBottom();
                board.drawField();

                drawTable();

            }
            changeBackColours();
        }
    }
}
