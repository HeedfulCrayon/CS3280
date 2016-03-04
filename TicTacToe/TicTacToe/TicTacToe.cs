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
            GridEnable();
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            lblGameStatus.Text = "";
            btnStartGame.Text = "Start Game";
        }
        public void ResetColors()
        {
            btn1.BackColor = Color.Gainsboro;
            btn2.BackColor = Color.Gainsboro;
            btn3.BackColor = Color.Gainsboro;
            btn4.BackColor = Color.Gainsboro;
            btn5.BackColor = Color.Gainsboro;
            btn6.BackColor = Color.Gainsboro;
            btn7.BackColor = Color.Gainsboro;
            btn8.BackColor = Color.Gainsboro;
            btn9.BackColor = Color.Gainsboro;
            btnStartGame.BackColor = Color.Moccasin;
        }
        public void GridEnable()
        {
            if (bGameHasStarted)
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
            }
            else
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
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
            if (bGameHasStarted == false)
            {
                bGameHasStarted = true;
                GridEnable();
            }
        }

        private void LoadBoard(Button clickedButton)
        {
            clickedButton.Text = TicTacToeGame.CurrentMark;
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
        }

        #region Public Properties
        private string[,] saBoard;
        private int iPlayer1Wins;
        private int iPlayer2Wins;
        private int iTies;
        private string sCurrentMark;
        private WinningMove eWinningMove;
        public string CurrentMark
        {
            get { return sCurrentMark; }
        }
        #endregion

        private enum WinningMove
        {
            Row1,
            Row2,
            Row3,
            Col1,
            Col2,
            Col3,
            Diag1,
            Diag2
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

        public bool IsWinningMove(string sender)
        {
            //logic to determine winning move
            if (true)
            {
                eWinningMove = WinningMove.Row2;
                return true;
            }
            ;
            return false;
        }
        public bool IsTie()
        {
            //Finds out if all spots are taken
            return false;
        }
        private bool IsHorizontal()
        {
            //Helper for IsWinningMove()
            return false;
        }
        private bool IsVertical()
        {
            //Helper for IsWinningMove()
            return false;
        }
        private bool IsDiag()
        {
            //Helper for IsWinningMove()
            return false;
        }
    }
}
