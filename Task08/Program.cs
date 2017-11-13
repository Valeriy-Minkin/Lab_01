using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            MainLogic();
        }

        private static void MainLogic()
        {
            int[,,] array = new int[10,10,10];
            GenerateArray(array);
            ArrayOfHopelessness(array);
            ShowResults(array);
            TryAgain();
        }

        private static void ArrayOfHopelessness(int[,,] array)
        {
            for (int i = array.GetLowerBound(0); i < array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j < array.GetUpperBound(1); j++)
                {
                    for (int k = array.GetLowerBound(2); k < array.GetUpperBound(2); k++)
                    {
                        if (array[i, j, k] >=0) { array[i, j, k] = 0; }
                    }
                }
            }
        }

        private static void ShowResults(int[,,] array)
        {
            Console.WriteLine("Array:");
            for (int i = array.GetLowerBound(0); i < array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j < array.GetUpperBound(1); j++)
                {
                    for (int k = array.GetLowerBound(2); k < array.GetUpperBound(2); k++)
                    {
                        Console.Write("{0,4} ", array[i, j, k]);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

        private static void GenerateArray(int[,,] array)
        {
            Random rnd = new Random();
            for (int i = array.GetLowerBound(0); i < array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j < array.GetUpperBound(1); j++)
                {
                    for (int k = array.GetLowerBound(2); k < array.GetUpperBound(2); k++)
                    {
                        array[i,j,k] = rnd.Next(-100, 100);
                    }
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
