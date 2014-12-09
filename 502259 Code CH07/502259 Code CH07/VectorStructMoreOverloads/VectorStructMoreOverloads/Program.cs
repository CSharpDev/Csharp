using System;
using Wrox.ProCSharp.OOCSharp;

namespace VectorStruct
{
    internal class MainEntryPoint
    {
        private static void Main()
        {
            // stuff to demonstrate arithmetic operations
            Vector vect1 = new Vector(1.0, 1.5, 2.0);
            Vector vect2 = new Vector(0.0, 0.0, -10.0);

            Vector vect3 = vect1 + vect2;

            Console.WriteLine("vect1 = " + vect1);
            Console.WriteLine("vect2 = " + vect2);
            Console.WriteLine("vect3 = vect1 + vect2 = " + vect3);
            Console.WriteLine("2*vect3 = " + 2 * vect3);

            vect3 += vect2;

            Console.WriteLine("vect3+=vect2 gives " + vect3);

            vect3 = vect1 * 2;

            Console.WriteLine("Setting vect3=vect1*2 gives " + vect3);

            double dot = vect1*vect3;

            Console.WriteLine("vect1*vect3 = " + dot);

            Console.ReadLine();
        }
    }
}

namespace Wrox.ProCSharp.OOCSharp
{
    struct Vector
    {
        public double X, Y, Z;

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector(Vector rhs)
        {
            X = rhs.X;
            Y = rhs.Y;
            Z = rhs.Z;
        }

        public override string ToString()
        {
            return "( " + X + " , " + Y + " , " + Z + " )";
        }

        public static Vector operator +(Vector lhs, Vector rhs)
        {
            Vector result = new Vector(lhs);
            result.X += rhs.X;
            result.Y += rhs.Y;
            result.Z += rhs.Z;

            return result;
        }

        public static Vector operator *(double lhs, Vector rhs)
        {
            return new Vector(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        public static Vector operator *(Vector lhs, double rhs)
        {
            return rhs * lhs;
        }

        public static double operator *(Vector lhs, Vector rhs)
        {
            return lhs.X * rhs.X + lhs.Y + rhs.Y + lhs.Z * rhs.Z;
        }

    }
}


