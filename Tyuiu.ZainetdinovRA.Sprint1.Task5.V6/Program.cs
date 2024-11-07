using System.Text;
using Tyuiu.ZainetdinovRA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task5.V6
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
            Console.WriteLine("* Задание #5                                                          *");
            Console.WriteLine("* Вариант #6                                                          *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2              *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение  *");
            Console.WriteLine("* 1,2,...,7 в зависимости от того, на какой день недели (понедельник, *");
            Console.WriteLine("* вторник,..., воскресенье) приходится k-й день невисокосного года,   *");
            Console.WriteLine("* в котором 1 января – понедельник.                                   *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            Random rnd = new Random();
            int k = rnd.Next(1, 366);

            Console.WriteLine(k);
            var result = ds.Calculate(k);
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                          *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine($"{result}");
        }
    }
}
