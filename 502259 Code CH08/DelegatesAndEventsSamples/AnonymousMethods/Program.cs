using System;

namespace Wrox.ProCSharp.Delegates
{
    class Program
    {
        static void Main()
        {
            string mid = ", middle part,";

            Func<string, string> anonDel = delegate(string param)
            {
                param += mid;
                param += " and this was added to the string.";
                return param;
            };
            Func<string, string> anonDel2 = param =>
            {
                param += mid;
                param += " and this was added to the string.";
                return param;
            };
            Console.WriteLine(anonDel("Start of string"));
            Console.WriteLine(anonDel2("Start2 of string"));
            Console.ReadKey();
        }
    }

}
