using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarm_Game
{
    internal class clsTwoPlayers
    {
        public string playername;
        public string p1;
        public string p2;
        public int pl;
        public string Name;
        public string Nickname;
        public string Age;
        public string Gender;
        public string Status;
        public string Gmail;

        //Encapsulation of the data input
        public clsTwoPlayers(string name, string nickname, string age, string gender, string status, string gmail)
        {
            Name = name;
            Nickname = nickname;
            Age = age;
            Gender = gender;
            Status = status;
            Gmail = gmail;
        }
        // constractor parametarized on the playername
        public clsTwoPlayers(string Playername) 
        {
            playername = Playername;
        }
        public clsTwoPlayers(string P1, string P2)
        {
            p1 = P1;
            p2 = P2;
            pl = 0;
        }

        public string Player1Loses()
        {
            return $"Game Result: {p1} loses, {p2} wins!";
        }

        public string Player2Loses()
        {
            return $"Game Result: {p2} loses, {p1} wins!";
        }

        public string Player1Turn()
        {
            return $"{p1}'s turn";
        }

        public string Player2Turn()
        {
            return $"{p2}'s turn";
        }
    }
}
