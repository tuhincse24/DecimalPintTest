using System;
using System.Globalization;

namespace DecimalPointTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleNumber;

            doubleNumber = 18934;

            //by default after the decimal point the number digits are 2

            Console.WriteLine("The Fixed-point format specifier for an Double value is :" + doubleNumber.ToString("F", CultureInfo.InvariantCulture));

            //here the number digits after the decimal point is 3

            Console.WriteLine("The Number with 3 digits after the decimal point : " + doubleNumber.ToString("F3", CultureInfo.InvariantCulture));

            //here the number digits after the decimal point is 4

            Console.WriteLine("The Number with 4 digits after the decimal point : " + doubleNumber.ToString("F4", CultureInfo.InvariantCulture));

            //here the number digits after the decimal point is 5

            Console.WriteLine("The Number with 5 digits after the decimal point : " + doubleNumber.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("The Number with 8 digits after the decimal point : " + doubleNumber.ToString("F8", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
