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

        private string _menuOutput = "\n\n\n\n\n\t\t\t\t\t\tWelcome to WineShop!\n\n" +
                "\t\t\t\t\t\tPlease select an option: \n\n\n\n" +
                "\t\t\t\t\t\t1) (L) Load the WineList\n" +
                "\t\t\t\t\t\t2) (P) Print the WineList\n" +
                "\t\t\t\t\t\t3) (S) Search the WineList\n" +
                "\t\t\t\t\t\t4) (A) Add a wine to the WineList\n\n" +
                "\t\t\t\t\t\tPress Q to quit\n\n";
        private string _selectionOutput = "";
        private string _spaces = "\t\t\t\t\t\t";
        private string _exitMessage = "\n\n\t\t\t\t\t\tExiting program.";

        private bool _loadList = false;
        private bool _quitState = false;

        // properties
        public string MenuOutput { get; }
        public string Spaces { get; }
        public string SelectionOutput { get; set; }
        public string ExitMessage { get; set; }


        public bool LoadList { get; set; }
        public bool QuitState { get; set; }

        // constructor
        private UserInterface()
        {
            DrawMenu();
            MenuOutput = _menuOutput;
            ExitMessage = _exitMessage;
            Spaces = _spaces;            
        }

        // methods
        public static UserInterface GetInstance()                   
        {
            if (_instance == null) _instance = new UserInterface();            
            return _instance;
        }

        public String DrawMenu()
        {
            _quitState = false;            
            return _menuOutput;
        }

        public String GetChoice(String choice)
        {
            choice = choice.ToUpper();
            switch (choice)
            {
                case "L":
                    if (!_loadList)
                    {
                        _selectionOutput = "\n\n\t\t\t\t\t\tLoading WineList.";
                        _loadList = true;
                    }
                    else _selectionOutput = "\n\n\t\t\t\t\t\tWineList is already loaded.\n" +
                            "\t\t\t\t\t\tPlease select another option.";
                    break;
                case "P":
                    _selectionOutput = "\n\n\t\t\t\t\t\tThe WineList contains the following wines.";
                    break;
                case "S":
                    _selectionOutput = "\n\n\t\t\t\t\t\tSearch WineList.";
                    break;
                case "A":
                    _selectionOutput = "\n\n\t\t\t\t\t\tAdd a wine to the WintList.";
                    break;                
                case "Q":
                    _selectionOutput = _exitMessage;
                    _quitState = true;
                    break;
                default:
                    _selectionOutput = "\n\n\t\t\t\t\t\tThat is not a valid option.\n" +
                        "\t\t\t\t\t\tPlease select an option from the list above.";
                    break;
            }
            SelectionOutput = _selectionOutput;
            LoadList = _loadList;
            QuitState = _quitState;
            return _selectionOutput;
        }
    }
}
