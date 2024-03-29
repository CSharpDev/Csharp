﻿using System;
using Wrox.ProCSharp.Arrays;

namespace Sample1
{
    class Program
    {
        static void Main()
        {
            SimpleArrays();
            TwoDim();
            ThreeDim();
            Jagged();

            ArrayClass();
            CopyArrays();

            Console.ReadKey();


        }

        static void CopyArrays()
        {
            Person[] beatles = {
                     new Person { FirstName="John", LastName="Lennon" },
                     new Person { FirstName="Paul", LastName="McCartney" }
                   };

           // Person[] beatlesClone = (Person[])beatles.Clone();
            Person[] beatlesClone = beatles;
            beatlesClone[0].FirstName = "LG";
            Console.WriteLine(beatles[0].FirstName);
        }

        static void ArrayClass()
        {
            Array intArray1 = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < 5; i++)
            {
                intArray1.SetValue(33, i);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray1.GetValue(i));
            }

            int[] lengths = { 2, 3 };
            int[] lowerBounds = { 1, 10 };
            Array racers = Array.CreateInstance(typeof(Person), lengths, lowerBounds);

            racers.SetValue(new Person { FirstName = "Alain", LastName = "Prost" }, 1, 10);
            racers.SetValue(new Person
            {
                FirstName = "Emerson",
                LastName = "Fittipaldi"
            }, 1, 11);
            racers.SetValue(new Person { FirstName = "Ayrton", LastName = "Senna" }, 1, 12);
            racers.SetValue(new Person { FirstName = "Ralf", LastName = "Schumacher" }, 2, 10);
            racers.SetValue(new Person { FirstName = "Fernando", LastName = "Alonso" }, 2, 11);
            racers.SetValue(new Person { FirstName = "Jenson", LastName = "Button" }, 2, 12);

            Person[,] racers2 = (Person[,])racers;
            Person first = racers2[1, 10];
            Person last = racers2[2, 12];


        }

        static void Jagged()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[2] { 1, 2 };
            jagged[1] = new int[6] { 3, 4, 5, 6, 7, 8 };
            jagged[2] = new int[3] { 9, 10, 11 };

            //for (int row = 0; row < jagged.Length; row++)
            //{
            //    for (int element = 0;
            //       element < jagged[row].Length; element++)
            //    {
            //        Console.WriteLine(
            //           "row: {0}, element: {1}, value: {2}",
            //           row, element, jagged[row][element]);
            //    }
            //}
            foreach (var row in jagged)
            {
                foreach (var element in row)
                {
                    Console.Write(element+" ");                      
                }
                Console.WriteLine();
            }


        }

        static void ThreeDim()
        {
            int[, ,] threedim = {
                    { { 1, 2 }, { 3, 4 } },
                    { { 5, 6 }, { 7, 8 } },
                    { { 9, 10 }, { 11, 12 } }
                   };


            Console.WriteLine(threedim[0, 1, 1]);
        }

        static void TwoDim()
        {
            int[,] twodim = new int[3, 3];
            twodim[0, 0] = 1;
            twodim[0, 1] = 2;
            twodim[0, 2] = 3;
            twodim[1, 0] = 4;
            twodim[1, 1] = 5;
            twodim[1, 2] = 6;
            twodim[2, 0] = 7;
            twodim[2, 1] = 8;
            twodim[2, 2] = 9;

        }


        static void SimpleArrays()
        {
            Person[] myPersons = new Person[2];

            myPersons[0] = new Person { FirstName = "Ayrton", LastName = "Senna" };
            myPersons[1] = new Person { FirstName = "Michael", LastName = "Schumacher" };

            Person[] myPersons2 = 
            { 
                new Person { FirstName="Ayrton", LastName="Senna"},
                new Person { FirstName="Michael", LastName="Schumacher"} 
            };
        }
    }
}
