using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "dotnetcrunch";
            string newName = name.MyExtensionMethod();
            Console.WriteLine(newName);
            Console.ReadKey();
        }
    }

    public static class StingHelper
    {
        public static string MyExtensionMethod(this string input)
        {
            char[] charArray = input.ToCharArray();
            charArray[0] = char.IsLower(charArray[0]) ? char.ToUpper(charArray[0]) : char.ToLower(charArray[0]);
            return new string(charArray);
        }

    }
}
