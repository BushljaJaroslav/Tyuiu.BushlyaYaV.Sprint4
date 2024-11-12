﻿
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BushlyaYaV.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i,j] = int.Parse(value.Substring(i * m + j,1));
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i,j] % 2  == 0)
                    {
                        sum += mtrx[i, j];
                    }
                }
            }
            return sum;
        }
    }
}