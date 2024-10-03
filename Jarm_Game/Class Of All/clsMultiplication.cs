using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarm_Game
{
    internal class clsMultiplication : clsTwoPlayers
    {
        public int ope1;
        public int ope2;
        Random random = new Random();

        // Random question number
        public clsMultiplication(string P1, string P2) : base(P1, P2)
        {
            ope1 = random.Next(1, 11);
            ope2 = random.Next(1, 11);
        }

        // Formula of the given question
        public int Answer()
        {
            return ope1 * ope2;
        }
    }
}
