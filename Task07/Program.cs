using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
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
            SortArray(array);
            int min = FindMinInArray(array);
            int max = FindMaxInArray(array);
            ShowResults(min, max, array);
            TryAgain();
        }

        private static void ShowResults(int min, int max, int[] array)
        {
            Console.WriteLine("Array:");
            for(int i = 0; i<array.Length-1; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.Write("{0}", array[array.Length-1]);
            Console.WriteLine("");
            Console.WriteLine("Minimum value is {0}", min);
            Console.WriteLine("Maximum value is {0}", max);
        }

        private static int FindMaxInArray(int[] array)
        {
            return array[array.Length - 1];
        }

        private static int FindMinInArray(int[] array)
        {
            return array[0];
        }

        private static void SortArray(int[] array)
        {
            int current;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        current = array[i];
                        array[i] = array[j];
                        array[j] = current;
                    }
                }
            }
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
