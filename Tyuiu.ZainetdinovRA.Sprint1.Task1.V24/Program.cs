using System.Text;
using Tyuiu.ZainetdinovRA.Sprint1.Task1.V24.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task1.V24
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
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях             *");
            Console.WriteLine("* Задание #1                                                          *");
            Console.WriteLine("* Вариант #24                                                         *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2              *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные     *");
            Console.WriteLine("* данные, вычисляет результат по формуле (1-x)/(2+y) и печатает его   *");
            Console.WriteLine("* на экране.                                                          *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            double x, y;
            Console.Write("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            var result = ds.Calculate(x, y);
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("***********************************************************************");

            Console.WriteLine($"Выражение (1-x)/(2+y), при значениях x = {x} и y = {y} равно: {result}"); 
        }
    }
}
