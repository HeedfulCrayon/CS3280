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
        private Random rand2;
        private int answer;

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
            rand1 = new Random(25);
            rand2 = new Random(75);
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
            return result;
        }

       public string Addition()
        {
            int num1 = rand1.Next(0, 100);
            int num2 = rand2.Next(0, 100);
            answer = num1 + num2;
            return num1 + " + " + num2 + " = ";
        }

        public string Subtraction()
        {
            return "Subtraction";
        }

        public string Multiplication()
        {
            return "Multiplication";
        }

        public string Division()
        {
            return "Division";
        }

        public bool checkAnswer(int userAnswer)
        {
            if (userAnswer == answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
