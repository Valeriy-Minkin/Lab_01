using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minkin_lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MainLogic();
        }

        private static void MainLogic()
        {
            int a = 0, b = 0, area = 0;
            ReadRectangleInfo(ref a, ref b);
            if (ValidateInput(a, b))
            {
                area = CalculateArea(a, b);
                ShowResult(area);
            }
            else
            {
                ShowError();
            }
            TryAgain();
        }

        private static void TryAgain()
        {
            Console.Write("Try again? (y/n) ");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == 'y' || key.KeyChar == 'Y')
            {
                MainLogic();
            }
        }

        private static void ShowResult(int area)
        {
            Console.WriteLine("Area ={0} ", area);
        }

        private static void ShowError()
        {
            Console.WriteLine("Wrong data!");
        }

        private static bool ValidateInput(int a, int b)
        {
            return CheckSide(a) && CheckSide(b);
        }

        private static bool CheckSide(int side)
        {
            return side > 0;
        }

        private static int CalculateArea(int a, int b)
        {
            return a * b;
        }

        private static void ReadRectangleInfo(ref int a, ref int b)
        {
            ReadRectangleSide(ref a);
            ReadRectangleSide(ref b);
        }

        private static void ReadRectangleSide(ref int side)
        {
            string inputString;
            Console.Write("Input first side: ");
            inputString = Console.ReadLine();
            int.TryParse(inputString, out side);
        }
    }
}
