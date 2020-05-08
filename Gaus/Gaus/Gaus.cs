using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauss
{
    class Gaus
    {
        // Змінні класу
        private double s;
        private const int n=3;
        private double[,] a = new double[n, n];// масив матриці
        private double[] b = new double[n];// масив правих коефіцієнтів рівняння
        public double[] x = new double[n];// масив відповідей
        //Конструктор класу
        public Gaus()
        {
            s = 0;
            for (int i = 0; i < n; i++)
            {
                b[i] = 0;
                x[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    a[i, i] = 0;
                }
            }
        }
        // Перевантаження конструктора класу
        public Gaus(double [,] a_, double [] b_)
        {
            for(int i=0; i<n; i++)
            {
                b[i] = b_[i];
                for(int j=0; j<n; j++)
                {
                    a[i, j] = a_[i, j];
                }
            }
        }
        // Головний метод, в якому реалізований алгоритм вирішення СЛАР методом Гауса.
        public void Solve()
        {
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    for (int j = k + 1; j < n; j++)
                    {
                        a[i, j] = a[i, j] - a[k, j] * (a[i, k] / a[k, k]);
                    }
                    b[i] = b[i] - b[k] * a[i, k] / a[k, k];
                }
            }
            for (int k = n - 1; k >= 0; k--)
            {
                s = 0;
                for (int j = k + 1; j < n; j++)
                    s = s + a[k, j] * x[j];
                x[k] = (b[k] - s) / a[k, k];
            }
        }
    }
}
