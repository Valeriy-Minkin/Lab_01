using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            MainLogic();
        }

        private static void MainLogic()
        {
            int[] array = new int[100];
            GenerateArray(array);
            int sumOfNonNegativeElements = SumOfNonNegativeElements(array);
            ShowResults(sumOfNonNegativeElements, array);
            TryAgain();
        }

        private static int SumOfNonNegativeElements(int[] array)
        {
            int result = 0;
            for(int i=0; i<array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    result += array[i];
                }
            }
            return result;
        }

        private static void ShowResults(int sum, int[] array)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.Write("{0}", array[array.Length - 1]);
            Console.WriteLine("");
            Console.WriteLine("Sum of non-negative elements is {0}", sum);
        }

        private static void GenerateArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
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
