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
            string userSelection = Console.ReadLine();            
            aMenu.GetChoice(userSelection);
            if (aMenu.QuitState)
            {
                Console.WriteLine(aMenu.ExitMessage);
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }

            if (aMenu.LoadList)
            {

            }
            ShowOutput();
        }

        static void ShowOutput()
        {
            Console.Write(aMenu.SelectionOutput);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            ShowMenu();
        }
    }
}
