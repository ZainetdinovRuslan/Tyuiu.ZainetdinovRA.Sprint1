using System.Text;
using Tyuiu.ZainetdinovRA.Sprint1.Task4.V18.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Спринт #1 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #1                                                           *");
            Console.WriteLine("* Тема: Class Math                                                    *");
            Console.WriteLine("* Задание #4                                                          *");
            Console.WriteLine("* Вариант #18                                                         *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2              *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные     *");
            Console.WriteLine("* данные, вычисляет результат по формуле и печатает его на экране.    *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                          *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            double x;
            Console.Write("Введите число для x: ");
            x = Convert.ToDouble(Console.ReadLine());
            double y;
            Console.Write("Введите число для y: ");
            y = Convert.ToDouble(Console.ReadLine());

            var result = ds.Calculate(x, y);
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine($"Результат формулы: {result}");
        }
    }
}
