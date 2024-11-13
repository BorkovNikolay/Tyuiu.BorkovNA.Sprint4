using System;
using Tyuiu.BorkovNA.Sprint4.Task6.V22.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace Tyuiu.BorkovNA.Sprint4.Task6.V22
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
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #22                                                              *");
            Console.WriteLine("* Выполнил: Борков Н. А. | пктб-24-1                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("* \"Снег\", \"Дождь\", \"Туман\", \"Град\", \"Ветер\", \"Туча\", \"Засуха\"   *");
            string[] input = { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            string[] res = ds.Calculate(input);
            for (int i = 0; i < res.Length; i++) 
                {
                     Console.WriteLine(res[i]);
                } 

     


            Console.ReadKey();

        }
    }

}