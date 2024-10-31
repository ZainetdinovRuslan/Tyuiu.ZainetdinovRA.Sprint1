using System.Text;
using Tyuiu.ZainetdinovRA.Sprint1.Task3.V17.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Tyuiu.ZainetdinovRA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds =  new DataService();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Спринт #1 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #1                                                           *");
            Console.WriteLine("* Тема: Операторы составного присваиванияэ                            *");
            Console.WriteLine("* Задание #3                                                          *");
            Console.WriteLine("* Вариант #17                                                         *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2              *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых трех   *");
            Console.WriteLine("* цифр из дробной части заданного вещественного числа цифра 0.        *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            double x;
            Console.Write("Введите вещественное число: ");

            x = Convert.ToDouble(Console.ReadLine());


            var result = ds.ZeroCheck(x);
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine($"В числе {x} есть 0: {result}");
        }
    }
}
