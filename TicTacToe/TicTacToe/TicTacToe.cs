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
        private bool bGameHasStarted;  //True when start game button is clicked
        
        public void ClearLabels()
        {

        }
        public void ResetColors()
        {

        }

        private void Label_Click(object sender)
        {
            Button tempButton = (Button)sender;
            
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
        #region Public Properties
        private string[,] saBoard;
        private int iPlayer1Wins;
        private int iPlayer2Wins;
        private int iTies;
        private string sCurrentMark;
        private WinningMove eWinningMove;
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

        public bool IsWinningMove()
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
