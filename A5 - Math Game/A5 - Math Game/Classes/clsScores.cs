using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5___Math_Game
{
    class clsScores
    {
        #region Attributes
        private const int numQuestions = 10; // Needs to be changed.  The user can end the game
        private string sName;
        private int numCorrect;
        private double gameScore;
        private TimeSpan time;
        #endregion

        #region Properties
        public int NumCorrect
        {
            get
            {
                return numCorrect;
            }
        }

        public TimeSpan TimeTaken
        {
            get { return time; }
            set { time = value; }
        }

        public double GameScore
        {
            get { return gameScore; }
        }
        #endregion

        // Example
        //public int iScore { get; set; }
        //public int iTime { get; set; }
        //public string Name { get; set; }
    }
}
