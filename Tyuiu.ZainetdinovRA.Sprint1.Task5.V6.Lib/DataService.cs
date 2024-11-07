using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            k = k % 7;
            switch (k)
            {
                case 0:Console.WriteLine("Воскресенье");
                    break;
                case 1:Console.WriteLine("Понедельник");
                    break;
                case 2:Console.WriteLine("Вторник");
                    break;
                case 3:Console.WriteLine("Среда");
                    break;
                case 4:Console.WriteLine("Четверг");
                    break;
                case 5:Console.WriteLine("Пятница");
                    break;
                case 6:Console.WriteLine("Суббота");
                    break;
            }
            return k;
        }
    }
}
