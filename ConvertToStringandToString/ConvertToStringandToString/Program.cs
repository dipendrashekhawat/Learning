using System;
namespace ConvertToStringandToString
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name;
                object value = null;

                name = value.ToString(); // Doesn't handle null values throw exception
                name = Convert.ToString(value); //Handles null values

                Console.WriteLine("Null value is handles and Convert.ToString() doesn't throw NULL exception.");
            }
            catch (NullReferenceException nullReferenceException)
            {
                Console.WriteLine(".ToString() Method doesn't handle NULL values. Error Message: " + nullReferenceException.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception occurred: " + exception.Message);
            }

            Console.ReadLine();
        }
    }
}
