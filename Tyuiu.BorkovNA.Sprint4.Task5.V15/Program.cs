using System;
using Tyuiu.BorkovNA.Sprint4.Task5.V15.Lib;




namespace Tyuiu.BorkovNA.Sprint4.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rd = new();


            Console.Title = "Cпринт #4 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            int rows = Convert.ToInt32(Console.ReadLine()); int cols = Convert.ToInt32(Console.ReadLine());
            int[,] input = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    input[i, j] = rd.Next(-4, 6);
                    Console.Write($"{input[i, j]}; ");
                    if (j == cols - 1) { Console.WriteLine(); }
                }
            }
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            int res = ds.Calculate(input);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }

}