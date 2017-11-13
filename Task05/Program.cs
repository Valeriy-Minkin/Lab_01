using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        const int firstDivider = 3;
        const int secondDivider = 5;

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            FindMultipleOfDivider(numbers, firstDivider);
            FindMultipleOfDivider(numbers, secondDivider);
            numbers = numbers.Distinct().ToList<int>();
            Console.WriteLine("Sum of all multiples: {0}", CalculateSum(numbers));
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }

        private static int CalculateSum(List<int> numbers)
        {
            int result = 0;
            foreach (int x in numbers)
            {
                result += x;
            }
            return result;
        }

        private static void FindMultipleOfDivider(List<int> numbers, int divider)
        {
            int number = 0;
            while (number < 1000 - divider)
            {
                number += divider;
                numbers.Add(number);
            }
        }
    }
}
