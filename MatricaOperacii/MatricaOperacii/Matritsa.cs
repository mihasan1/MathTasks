using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricaOperacii
{
    class Matritsa
    {
        static public int N, M;
        public double[,] A = new double[N, M];
        public double[,] B = new double[N, M];
        public double[,] C = new double[N, M];

        public Matritsa(float [,] matr1, float [,] matr2)
        {
            for(int i=0; i<N; i++)
            {
                for(int j=0; j<M; j++)
                {
                    A[i, j] = matr1[i, j];
                    B[i, j] = matr2[i, j];
                    C[i, j] = 0;
                }
            }
        }

        public void MatrPlus()
        {
            for(int i=0; i<N; i++)
            {
                for(int j=0; j<M; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
        }
        public void RiznitsyaMatr()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }
        }
        public void DobutokMatr()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    C[i, j] = A[i, j] * B[i, j];
                }
            }
        }

        public void Dilennya()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    C[i, j] = A[i, j] / B[i, j];
                }
            }
        }
        public void TranspA()
        {
            
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    C[i, j] = A[j, i];
                }
        }
        public void TranspB()
        {

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    C[i, j] = B[j, i];
                }
        }
    }
}
