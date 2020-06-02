using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horda
{
    class HodraKlas
    {
        private double x;
        private double a;
        private double b;
        private double eps;

        public HodraKlas(double formA, double formB, double formEps)
        {
            x = 0; a = formA; b = formB; eps = formEps;
        }

        private double Fct(double x)
        {
            return x*x-Math.Sin(x)-1;
        }

        
        public double Reshenie(double x_prev, double x_curr, double e)
        {
            double x_next = 0;
            double tmp;

            do
            {
                tmp = x_next;
                x_next = x_curr - Fct(x_curr) * (x_prev - x_curr) / (Fct(x_prev) - Fct(x_curr));
                x_prev = x_curr;
                x_curr = tmp;
            } while (Math.Abs(x_next - x_curr) > e);

            return x_next;
        }
    }
}
