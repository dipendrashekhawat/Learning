using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 2, 10, 5, 6, 8 };

            Console.WriteLine(" Original Array: " + string.Join(",", arr));

            Console.WriteLine("\n Sum of array using LINQ sum function : " + arr.Sum());

            Console.WriteLine(" Sum of array using Enumerable.Sum : " + Enumerable.Sum(arr));

            int sum = 0;
            Array.ForEach(arr, delegate(int i) { sum += i; });  // anonymous function
            Console.WriteLine(" Sum of array without built in function : " + sum);

            sum = 0;
            float average;
            int arrLength = arr.Length;

            Array.Sort(arr); // sorting the array in asc order will give us first element as min and last element as max.
            Console.WriteLine("\n Sorted Array: " + string.Join(",", arr));

            for (int i = 0; i < arrLength; i++)
            {
                sum += arr[i];
            }

            average = ((float)sum / arrLength);

            Console.WriteLine("\n Sum Average Min Max without using built-in functions or Methods in C#" + "\n");
            Console.WriteLine(" Min of array: " + arr[0]);
            Console.WriteLine(" Max of array: " + arr[arrLength - 1]);
            Console.WriteLine(" Sum of elements of array: " + sum);
            Console.WriteLine(" Avg of elements of array: " + average);


            //Reverse an array without using Array.Reverse() and any other array

            int[] newArr = new int[5] { 2, 10, 5, 6, 8 };

            Console.WriteLine("\n*** Reversing array elements ***");

            Console.WriteLine(" Original Array: " + string.Join(",", newArr));

            for (int i = 0; i < newArr.Length / 2; i++)
            {
                int temp = newArr[i];
                newArr[i] = newArr[newArr.Length - i - 1];
                newArr[newArr.Length - i - 1] = temp;
            }

            Console.WriteLine(" Reversed Array: " + string.Join(",", newArr));

            Console.WriteLine("\n*** Swapping two numbers without using third variable ***");

            //Swap Two Numbers Without using Third Variable in C#

            int first = 1;
            int second = 2;

            string result = string.Format(" Numbers before swapping: First = {0} and Second = {1}", first, second);
            Console.WriteLine(result);

            first = first + second; // first = 3
            second = first - second; // second = 1
            first = first - second; // first = 2

            result = string.Format(" Numbers before swapping: First = {0} and Second = {1}", first, second);
            Console.WriteLine(result);

            Console.ReadLine();

        }

    }
}
