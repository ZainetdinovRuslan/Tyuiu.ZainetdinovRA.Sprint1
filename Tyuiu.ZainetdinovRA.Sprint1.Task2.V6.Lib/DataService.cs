using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            double x = value;
            return Math.Round(x / 1000, 3);
        }
    }
}
