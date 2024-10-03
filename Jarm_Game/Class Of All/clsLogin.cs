using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarm_Game
{
    internal class clsLogin : clsRegister
    {
        public string hasUpperChar()
        {
            return "password should contain at least one Upper case letter.";

        }
        public string hasLowerChar()
        {
            return "password should contain at least one Lower case letter.";
        }
        public string hasNumbers()
        {
            return "password should contain at least one Numeric value.";

        }
        public string hasSymbols()
        {
            return "password should contain at least one Special case character.";

        }
        public string DisplayAboutUs()
        {
            return "\n" + "About Us!" + "\n\nThis project is an application that contains different games that the user can select " +
                "Arithmetic Solving, Car Dodge or Fighter jet. The Aim of this game is to improve strategic " +
                "thinking of how to overcome the struggle not only the children but also students, that's why I made this game. " +
                "Furthermore, users can complete fun quizzes and short games to earn skill points. " +
                "The Players/Users can apply the information they have learned to make the best decisions in challenging hypothetical situations." +
                "\n" + "\nCreated by: Jeorge Rey M. Antipaso";
        }
    }
}
