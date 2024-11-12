using System;
using Tyuiu.BorkovNA.Sprint4.Task1.V7.Lib;




namespace Tyuiu.BorkovNA.Sprint4.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] input = new int[11];

            Console.Title = "Cпринт #4 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            for (int i = 0; i <= 10; i++) { input[i] = Convert.ToInt32(Console.ReadLine()); }
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            int res = ds.GetMultOddArrEl(input);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }

}