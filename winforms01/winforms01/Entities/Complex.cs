using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winforms01
{
    class Complex
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double R { get; set; }
        public double T { get; set; }
        private static double tolerance = 0.000000001;
        public Complex()
        {
            X = 0;
            Y = 0;
            R = 0;
            T = 0;
        }
        public Complex(double x, double y)
        {
            X = x;
            Y = y;
            ToPolar();
        }
        public Complex(double a, double b, string type)
        {
            switch (type)
            {
                case "P":
                    R = a;
                    T = b;
                    ToCart();
                    break;
                default:
                    X = a;
                    Y = b;
                    ToPolar();
                    break;
            }
        }
        private void ToPolar()
        {
            double theta = 0;

            if (X > 0 && Y > 0) { theta = Math.Atan(Y / X); }
            else if (X < 0 && Y > 0) { theta = Math.Atan(Y / X) + Math.PI; }
            else if (X < 0 && Y < 0) { theta = Math.Atan(Y / X) - Math.PI; }
            else if (X > 0 && Y < 0) { theta = Math.Atan(Y / X); }
            else if (X == 0 && Y > 0) { theta = Math.PI / 2; }
            else if (X == 0 && Y < 0) { theta = -Math.PI / 2; }

            if (X == 0 && Y == 0) { R = 0; }
            else { R = Math.Sqrt(X * X + Y * Y); }

            T = theta;
        }
        private void ToCart()
        {
            X = (Math.Abs(R * Math.Cos(T)) < tolerance) ? 0 : R * Math.Cos(T);
            Y = (Math.Abs(R * Math.Sin(T)) < tolerance) ? 0 : R * Math.Sin(T);
        }
        public static Complex Add(Complex c1, Complex c2)
        {
            return new Complex { X = c1.X + c2.X, Y = c1.Y + c2.Y };
        }
        public static Complex Subtract(Complex c1, Complex c2)
        {
            return new Complex { X = c1.X - c2.X, Y = c1.Y - c2.Y };
        }
        public static Complex Multiply(Complex c1, Complex c2)
        {
            return new Complex { X = (c1.X * c2.X - c1.Y * c2.Y), Y = (c1.X * c2.Y + c1.Y * c2.X) };
        }
        public static Complex Divide(Complex c1, Complex c2)
        {
            double c2Norm = c2.X * c2.X + c2.Y * c2.Y;
            if (c2Norm != 0) {
                return new Complex { X = (c1.X*c2.X + c1.Y*c2.Y)/c2Norm, Y = (c1.Y*c2.X-c1.X*c2.Y)/c2Norm };
            } else { return null; }
        }
        public static Complex Conjugate(Complex c)
        {
            return new Complex { X = c.X, Y = -c.Y };
        }
        public static Complex Exp(Complex c, int n)
        {
            if (n == 0) { return new Complex { X = 1, Y = 0 }; }
            Complex z = c;
            for (int i = 1; i < n; i++)
            {
                z = Complex.Multiply(z, c);
            }
            return z;
        }
        public static double Norm(Complex c)
        {
            return 0;
        }
        public override string ToString()
        {
            return X.ToString() + " " + ((Y >= 0) ? "+" : "-") + " i" + ((Y >= 0) ? Y.ToString() : (-Y).ToString());
        }
        public string ToString(string polar)
        {
            return R.ToString() + " e^(" + ((T >= 0) ? "" : "-") + "i" + ((T >= 0) ? T.ToString() : (-T).ToString() + ")");
        }
    }
}
