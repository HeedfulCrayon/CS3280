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
        private int numWrong;
        private TimeSpan time;
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sName">Players Full Name</param>
        public clsScores(string sName)
        {
            // Sets the name, and initializes everything else to zero
            this.sName = sName;
            numQuestions = 0;
            numCorrect = 0;
            numWrong = 0;
            time = DateTime.Now - DateTime.Now;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Player name associated with score
        /// </summary>
        public string Name
        {
            get { return sName; }
            set { sName = value; }
        }
        /// <summary>
        /// Number of Questions
        /// </summary>
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
        /// <summary>
        /// Number of questions answered correctly
        /// </summary>
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
        /// <summary>
        /// Number of questions answered incorrectly
        /// </summary>
        public int NumWrong
        {
            get { return numWrong; }
            set { numWrong = value; }
        }
        /// <summary>
        /// Time taken to answer all the questions
        /// </summary>
        public TimeSpan TimeTaken
        {
            get { return time; }
            set { time = value; }
        }
        #endregion
    }
}
