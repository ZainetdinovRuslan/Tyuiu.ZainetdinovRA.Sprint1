using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int n = k % 7;
            switch (n)
            {
                case 0:
                    Console.Write("Воскресенье");
                    n = 7;
                    break;
                case 1:
                    Console.Write("Понедельник");
                    break;
                case 2:
                    Console.Write("Вторник");
                    break;
                case 3:
                    Console.Write("Среда");
                    break;
                case 4:
                    Console.Write("Четверг");
                    break;
                case 5:
                    Console.Write("Пятница");
                    break;
                case 6:
                    Console.Write("Суббота");
                    break;
            }
            return n;
        }
    }
}
