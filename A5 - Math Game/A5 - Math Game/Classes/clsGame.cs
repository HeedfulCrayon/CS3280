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
            return "Addition";
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

    }
}
