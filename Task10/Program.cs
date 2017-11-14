using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            MainLogic();
        }

        private static void MainLogic()
        {
            int[,] array = new int[3, 3];
            GenerateArray(array);
            int sumOfHonestPositionsElements = SumOfHonestPositionsElements(array);
            ShowResults(sumOfHonestPositionsElements, array);
            TryAgain();
        }

        private static int SumOfHonestPositionsElements(int[,] array)
        {
            int result = 0;
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        result += array[i, j];
                    }
                }
            }
            return result;
        }

        private static void ShowResults(int sum, int[,] array)
        {
            Console.WriteLine("Array:");
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    Console.Write("{0,4} ", array[i, j]);                    
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Sum of honest positions elements = {0}", sum);
        }

        private static void GenerateArray(int[,] array)
        {
            Random rnd = new Random();
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
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
