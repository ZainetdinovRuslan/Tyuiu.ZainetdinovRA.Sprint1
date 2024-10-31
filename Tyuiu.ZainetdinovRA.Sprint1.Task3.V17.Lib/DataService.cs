using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task3.V17.Lib
{
    
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            double variable = (Math.Round(((number - Convert.ToInt32(number)) + 1), 3) * 1000);
            bool result = variable.ToString().Contains('0');
            return true ? result : !result;
        }
    }
}

