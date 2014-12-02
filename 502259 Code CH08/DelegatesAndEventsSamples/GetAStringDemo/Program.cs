using System;

namespace Wrox.ProCSharp.Delegates
{
    class Program
    {
        private delegate string GetAString();

        static void Main()
        {
            const int x = 40;
            GetAString firstStringMethod = x.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());

            var balance = new Currency(34, 50);
            
            // firstStringMethod references an instance method
            firstStringMethod = balance.ToString;
            Console.WriteLine("String is {0}", firstStringMethod());

            // firstStringMethod references a static method
            firstStringMethod = Currency.GetCurrencyUnit;
            Console.WriteLine("String is {0}", firstStringMethod());
            Console.ReadKey();
        }
    }
}
