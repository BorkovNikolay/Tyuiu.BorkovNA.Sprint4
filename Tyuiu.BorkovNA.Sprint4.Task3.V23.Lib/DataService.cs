using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BorkovNA.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task3V23
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0) { res++; }
                }
            }
            return res;
        }
    }
}
