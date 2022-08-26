// Jason Hatfield
// This is my original work
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create an application that simulates a game of tic-tac-toe.
        /// - Windows Form
        /// - 2D Array
        /// - Provide a screenshot of the working program
        /// </summary>
        private void newGameButton_Click(object sender, EventArgs e)
        {
            PlayGame();
        }

        void PlayGame()
        {
            // constant integers to set 3 rows and 3 columns
            const int ROWS = 3;
            const int COLS = 3;
            // 2d array with 3 rows and 3 columns
            int[,] score = new int[ROWS, COLS];

            try
            {
                // create a random object
                Random random = new Random();

                // fill the array with random numbers 0 or 1 to represent O and X
                for (int row = 0; row < ROWS; row++)
                {
                    for (int col = 0; col < COLS; col++)
                    {
                        // randomly generate number between 1 and 2
                        score[row, col] = random.Next(0, 2);

                        // O wins
                        if (// score across the rows
                            score[0, 0] == 0 && score[0, 1] == 0 && score[0, 2] == 0 ||
                            score[1, 0] == 0 && score[1, 1] == 0 && score[1, 2] == 0 ||
                            score[2, 0] == 0 && score[2, 1] == 0 && score[2, 2] == 0 ||
                            // score down the columns
                            score[0, 0] == 0 && score[1, 0] == 0 && score[2, 0] == 0 ||
                            score[0, 1] == 0 && score[1, 1] == 0 && score[2, 1] == 0 ||
                            score[0, 2] == 0 && score[1, 2] == 0 && score[2, 2] == 0 ||
                            // score diagonally
                            score[0, 0] == 0 && score[1, 1] == 0 && score[2, 2] == 0 ||
                            score[0, 2] == 0 && score[1, 1] == 0 && score[2, 0] == 0)
                        {
                            outputLabel.Text = "O Wins!";
                        }
                        // X wins
                        else if (// score across the rows
                            score[0, 0] == 1 && score[0, 1] == 1 && score[0, 2] == 1 ||
                            score[1, 0] == 1 && score[1, 1] == 1 && score[1, 2] == 1 ||
                            score[2, 0] == 1 && score[2, 1] == 1 && score[2, 2] == 1 ||
                            // score down the columns
                            score[0, 0] == 1 && score[1, 0] == 1 && score[2, 0] == 1 ||
                            score[0, 1] == 1 && score[1, 1] == 1 && score[2, 1] == 1 ||
                            score[0, 2] == 1 && score[1, 2] == 1 && score[2, 2] == 1 ||
                            // score diagonally
                            score[0, 0] == 1 && score[1, 1] == 1 && score[2, 2] == 1 ||
                            score[0, 2] == 1 && score[1, 1] == 1 && score[2, 0] == 1)
                        {
                            outputLabel.Text = "X Wins!";
                        }
                        // draw
                        else
                        {
                            outputLabel.Text = "Draw!";
                        }
                    }
                }

                // output to labels either O or X based on 1 or 2 in the 2d array
                if (score[0, 0] == 0)
                {
                    zeroZero.Text = "O";
                }
                else
                {
                    zeroZero.Text = "X";
                }
                if (score[0, 1] == 0)
                {
                    zeroOne.Text = "O";
                }
                else
                {
                    zeroOne.Text = "X";
                }
                if (score[0, 2] == 0)
                {
                    zeroTwo.Text = "O";
                }
                else
                {
                    zeroTwo.Text = "X";
                }
                if (score[1, 0] == 0)
                {
                    oneZero.Text = "O";
                }
                else
                {
                    oneZero.Text = "X";
                }
                if (score[1, 1] == 0)
                {
                    oneOne.Text = "O";
                }
                else
                {
                    oneOne.Text = "X";
                }
                if (score[1, 2] == 0)
                {
                    oneTwo.Text = "O";
                }
                else
                {
                    oneTwo.Text = "X";
                }
                if (score[2, 0] == 0)
                {
                    twoZero.Text = "O";
                }
                else
                {
                    twoZero.Text = "X";
                }
                if (score[2, 1] == 0)
                {
                    twoOne.Text = "O";
                }
                else
                {
                    twoOne.Text = "X";
                }
                if (score[2, 2] == 0)
                {
                    twoTwo.Text = "O";
                }
                else
                {
                    twoTwo.Text = "X";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
