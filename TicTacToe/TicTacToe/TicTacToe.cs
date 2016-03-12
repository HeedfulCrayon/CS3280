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
        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private clsTicTacToe TicTacToeGame = new clsTicTacToe();
        private bool bGameHasStarted = false;  //True when start game button is clicked

        public void ClearLabels()
        {
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
                lblGameStatus.Text = "";
                btnStartGame.Text = "Start Game";
            }

        }
        public void ResetColors()
        {
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
                btnStartGame.BackColor = Color.Moccasin;
            }

        }
        public void GridEnable()
        {
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

        private void btn_Click(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            LoadBoard(tempButton);
            tempButton.Enabled = false;
            //TicTacToeGame.IsWinningMove(tempButton.Name);
        }

        private void Start_Game_Click(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (bGameHasStarted == false)
            {
                ResetColors();
                ClearLabels();
                LoadBoard(tempButton);
                bGameHasStarted = true;
                GridEnable();
            }
        }

        private void LoadBoard(Button clickedButton)
        {
            if (clickedButton.Text == "Start Game")
            {
                TicTacToeGame.ResetBoard();
            }
            else
            {
                clickedButton.Text = TicTacToeGame.CurrentMark;
                if (TicTacToeGame.IsWinningMove(clickedButton.Name))
                {
                    bGameHasStarted = false;
                    GridEnable();
                    DisplayScores();
                    HighlightWin();
                }
            }
        }

        private void HighlightWin()
        {
            switch (TicTacToeGame.eWinningMove)
            {
                case clsTicTacToe.WinningMove.Row1:
                    {
                        btn00.BackColor = Color.Yellow;
                        btn01.BackColor = Color.Yellow;
                        btn02.BackColor = Color.Yellow;
                        break;
                    }
                case clsTicTacToe.WinningMove.Row2:
                    {
                        btn10.BackColor = Color.Yellow;
                        btn11.BackColor = Color.Yellow;
                        btn12.BackColor = Color.Yellow;
                        break;
                    }
                case clsTicTacToe.WinningMove.Row3:
                    {
                        btn20.BackColor = Color.Yellow;
                        btn21.BackColor = Color.Yellow;
                        btn22.BackColor = Color.Yellow;
                        break;
                    }
                case clsTicTacToe.WinningMove.Col1:
                    {
                        btn00.BackColor = Color.Yellow;
                        btn10.BackColor = Color.Yellow;
                        btn20.BackColor = Color.Yellow;
                        break;
                    }
                case clsTicTacToe.WinningMove.Col2:
                    {
                        btn01.BackColor = Color.Yellow;
                        btn11.BackColor = Color.Yellow;
                        btn21.BackColor = Color.Yellow;
                        break;
                    }
                case clsTicTacToe.WinningMove.Col3:
                    {
                        btn02.BackColor = Color.Yellow;
                        btn12.BackColor = Color.Yellow;
                        btn22.BackColor = Color.Yellow;
                        break;
                    }
                case clsTicTacToe.WinningMove.Diag1:
                    {
                        btn00.BackColor = Color.Yellow;
                        btn11.BackColor = Color.Yellow;
                        btn22.BackColor = Color.Yellow;
                        break;
                    }
                case clsTicTacToe.WinningMove.Diag2:
                    {
                        btn02.BackColor = Color.Yellow;
                        btn11.BackColor = Color.Yellow;
                        btn20.BackColor = Color.Yellow;
                        break;
                    }
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

        private void DisplayScores()
        {
            lblPlayerXScore.Text = Convert.ToString(TicTacToeGame.PlayerXWins);
            lblPlayerOScore.Text = Convert.ToString(TicTacToeGame.PlayerOWins);
            lblTiesScore.Text = Convert.ToString(TicTacToeGame.Ties);
        }
    }

    ///// <summary>
    ///// 
    ///// </summary>
    //public class UI
    //{

    //}
    ///// <summary>
    ///// 
    ///// </summary>
    //public class AI
    //{

    //}
    ///// <summary>
    ///// 
    ///// </summary>
    //public class Game
    //{        

    //}
    ///// <summary>
    ///// 
    ///// </summary>
    //public class Person
    //{

    //}
    public class clsTicTacToe
    {
        public clsTicTacToe()
        {
            saBoard = new string[3, 3];
            sCurrentMark = "X";
            eWinningMove = WinningMove.None;
            iPlayerXWins = 0;
            iPlayerOWins = 0;
            iTies = 0;
        }

        #region Public Properties
        private string[,] saBoard;
        private int iPlayerXWins;
        private int iPlayerOWins;
        private int iTies;
        private string sCurrentMark;
        public WinningMove eWinningMove;
        public int PlayerXWins
        {
            get { return iPlayerXWins; }
        }
        public int PlayerOWins
        {
            get { return iPlayerOWins; }
        }
        public int Ties
        {
            get { return iTies; }
        }
        public string CurrentMark
        {
            get { return sCurrentMark; }
        }
        #endregion

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

        public void ResetBoard()
        {
            for (int i = 0; i < saBoard.GetLength(0); i++)
            {
                for (int j = 0; j < saBoard.GetLength(1); j++)
                {
                    saBoard[i, j] = "";
                }
            }
            eWinningMove = WinningMove.None;
        }

        public bool IsWinningMove(string sender)
        {
            string temp = (String.Join("", sender.Where(Char.IsDigit)));
            saBoard[Convert.ToInt32(temp.Substring(0, 1)), Convert.ToInt32(temp.Substring(1, 1))] = sCurrentMark;
            //IsHorizontal();
            //IsVertical();
            //IsDiag();
            //saBoard[temp[0], temp[1]] = sCurrentMark;
            //logic to determine winning move
            if (IsHorizontal() || IsVertical() || IsDiag())
            {
                if (sCurrentMark == "X")
                {
                    iPlayerXWins++;
                }
                else if (sCurrentMark == "O")
                {
                    iPlayerOWins++;
                }
                return true;
            }
            else
            {
                if (IsTie())
                {
                    iTies++;
                    return true;
                }
                else
                {
                    ChangeCurrentMark();
                    return false;
                }
            }
        }
        public bool IsTie()
        {
            //Finds out if all spots are taken
            foreach (string mark in saBoard)
            {
                if (mark == "")
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsHorizontal()
        {
            //Helper for IsWinningMove()
            for (int i = 0; i < 3; i++)
            {
                if (saBoard[i, 0] == sCurrentMark && saBoard[i, 1] == sCurrentMark && saBoard[i, 2] == sCurrentMark)
                {
                    eWinningMove = (WinningMove)i;
                    return true;
                }
            }
            return false;
        }
        private bool IsVertical()
        {
            //Helper for IsWinningMove()
            for (int i = 0; i < 3; i++)
            {
                if (saBoard[0, i] == sCurrentMark && saBoard[1, i] == sCurrentMark && saBoard[2, i] == sCurrentMark)
                {
                    eWinningMove = (WinningMove)(i + 3);
                    return true;
                }
            }
            return false;
        }
        private bool IsDiag()
        {
            //Helper for IsWinningMove()
            if (saBoard[0, 0] == sCurrentMark && saBoard[1, 1] == sCurrentMark && saBoard[2, 2] == sCurrentMark)
            {
                eWinningMove = WinningMove.Diag1;
                return true;
            }
            else if (saBoard[0, 2] == sCurrentMark && saBoard[1, 1] == sCurrentMark && saBoard[2, 0] == sCurrentMark)
            {
                eWinningMove = WinningMove.Diag2;
                return true;
            }
            return false;
        }
    }
}
