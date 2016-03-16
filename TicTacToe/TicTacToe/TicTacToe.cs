using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public frmTicTacToe()
        {
            InitializeComponent();
        }
        #endregion

        #region Attributes
        /// <summary>
        /// Initializes a new TicTacToeGame
        /// </summary>
        private clsTicTacToe TicTacToeGame = new clsTicTacToe();
        #endregion

        #region Methods
        /// <summary>
        /// Tells us if the game has been started
        /// </summary>
        private bool bGameHasStarted = false;
        /// <summary>
        /// Clears all the labels for the tic tac toe board for a new game
        /// </summary>
        public void ClearLabels()
        {
            // Check to see if game has not started
            if (bGameHasStarted == false)
            {
                GridEnable();
                btn00.Text = "";
                btn01.Text = "";
                btn02.Text = "";
                btn10.Text = "";
                btn11.Text = "";
                btn12.Text = "";
                btn20.Text = "";
                btn21.Text = "";
                btn22.Text = "";
            }
        }
        /// <summary>
        /// Resets the colors of the labels back to default
        /// </summary>
        public void ResetColors()
        {
            // Check to see if game has not started
            if (bGameHasStarted == false)
            {
                btn00.BackColor = Color.Gainsboro;
                btn01.BackColor = Color.Gainsboro;
                btn02.BackColor = Color.Gainsboro;
                btn10.BackColor = Color.Gainsboro;
                btn11.BackColor = Color.Gainsboro;
                btn12.BackColor = Color.Gainsboro;
                btn20.BackColor = Color.Gainsboro;
                btn21.BackColor = Color.Gainsboro;
                btn22.BackColor = Color.Gainsboro;
            }

        }
        /// <summary>
        /// Depending on if the game has started or not, this method enables or disables the tic tac toe grid
        /// </summary>
        public void GridEnable()
        {
            // If game has started, enable all tic tac toe fields
            if (bGameHasStarted)
            {
                btn00.Enabled = true;
                btn01.Enabled = true;
                btn02.Enabled = true;
                btn10.Enabled = true;
                btn11.Enabled = true;
                btn12.Enabled = true;
                btn20.Enabled = true;
                btn21.Enabled = true;
                btn22.Enabled = true;
            }
            // If game has not started, disable all tic tac toe fields
            else
            {
                btn00.Enabled = false;
                btn01.Enabled = false;
                btn02.Enabled = false;
                btn10.Enabled = false;
                btn11.Enabled = false;
                btn12.Enabled = false;
                btn20.Enabled = false;
                btn21.Enabled = false;
                btn22.Enabled = false;
            }
        }
        /// <summary>
        /// Method performed on any tic tac toe field button click.  Calls LoadBoard method and sends in the button that was clicked.  Also disables the clicked button
        /// </summary>
        /// <param name="sender">Button clicked</param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            // Create a temporary button to know which button was clicked
            Button tempButton = (Button)sender;
            LoadBoard(tempButton);
            // Disable clicked button
            tempButton.Enabled = false;
            //TicTacToeGame.IsWinningMove(tempButton.Name);
        }
        /// <summary>
        /// Method to start the game.  Calls functions to set up game, then sets the bGameHasStarted variable to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Game_Click(object sender, EventArgs e)
        {
            // Temporary button to know which button was clicked
            Button tempButton = (Button)sender;
            // If game has not started, reset label colors, clear labels, and reset the board, then set bGameHasStarted to true and enable Tic tac toe grid
            if (bGameHasStarted == false)
            {
                ResetColors();
                ClearLabels();
                LoadBoard(tempButton);
                GridEnable();
            }
        }
        /// <summary>
        /// Resets or Loads the board depending on which button is clicked
        /// </summary>
        /// <param name="clickedButton">Button Clicked</param>
        private void LoadBoard(Button clickedButton)
        {
            // If the clicked button was Start Game, reset the board and disable the start game button
            if (clickedButton.Text == "Start Game")
            {
                TicTacToeGame.ResetBoard();
                bGameHasStarted = true;
                btnStartGame.Enabled = false;
            }
            // If the clicked button was a tic tac toe grid button
            else
            {
                // Set label to the current mark (X or O)
                clickedButton.Text = TicTacToeGame.CurrentMark;
                // If the button clicked is a winning move, end the game, disable the grid, display the scores, highlight the win, and enable the start game button
                if (TicTacToeGame.IsWinningMove(clickedButton.Name))
                {
                    bGameHasStarted = false;
                    GridEnable();
                    DisplayScores();
                    HighlightWin();
                    btnStartGame.Enabled = true;
                }
            }
            DisplayStatus();
        }
        /// <summary>
        /// Highlights the win based off eWinningMove
        /// </summary>
        private void HighlightWin()
        {
            switch (TicTacToeGame.eWinningMove)
            {
                // Row 1
                case clsTicTacToe.WinningMove.Row1:
                    {
                        btn00.BackColor = Color.Yellow;
                        btn01.BackColor = Color.Yellow;
                        btn02.BackColor = Color.Yellow;
                        break;
                    }
                // Row 2
                case clsTicTacToe.WinningMove.Row2:
                    {
                        btn10.BackColor = Color.Yellow;
                        btn11.BackColor = Color.Yellow;
                        btn12.BackColor = Color.Yellow;
                        break;
                    }
                // Row 3
                case clsTicTacToe.WinningMove.Row3:
                    {
                        btn20.BackColor = Color.Yellow;
                        btn21.BackColor = Color.Yellow;
                        btn22.BackColor = Color.Yellow;
                        break;
                    }
                // Column 1
                case clsTicTacToe.WinningMove.Col1:
                    {
                        btn00.BackColor = Color.Yellow;
                        btn10.BackColor = Color.Yellow;
                        btn20.BackColor = Color.Yellow;
                        break;
                    }
                // Column 2
                case clsTicTacToe.WinningMove.Col2:
                    {
                        btn01.BackColor = Color.Yellow;
                        btn11.BackColor = Color.Yellow;
                        btn21.BackColor = Color.Yellow;
                        break;
                    }
                // Column 3
                case clsTicTacToe.WinningMove.Col3:
                    {
                        btn02.BackColor = Color.Yellow;
                        btn12.BackColor = Color.Yellow;
                        btn22.BackColor = Color.Yellow;
                        break;
                    }
                // Diagonal 1
                case clsTicTacToe.WinningMove.Diag1:
                    {
                        btn00.BackColor = Color.Yellow;
                        btn11.BackColor = Color.Yellow;
                        btn22.BackColor = Color.Yellow;
                        break;
                    }
                // Diagonal 2
                case clsTicTacToe.WinningMove.Diag2:
                    {
                        btn02.BackColor = Color.Yellow;
                        btn11.BackColor = Color.Yellow;
                        btn20.BackColor = Color.Yellow;
                        break;
                    }
                // Tie
                case clsTicTacToe.WinningMove.None:
                    {
                        btn00.BackColor = Color.Tomato;
                        btn01.BackColor = Color.Tomato;
                        btn02.BackColor = Color.Tomato;
                        btn10.BackColor = Color.Tomato;
                        btn11.BackColor = Color.Tomato;
                        btn12.BackColor = Color.Tomato;
                        btn20.BackColor = Color.Tomato;
                        btn21.BackColor = Color.Tomato;
                        btn22.BackColor = Color.Tomato;
                        break;
                    }
            }
        }
        /// <summary>
        /// Displays the scores of each player, and the ties for the game
        /// </summary>
        private void DisplayScores()
        {
            lblPlayerXScore.Text = Convert.ToString(TicTacToeGame.PlayerXWins);
            lblPlayerOScore.Text = Convert.ToString(TicTacToeGame.PlayerOWins);
            lblTiesScore.Text = Convert.ToString(TicTacToeGame.Ties);
        }
        /// <summary>
        /// Displays the status of each turn and win in the game
        /// </summary>
        private void DisplayStatus()
        {
            // If game has started and the current mark is X
            if (bGameHasStarted == true && TicTacToeGame.CurrentMark == "X")
            {
                lblGameStatus.Text = "Player X, click a space";
            }
            // If the game has started and the current mark is O
            else if (bGameHasStarted == true && TicTacToeGame.CurrentMark == "O")
            {
                lblGameStatus.Text = "Player O, click a space";
            }
            // If the game has ended and the current mark is X, and it is not a tie
            else if (bGameHasStarted == false && TicTacToeGame.CurrentMark == "X" && TicTacToeGame.eWinningMove != clsTicTacToe.WinningMove.None)
            {
                lblGameStatus.Text = "Player X Wins!";
            }
            // If the game has ended and the current mark is O, and it is not a tie
            else if (bGameHasStarted == false && TicTacToeGame.CurrentMark == "O" && TicTacToeGame.eWinningMove != clsTicTacToe.WinningMove.None)
            {
                lblGameStatus.Text = "Player O Wins!";
            }
            // If the game has ended and it is a tie
            else if (bGameHasStarted == false && TicTacToeGame.eWinningMove == clsTicTacToe.WinningMove.None)
            {
                lblGameStatus.Text = "It was a tie!";
            }
        }
        #endregion
    }

    public class clsTicTacToe
    {
        #region Constructors
        /// <summary>
        /// Default contructor
        /// Initializes a new board array, sets the currentMark, eWinningMove, iPlayerXWins, iPlayerOWins and iTies values
        /// </summary>
        public clsTicTacToe()
        {
            saBoard = new string[3, 3];
            sCurrentMark = "X";
            eWinningMove = WinningMove.None;
            iPlayerXWins = 0;
            iPlayerOWins = 0;
            iTies = 0;
        }
        #endregion

        #region Attributes
        /// <summary>
        /// An array of strings representing the TicTacToe board
        /// </summary>
        private string[,] saBoard;
        /// <summary>
        /// An integer score for player X
        /// </summary>
        private int iPlayerXWins;
        /// <summary>
        /// An integer score for player O
        /// </summary>
        private int iPlayerOWins;
        /// <summary>
        /// An integer score for game ties
        /// </summary>
        private int iTies;
        /// <summary>
        /// A string for the current mark of each turn
        /// </summary>
        private string sCurrentMark;
        /// <summary>
        /// Type of WinningMove
        /// </summary>
        public WinningMove eWinningMove;
        /// <summary>
        /// enum for types of wins ex: Diagonal
        /// </summary>
        public enum WinningMove
        {
            Row1,
            Row2,
            Row3,
            Col1,
            Col2,
            Col3,
            Diag1,
            Diag2,
            None
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Public property to get iPlayerXWins
        /// </summary>
        public int PlayerXWins
        {
            get { return iPlayerXWins; }
        }
        /// <summary>
        /// Public property to get iPlayerOWins
        /// </summary>
        public int PlayerOWins
        {
            get { return iPlayerOWins; }
        }
        /// <summary>
        /// Public property to get iTies
        /// </summary>
        public int Ties
        {
            get { return iTies; }
        }
        /// <summary>
        /// Public property to get sCurrentMark
        /// </summary>
        public string CurrentMark
        {
            get { return sCurrentMark; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Alternates the current mark being place on the board, depending on whose turn it is
        /// </summary>
        private void ChangeCurrentMark()
        {
            if (sCurrentMark == "X")
            {
                sCurrentMark = "O";
            }
            else
            {
                sCurrentMark = "X";
            }
        }
        /// <summary>
        /// Resets the game board back to being full of empty strings
        /// </summary>
        public void ResetBoard()
        {
            // Row
            for (int i = 0; i < saBoard.GetLength(0); i++)
            {
                // Column
                for (int j = 0; j < saBoard.GetLength(1); j++)
                {
                    saBoard[i, j] = "";
                }
            }
            eWinningMove = WinningMove.None;
        }
        /// <summary>
        /// Checks to see if the current move wins or ends the game
        /// </summary>
        /// <param name="sender">Button clicked in Tic Tac Toe</param>
        /// <returns>Returns true if the game is won or tied, false if there are more turns</returns>
        public bool IsWinningMove(string sender)
        {
            // Temporary string for separating the digits from the button name
            string temp = (String.Join("", sender.Where(Char.IsDigit)));
            // Sets the array at the position determined by the button sent to sCurrentMark
            saBoard[Convert.ToInt32(temp.Substring(0, 1)), Convert.ToInt32(temp.Substring(1, 1))] = sCurrentMark;
            // If there is a win Horizontally, Vertically, or Diagonally increment player score and return true
            if (IsHorizontal() || IsVertical() || IsDiag())
            {
                // If currentMark is X, increment player X's score
                if (sCurrentMark == "X")
                {
                    iPlayerXWins++;
                }
                // If currentMark is O, increment player O's score
                else if (sCurrentMark == "O")
                {
                    iPlayerOWins++;
                }
                return true;
            }
            // If there isn't a win yet, check for a tie
            else
            {
                // If there is a tie, increment ties score and return true
                if (IsTie())
                {
                    iTies++;
                    return true;
                }
                // If there is no tie and no win, change the current mark (change turns)
                else
                {
                    ChangeCurrentMark();
                    return false;
                }
            }
        }
        /// <summary>
        /// Checks to see if all the spaces in the board are filled
        /// </summary>
        /// <returns>Returns true if the board doesn't have any empty space</returns>
        public bool IsTie()
        {
            //Finds out if all spots are taken
            foreach (string mark in saBoard)
            {
                // If spot is empty, return false
                if (mark == "")
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Checks each row of the board to see if there is a horizontal win
        /// </summary>
        /// <returns>Returns true if there is a horizontal win, false if not</returns>
        private bool IsHorizontal()
        {
            // for each row
            for (int i = 0; i < 3; i++)
            {
                // If all marks in row are the same as the current mark, set eWinningMove to corresponding row and return true
                if (saBoard[i, 0] == sCurrentMark && saBoard[i, 1] == sCurrentMark && saBoard[i, 2] == sCurrentMark)
                {
                    // Uses integer value of WinningMove to determine which row is set as eWinningMove (values 0-2)
                    eWinningMove = (WinningMove)i;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Checks each column of the board to see if there is a vertical win
        /// </summary>
        /// <returns>Returns true if there is a vertical win, false if not</returns>
        private bool IsVertical()
        {
            // For each column
            for (int i = 0; i < 3; i++)
            {
                // If all marks in column are the same as the current mark, set eWinningMove to corresponding column and return true
                if (saBoard[0, i] == sCurrentMark && saBoard[1, i] == sCurrentMark && saBoard[2, i] == sCurrentMark)
                {
                    // Uses integer value of WinningMove to determine which row is set as eWinningMove (values 3-5)
                    eWinningMove = (WinningMove)(i + 3);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Checks each diagonal of the board to see if there is a diagonal win
        /// </summary>
        /// <returns>Returns true if there is a diagonal win, false if not</returns>
        private bool IsDiag()
        {
            // If all marks on Diag1 (0-0,1-1,2-2) are the same as the current mark, set eWinningMove to Diag1
            if (saBoard[0, 0] == sCurrentMark && saBoard[1, 1] == sCurrentMark && saBoard[2, 2] == sCurrentMark)
            {
                eWinningMove = WinningMove.Diag1;
                return true;
            }
            // If all marks on Diag2 (0-2,1-1,2-0) are the same as the current mark, set eWinningMove to Diag2
            else if (saBoard[0, 2] == sCurrentMark && saBoard[1, 1] == sCurrentMark && saBoard[2, 0] == sCurrentMark)
            {
                eWinningMove = WinningMove.Diag2;
                return true;
            }
            return false;
        }
        #endregion
    }
}
