using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodTrapeciy
{
    class Trapetion
    {
        private int n;
        private double a, b, y, dy, In;

        public Trapetion()
        {
            n = 0;
            a = 0.0;
            b = 0.0;
            y = 0.0;
            dy = 0.0;
            In = 0.0;
        }

        public Trapetion(int n1, double a1, double b1)
        {
            n = n1;
            a = a1;
            b = b1;
        }

        private double func(double x)
        { return (-3 * x * x + 2 * x + 9); }
        private double Integral(double a, double b, int n, double y)
        { return ((b - a) / (2 * n) * y); }

        public double TrapetionMethod()
        {
            dy = (b - a) / n;
            y += func(a) + func(b);
            for (int i = 1; i < n; i++) { y += 2 * (func(a + dy * i)); }
            In = Integral(a, b, n, y);
            return In;
        }
    }
}
