using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLARProhod
{
    class Class1
    {
        static public int N;
        public double[,] matA = new double[5,5];
        public double[] matB = new double[5];
        public int N1;
        public double y;
        public double[] a = new double[5];
        public double[] B = new double[5];
        public double[] matRes = new double[5];

        public Class1()
        {
            N = 0;
            N1 = 0;
            y = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matA[i, j] = 0;
                }
                matB[i] = 0;
                a[i] = 0;
                B[i] = 0;
                matRes[i] = 0;
            }
        }

        public Class1(int n, double[,] arr, double[] arr2)
        {
            N = n;
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    matA[i, j] = arr[i, j];
                }
                matB[i] = arr2[i];
            }
        }
        public void progonka()
        {
            N1 = N - 1;
            y = matA[0,0];
            a[0] = -matA[0,1] / y;
            B[0] = matB[0] / y;
            for (int i = 1; i < N1; i++)
            {
                y = matA[i,i] + matA[i,i - 1] * a[i - 1];
                a[i] = -matA[i,i + 1] / y;
                B[i] = (matB[i] - matA[i,i - 1] * B[i - 1]) / y;
            }
            matRes[N1] = (matB[N1] - matA[N1,N1 - 1] * B[N1 - 1]) / (matA[N1,N1] + matA[N1,N1 - 1] * a[N1 - 1]);
            matRes[N1] = Math.Round(matRes[N1], 6);
            for (int i = N1 - 1; i >= 0; i--)
            {
                matRes[i] = a[i] * matRes[i + 1] + B[i];
                matRes[i] = Math.Round(matRes[i], 6);
            }
        }
    }
}
