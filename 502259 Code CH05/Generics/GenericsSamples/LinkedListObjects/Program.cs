using System;

namespace LinkedListObjects
{
    class Program
    {
        static void Main()
        {
            var list1 = new LinkedList();
            list1.AddLast(2);
            list1.AddLast(4);
            list1.AddLast("6");

            foreach (object i in list1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
