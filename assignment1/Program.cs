using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static UserInterface aMenu = UserInterface.GetInstance();

        static void Main(string[] args)
        {
            ShowMenu();
        }

        static void ShowMenu()
        {
            aMenu.DrawMenu();
            Console.Write(aMenu.MenuOutput);
            GetInput();
        }

        static void GetInput()
        {
            Console.Write(aMenu.Spaces);
            String userSelection = Console.ReadLine();
            if (userSelection.ToUpper() == "Q")
            {
                Console.WriteLine(aMenu.ExitMessage);
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }
            aMenu.GetChoice(userSelection);
            ShowOutput();
        }

        static void ShowOutput()
        {
            Console.Write(aMenu.UserChoice);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            ShowMenu();
        }
    }
}
