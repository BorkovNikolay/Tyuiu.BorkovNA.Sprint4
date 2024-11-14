using System;
using Tyuiu.BorkovNA.Sprint4.Task7.V15.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace Tyuiu.BorkovNA.Sprint4.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Cпринт #4 | Выполнил: Борков Н. А. | пктб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Операции сравнения                                                 *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Условие: Дана строка из одноразрядных цифр.                              *");
            Console.WriteLine("* Преобразуйте ее в матрицу 4 на 2 и подсчитайте количество четных чисел.  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.Write("* Строка = ");
            string input = Console.ReadLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(input.Substring(j  + i*2, 1) + "; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            int res = ds.Calculate(4,2,input);

                Console.WriteLine(res);
            Console.ReadKey();

        }
    }

}