using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5___Math_Game
{
    class clsPlayer
    {
        #region Attributes
        private string sFName;
        private string sLName;
        private int iAge;
        private string sEmail;
        #endregion

        #region Properties
        public string FName
        {
            get
            {
                return sFName;
            }
            set
            {
                sFName = value;
            }
        }
        public string LName
        {
            get
            {
                return sLName;
            }
            set
            {
                sLName = value;
            }
        }
        public int Age
        {
            get
            {
                return iAge;
            }
            set
            {
                iAge = value;
            }
        }
        public string Email
        {
            get
            {
                return sEmail;
            }
            set
            {
                sEmail = value;
            }
        }
        #endregion

        #region Constructors
        public clsPlayer(string sFName, string sLName, int iAge, string sEmail)
        {
            FName = sFName;
            LName = sLName;
            Age = iAge;
            Email = sEmail;
        }
        #endregion

        #region Methods
        public void editPlayer(string sFName, string sLName, int iAge, string sEmail)
        {
            FName = sFName;
            LName = sLName;
            Age = iAge;
            Email = sEmail;
        }
        #endregion

    }
}
