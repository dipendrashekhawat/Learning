using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0;

            Console.Write("Enter a number : ");
            num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum = sum + rem * rem * rem;
            }

            if (sum == num)
                Console.WriteLine("{0} is an Armstrong number.", num);
            else
                Console.WriteLine("{0} is not an Armstrong number.", num);

            Console.ReadLine();
        }
    }
}
