using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            MainLogic();
        }

        private static void MainLogic()
        {
            string input = InputCountOfStep();
            int steps = 0;
            if (int.TryParse(input, out steps) && Validate(steps))
            {
                DrawOtherTriangle(steps);
            }
            else
            {
                ShowErrors();
            }
            TryAgain();
        }

        private static void ShowErrors()
        {
            Console.WriteLine("Wrong data!");
        }

        private static void DrawOtherTriangle(int steps)
        {
            StringBuilder currentString = new StringBuilder(steps);
            Console.ForegroundColor = ConsoleColor.Green;
            InitCurrentString(currentString, steps);
            currentString[steps] = '*';
            for (int i = 0; i < steps; i++)
            {
                currentString[steps + i] = '*';
                currentString[steps - i] = '*';
                Console.WriteLine(currentString.ToString());
            }
            Console.ResetColor();
        }

        private static void InitCurrentString(StringBuilder currentString, int steps)
        {
            currentString.Append(' ', (2*steps)+1);
        }

        private static bool Validate(int steps)
        {
            return steps > 0;
        }

        private static string InputCountOfStep()
        {
            Console.Write("Input count of steps: ");
            return Console.ReadLine();
        }

        private static void TryAgain()
        {
            Console.Write("Try again? (y/n) ");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == 'y' || key.KeyChar == 'Y')
            {
                Console.WriteLine("");
                MainLogic();
            }
        }
    }
}
