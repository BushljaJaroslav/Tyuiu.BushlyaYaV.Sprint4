﻿
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BushlyaYaV.Sprint4.Task1.V25.Lib
{
    public class DataService : ISprint4Task1V25
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0 && array[i] <= 7)
                {
                    sumArray = sumArray + array[i];
                }
            }
            return sumArray;
        }
    }
}