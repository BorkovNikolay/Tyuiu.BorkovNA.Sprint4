﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BorkovNA.Sprint4.Task1.V7.Lib
{
    public class DataService : ISprint4Task0V7
    {
        public int GetMultOddArrEl(int[] array)
        {
            int p = 0;
            for (int i = 0; i < array.Length; i++) { if (array[i] % 2 == 0) { p += array[i]; } }
            return p;
        }
    }
}