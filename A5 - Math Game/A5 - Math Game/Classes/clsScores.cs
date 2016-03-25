using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5___Math_Game
{
    public class clsScores
    {
        #region Attributes
        private int numQuestions;
        private string sName;
        private int numCorrect;
        private double gameScore;
        private TimeSpan time;
        #endregion

        public clsScores(string sName)
        {
            numQuestions = 0;
            numCorrect = 0;
            //start timer??
        }

        #region Properties\
        public int NumQuestions
        {
            get
            {
                return numQuestions;
            }
            set
            {
                numQuestions = value;
            }
        }

        public int NumCorrect
        {
            get
            {
                return numCorrect;
            }
            set
            {
                numCorrect = value;
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
