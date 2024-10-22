using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        { 
            double result = Convert.ToDouble(value) / 1000; 
            return Math.Round(result, 3);
        }
    }
}

