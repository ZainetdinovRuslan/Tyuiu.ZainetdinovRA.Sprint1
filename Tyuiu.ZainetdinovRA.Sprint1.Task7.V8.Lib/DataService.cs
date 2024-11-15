using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task7.V8.Lib
{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(x * Math.Log(x) + y / (Math.Cos(x) - x/3), 3);
        }
    }
}
