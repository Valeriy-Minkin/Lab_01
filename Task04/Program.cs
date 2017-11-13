using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
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
                DrawXmasTree(steps);
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

        private static void DrawXmasTree(int steps)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i <= steps; i++)
            {
                DrawTriangle(steps, i);
            }
            Console.ResetColor();
        }

        private static void DrawTriangle(int steps, int currentStep)
        {
            StringBuilder currentString = new StringBuilder(steps);
            InitCurrentString(currentString, steps);
            currentString[steps] = '*';
            for (int i = 0; i < currentStep; i++)
            {
                currentString[steps + i] = '*';
                currentString[steps - i] = '*';
                Console.WriteLine(currentString.ToString());
            }
        }

        private static void InitCurrentString(StringBuilder currentString, int steps)
        {
            currentString.Append(' ', (2 * steps) + 1);
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
