using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int sum = SumWithForeach(numbers);
            Console.WriteLine("The sum is: " + sum);
        }

        static int SumWithForeach(List<int> list)
        {
            int sum = 0;
            foreach (int number in list)
            {
                sum += number;
            }
            return sum;
        }

    }
}
