using System.Text;
using Tyuiu.ZainetdinovRA.Sprint1.Task0.V19.Lib;





namespace Tyuiu.ZainetdinovRA.Sprint1.Task0.V19
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
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                    *");
            Console.WriteLine("* Задание #0                                                          *");
            Console.WriteLine("* Вариант #19                                                         *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2              *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 4/2*5/(3+2)*5 и     *");
            Console.WriteLine("* печатает результат на экране.                                       *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* 4/2*5/(3+2)*5                                                       *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                          *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine(ds.Calculate());
        }
    }
}
