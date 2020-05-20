using System;

namespace Day_24
{
    class MathManager
    {
        public static double Plus(double A, double B)
        {
            return A + B;
        }
        public static double Minus(double A, double B)
        {
            return A - B;
        }
        public static double Multiplication(double A, double B)
        {
            return A * B;
        }
        public static double Division(double A, double B)
        {
            if (B == 0)
                throw new DivideByZeroException();
            return A / B;
        }
        public static double Sqrt(double X)
        {
            return Math.Sqrt(X);
        }
        public static double Mod(double A, double B)
        {
            return ((A * B) / 100);
        }
    }
}
