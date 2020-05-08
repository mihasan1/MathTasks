using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpsonMetod
{
    class Simpson
    {
        private double a;
        private double b;
        private double eps;

        public Simpson(double aa,double bb,double epss)
        {
            a = aa;
            b = bb;
            eps = epss;
        }

        private double function(double x)
        {
            return Math.Log(1 + x);
        }

        public double SimMeth()
        {
            double I = eps + 1, I1 = 0;//I-предыдущее вычисленное значение интеграла, I1-новое, с большим N.
            for (int N = 2; (N <= 4) || (Math.Abs(I1 - I) > eps); N *= 2)
            {
                double h, sum2 = 0, sum4 = 0, sum = 0;
                h = (b - a) / (2 * N);//Шаг интегрирования.
                for (int i = 1; i <= 2 * N - 1; i += 2)
                {
                    sum4 += function(a + h * i);//Значения с нечётными индексами, которые нужно умножить на 4.
                    sum2 += function(a + h * (i + 1));//Значения с чётными индексами, которые нужно умножить на 2.
                }
                sum = function(a) + 4 * sum4 + 2 * sum2 - function(b);//Отнимаем значение f(b) так как ранее прибавили его дважды. 
                I = I1;
                I1 = (h / 3) * sum;
            }
            I1 = Math.Round(I1, 6);
            return I1;
        }
    }
}
