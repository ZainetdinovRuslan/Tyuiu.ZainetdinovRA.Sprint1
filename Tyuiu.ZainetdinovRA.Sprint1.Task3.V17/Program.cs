using System.Text;
using Tyuiu.ZainetdinovRA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.OutputEncoding = Encoding.UTF8;

            Console.Title = "Спринт #1 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых трех цифр  *");
            Console.WriteLine("* из дробной части заданного вещественного числа цифра 0.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double number = 1.3202;
            var result = ds.ZeroCheck(number);
            Console.WriteLine($"Проверим число {number} на наличие нуля после трех цифр из дробной части.");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Число {number} содержит ноль в первых трёх знаках после запятой: {result}");

            Console.ReadKey();
        }
    }
}
