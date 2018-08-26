using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        // fields
        private static UserInterface _instance;
        private String _menuString = "";
        private String _menuChoice = "";
        private String _spaces = "\t\t\t\t\t\t";
        private bool _quitState = false;

        // properties
        public String MenuOutput { get; }
        public String UserChoice { get; set; }
        public String ExitMessage { get; set; } = "\n\n\t\t\t\t\t\tExiting program.";
        public String Spaces { get; set; }

        // constructor
        private UserInterface()
        {
            DrawMenu();
            MenuOutput = _menuString;
            UserChoice = _menuChoice;
            Spaces = _spaces;
            ExitMessage = ExitMessage;
        }

        // methods (singleton)
        public static UserInterface GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserInterface();
            }

            return _instance;
        }

        public String DrawMenu()
        {
            _menuString = "\n\n\n\n\n\t\t\t\t\t\tWelcome to WineShop!\n\n" +
                "\t\t\t\t\t\tPlease select an option: \n\n\n\n" +
                "\t\t\t\t\t\t1) (L) Load the WineList\n" +
                "\t\t\t\t\t\t2) (P) Print the WineList\n" +
                "\t\t\t\t\t\t3) (S) Search the WineList\n" +
                "\t\t\t\t\t\t4) (A) Add a wine to the WineList\n\n" +
                "\t\t\t\t\t\tPress Q to quit\n\n";

            return _menuString;
        }

        public String GetChoice(String choice)
        {
            choice = choice.ToUpper();
            _quitState = false;
            switch (choice)
            {
                case "L":
                    _menuChoice = "\n\n\t\t\t\t\t\tLoading WineList.";
                    break;
                case "P":
                    _menuChoice = "\n\n\t\t\t\t\t\tThe WineList contains the following wines.";
                    break;
                case "S":
                    _menuChoice = "\n\n\t\t\t\t\t\tSearch WineList.";
                    break;
                case "A":
                    _menuChoice = "\n\n\t\t\t\t\t\tAdd a wine to the WintList.";
                    break;                
                case "Q":
                    _quitState = true;
                    break;
                default:
                    _menuChoice = "\n\n\t\t\t\t\t\tThat is not a valid option.\n" +
                        "\t\t\t\t\t\tPlease select an option from the list above.";
                    break;
            }
            UserChoice = _menuChoice;
            return _menuChoice;
        }
    }
}
