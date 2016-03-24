using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5___Math_Game.Classes
{
    class clsPlayerObjectManager
    {
        public List<clsPlayer> lstPlayers { get; set; }
        
        public clsPlayerObjectManager()
        {
            lstPlayers = new List<clsPlayer>();
        }

        public void AddNewPlayer(string FirstName, string LastName, int Age, string Email)
        {
            lstPlayers.Add(new clsPlayer { sFName = FirstName, sLName = LastName, iAge = Age, sEmail = Email });
        }
    }
}
