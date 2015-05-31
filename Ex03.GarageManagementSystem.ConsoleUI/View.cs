// --------------------------------------------------------------------------------------------------------------------
// <copyright file="View.cs" company="">
//   
// </copyright>
// <summary>
//   The view.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex03.GarageManagementSystem.ConsoleUI
{
    using System;
    using System.Threading;

    /// <summary>
    /// The view.
    /// </summary>
    public class View
    {
        /// <summary>
        /// The k_ invalid input msg.
        /// </summary>
        public const string k_InvalidInputMsg = "Sorry, that's an invalid input";

        /*
         * Gets a valid menu selection
         */

        /// <summary>
        /// The menu scan.
        /// </summary>
        /// <param name="i_MsgToUser">
        /// The i_ msg to user.
        /// </param>
        /// <param name="i_NumOfMenuOptions">
        /// The i_ num of menu options.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
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

        /// <summary>
        /// The number scan.
        /// </summary>
        /// <param name="i_ScanMsg">
        /// The i_ scan msg.
        /// </param>
        /// <returns>
        /// The <see cref="float"/>.
        /// </returns>
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
                userInput = Console.ReadLine();
                validNum = float.TryParse(userInput, out userNumber);
                Console.Clear();
            }

            return userNumber;
        }

        /*
         * Scan general input
         */

        /// <summary>
        /// The general scan.
        /// </summary>
        /// <param name="i_ScanMsg">
        /// The i_ scan msg.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
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

        /// <summary>
        /// The print invalid input.
        /// </summary>
        /// <param name="i_InvalidMsg">
        /// The i_ invalid msg.
        /// </param>
        public static void PrintInvalidInput(string i_InvalidMsg)
        {
            Console.WriteLine(i_InvalidMsg);
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}