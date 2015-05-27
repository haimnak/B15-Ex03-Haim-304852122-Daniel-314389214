using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex03.GarageManagementSystem.ConsoleUI
{
    public class View
    {
        public const string k_InvalidInputMsg = "Sorry, that's an invalid input";

        /*
         * Gets a valid menu selection
         */
        public static int MenuScan(string i_MsgToUser, int i_NumOfMenuOptions)
        {
            string userInput;
            int menuSelection;

            Console.WriteLine(i_MsgToUser);
            userInput = Console.ReadKey().KeyChar.ToString();
            Console.Clear();

            bool validInt = int.TryParse(userInput, out menuSelection);

            while (!validInt || !(menuSelection >= 1 && menuSelection <= i_NumOfMenuOptions))
            {
                PrintInvalidInput(k_InvalidInputMsg);
                Console.WriteLine(i_MsgToUser);
                userInput = Console.ReadKey().KeyChar.ToString();
                Console.Clear();
                validInt = int.TryParse(userInput, out menuSelection);
            }

            return menuSelection;
        }

        /*
         * Scan general input
         */
        public static float NumberScan(string i_ScanMsg)
        {
            string userInput;
            float userNumber;

            Console.WriteLine(i_ScanMsg);
            userInput = Console.ReadLine();
            Console.Clear();

            bool validNum = float.TryParse(userInput, out userNumber);
            while (!validNum || (userNumber < 0))
            {
                PrintInvalidInput(k_InvalidInputMsg);
                Console.WriteLine(i_ScanMsg);
                userInput = Console.ReadKey().KeyChar.ToString();
                validNum = float.TryParse(userInput, out userNumber);
                Console.Clear();
            }

            return userNumber;
        }

        /*
         * Scan general input
         */
        public static string GeneralScan(string i_ScanMsg)
        {
            string input;
            Console.WriteLine(i_ScanMsg);
            input = Console.ReadLine();
            Console.Clear();

            while (string.IsNullOrEmpty(input))
            {
                PrintInvalidInput(k_InvalidInputMsg);
                Console.WriteLine(i_ScanMsg);
                input = Console.ReadLine();
                Console.Clear();
            }

            return input;
        }

        public static void PrintInvalidInput(string i_InvalidMsg)
        {
            Console.WriteLine(i_InvalidMsg);
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
