using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A5___Math_Game
{
    public class clsGame
    {
        #region Attributes
        /// <summary>
        /// Game Type
        /// </summary>
        private string type;
        /// <summary>
        /// Time that the timer starts
        /// </summary>
        public DateTime TimerStart;
        /// <summary>
        /// Random number generator
        /// </summary>
        private Random rand;
        /// <summary>
        /// Player's answer
        /// </summary>
        private int answer;
        /// <summary>
        /// Questions in a Game
        /// </summary>
        private const int totalQuestions = 10;
        #endregion

        #region Properties
        /// <summary>
        /// Property to get totalQuestions
        /// </summary>
        public int TotalQuestions
        {
            get { return totalQuestions; }
        }
        /// <summary>
        /// Property to get and set the game type
        /// </summary>
        public string gameType
        {
            get { return type; }
            set { type = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor, initializes random number generator seed
        /// </summary>
        public clsGame()
        {
            // Uses new unique ID's hashcodes as the seed
            // Makes it so the number is different every time the game is started
            rand = new Random(Guid.NewGuid().GetHashCode());
        }
        #endregion

        #region Methods
        /// <summary>
        /// Calls the functions based on the players game choice.
        /// Helper for generating new questions.
        /// Source: http://stackoverflow.com/questions/540066/calling-a-function-from-a-string-in-c-sharp
        /// </summary>
        /// <returns>The equation for the player to answer</returns>
        public string newQuestion()
        {
            Type t = this.GetType();
            MethodInfo method = t.GetMethod(type);
            string result = (string)method.Invoke(this, null);
            // Increment number of questions asked
            MainMenu.Scores[MainMenu.Scores.Count - 1].NumQuestions++;
            // Returns the equation generated
            return result;
        }
        /// <summary>
        /// Generates equations for the addition game type
        /// </summary>
        /// <returns>The equation for the player to answer</returns>
        public string Addition()
        {
            // Creates 2 random numbers
            int num1 = rand.Next(0, 20);
            int num2 = rand.Next(0, 20);
            // Store the answer for checking
            answer = num1 + num2;
            // Set Start time
            TimerStart = DateTime.Now;
            // Return equation
            return num1 + " + " + num2 + " = ";
        }
        /// <summary>
        /// Generates equations for the subtraction game type
        /// </summary>
        /// <returns>The equation for the player to answer</returns>
        public string Subtraction()
        {
            // Generates 2 random numbers
            int num1 = rand.Next(0, 20);
            int num2 = rand.Next(0, 20);
            // Set start time
            TimerStart = DateTime.Now;
            // Puts number in order (no negative answers
            if (num1 > num2)
            {
                // Store Answer
                answer = num1 - num2;
                // Return equation
                return num1 + " - " + num2 + " = ";
            }
            else
            {
                // Store answer
                answer = num2 - num1;
                // Return equation
                return num2 + " - " + num1 + " = ";
            }
            
        }
        /// <summary>
        /// Generates equations for the multiplication game type
        /// </summary>
        /// <returns>The equation for the player to answer</returns>
        public string Multiplication()
        {
            // Creates 2 random numbers
            int num1 = rand.Next(0, 10);
            int num2 = rand.Next(0, 10);
            // Stores the answer
            answer = num1 * num2;
            // Sets start time
            TimerStart = DateTime.Now;
            // Returns Equation
            return num1 + " X " + num2 + " = ";
        }
        /// <summary>
        /// Generates equations for the division game type
        /// </summary>
        /// <returns>The equation for the player to answer</returns>
        public string Division()
        {
            // Creates 2 random numbers
            int num1 = rand.Next(0, 40);
            int num2 = rand.Next(0, 40);
            // Makes sure the bottom number is not a zero, and that the number divides evenly
            while (num2 == 0 || num1 % num2 != 0 || num1 == 0 || num1 == num2 || num2 == 1)
            {
                // Generates new random numbers if criteria is not met
                num1 = rand.Next(0, 40);
                num2 = rand.Next(0, 40);
            }
            // Stores answer
            answer = num1 / num2;
            // Sets start time
            TimerStart = DateTime.Now;
            // Returns equation
            return num1 + " / " + num2;
        }
        /// <summary>
        /// Checks the player's answer
        /// </summary>
        /// <param name="userAnswer">Player's answer</param>
        /// <returns>True is correct, false is incorrect</returns>
        public bool CheckAnswer(int userAnswer)
        {
            // Gets time taken to answer question and adds it to the score total time taken
            MainMenu.Scores[MainMenu.Scores.Count - 1].TimeTaken += GetTime();
            // If correct
            if (userAnswer == answer)
            {
                // Increments the number answered correctly
                MainMenu.Scores[MainMenu.Scores.Count - 1].NumCorrect++;
                return true;
            }
            // If incorrect
            else
            {
                // Increments the number answered incorrectly
                MainMenu.Scores[MainMenu.Scores.Count - 1].NumWrong++;
                return false;
            }
        }
        /// <summary>
        /// Calculates the time between when the timer started, and now
        /// </summary>
        /// <returns>Time taken</returns>
        public TimeSpan GetTime()
        {
            return DateTime.Now - TimerStart;
        }
        #endregion
    }
}
