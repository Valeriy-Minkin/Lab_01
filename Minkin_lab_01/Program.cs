using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    class Program
    {
        struct Rectangle
        {
            public int a;
            public int b;
        }

        static void Main(string[] args)
        {
            MainLogic();
        }

        private static void MainLogic()
        {
            Rectangle rectangle = new Rectangle();
            int area = 0;
            ReadRectangleInfo(ref rectangle);
            if (ValidateInput(rectangle))
            {
                area = CalculateArea(rectangle);
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
                Console.WriteLine("");
                MainLogic();
            }
        }

        private static void ShowResult(int area)
        {
            Console.WriteLine("Area = {0} ", area);
        }

        private static void ShowError()
        {
            Console.WriteLine("Wrong data!");
        }

        private static bool ValidateInput(Rectangle rectangle)
        {
            return CheckSide(rectangle.a) && CheckSide(rectangle.b);
        }

        private static bool CheckSide(int side)
        {
            return side > 0;
        }

        private static int CalculateArea(Rectangle rectangle)
        {
            return rectangle.a * rectangle.b;
        }

        private static void ReadRectangleInfo(ref Rectangle rectangle)
        {
            ReadRectangleSide(ref rectangle.a);
            ReadRectangleSide(ref rectangle.b);
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
