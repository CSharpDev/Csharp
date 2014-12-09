using System;
using Wrox.ProCSharp.OOCSharp;

namespace VectorStruct
{
    internal class MainEntryPoint
    {
        private static void Main()
        {
            Vector vect1 = new Vector(3.0, 3.0, 1.0);
            Vector vect2 = new Vector(2.0, -4.0, -4.0);
            Vector vect3 = vect1 - vect2;            
            Console.WriteLine("vect1 = " + vect1.ToString());
            Console.WriteLine("vect2 = " + vect2.ToString());
            Console.WriteLine("vect3 = " + vect3.ToString());

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
        public static Vector operator -(Vector lhs, Vector rhs)
        {
            Vector result = new Vector(lhs);
            result.X -= rhs.X;
            result.Y -= rhs.Y;
            result.Z -= rhs.Z;
            return result;
        }
    }
}


