using System.Text;
using Tyuiu.ZainetdinovRA.Sprint1.Task2.V6.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task2.V6
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
            Console.WriteLine("* Тема: Арифметические операторы в С#                                 *");
            Console.WriteLine("* Задание #2                                                          *");
            Console.WriteLine("* Вариант #6                                                          *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2              *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные     *");
            Console.WriteLine("* данные, выполняет указанные расчёты и печатает результат на экране. *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            int x;
            Console.Write("Введите значение в метрах: ");
            
            x = Convert.ToInt32(Console.ReadLine()); 

            var result = ds.ConvertMToKm(x);
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine($"{x} метров равно {result} киллометрам");
        }
    }
}
