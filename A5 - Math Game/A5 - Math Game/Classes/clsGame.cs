using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A5___Math_Game
{
    class clsGame
    {
        private string type;

        private Random rand1;
        private int answer;
        clsScores playerScore;

        public clsGame(string gameType)
        {
            switch (gameType)
            {
                case "Addition":
                    type = "Addition";
                    break;
                case "Subtraction":
                    type = "Subtraction";
                    break;
                case "Multiplication":
                    type = "Multiplication";
                    break;
                case "Division":
                    type = "Division";
                    break;
            }
            playerScore = new clsScores(MainMenu.Players[MainMenu.Players.Count -1].sFName + MainMenu.Players[MainMenu.Players.Count - 1].sLName); 
            rand1 = new Random(25);
        }

        //public string gameType
        //{
        //    get { return type; }
        //    set { type = value; }
        //}

        public string newQuestion()
        {
            Type t = this.GetType();
            MethodInfo method = t.GetMethod(type);
            string result = (string)method.Invoke(this, null);
            playerScore.NumQuestions++;
            return result;
        }

       public string Addition()
        {
            int num1 = rand1.Next(0, 20);
            int num2 = rand1.Next(0, 20);
            answer = num1 + num2;
            return num1 + " + " + num2 + " = ";
        }

        public string Subtraction()
        {
            int num1 = rand1.Next(0, 20);
            int num2 = rand1.Next(0, 20);
            if (num1 > num2)
            {
                answer = num1 - num2;
                return num1 + " - " + num2 + " = ";
            }
            else
            {
                answer = num2 - num1;
                return num2 + " - " + num1 + " = ";
            }
            
        }

        public string Multiplication()
        {
            int num1 = rand1.Next(0, 10);
            int num2 = rand1.Next(0, 10);
            answer = num1 * num2;
            return num1 + " X " + num2 + " = ";
        }

        public string Division()
        {
            int num1 = rand1.Next(0, 20);
            int num2 = rand1.Next(0, 20);
            while (num2!= 0 && num1 % num2 != 0)
            {
                num1 = rand1.Next(0, 20);
                num2 = rand1.Next(0, 20);
            }
            answer = num1 / num2;
            return num1 + " / " + num2;
        }

        public bool CheckAnswer(int userAnswer)
        {
            if (userAnswer == answer)
            {
                playerScore.NumCorrect++;
                return true;
            }
            else
            {
                return false;
            }
        }


        public void EndGame()
        {
            MainMenu.Scores.Add(playerScore);
        }
    }
}
