using System;
using Tyuiu.BorkovNA.Sprint4.Task2.V1.Lib;




namespace Tyuiu.BorkovNA.Sprint4.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            
            Random rd = new Random();

            Console.Title = "Cпринт #4 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.Write("* Длина массива = ");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[l];
            for (int i = 0; i < l; i++)
            {
                input[i] = rd.Next(1, 9);
                Console.Write($"{input[i]},");
                if (i == l - 1) { Console.Write("\n"); }
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