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
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите значение X в метрах, которые вы хотите преобразовать в км:");
            x = (int)Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"{x} метров в км будет:" + ds.ConvertMToKm(x) + "км.");
        }
    }
}
