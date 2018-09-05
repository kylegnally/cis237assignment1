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
        static CSVProcessor getDrunk;
        public static WineItemCollection wineCellar;
        
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

            else if (aMenu.LoadList)
            {
                getDrunk = CSVProcessor.GetInstance();
                ShowOutput();
                Pause();
            }

            else if (aMenu.PrintList)
            {
                wineCellar = new WineItemCollection();
                wineCellar.GetPrintString();
                Pause();
            }

            else if (aMenu.SearchList)
            {
                Console.Write(aMenu.SelectionOutput);
                string wineId = Console.ReadLine();
                wineCellar.Search(wineId);
                Console.Write(wineCellar.OneWine);
                Pause();
            }

            else
            {
                ShowOutput();                
            }
        }

        static void ShowOutput()
        {
            Console.Write(aMenu.SelectionOutput);
            Pause();            
        }

        static void Pause()
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            ShowMenu();
        }
    }
}
