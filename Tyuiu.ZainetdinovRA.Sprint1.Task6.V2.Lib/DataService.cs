using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            bool str = value.Contains("Hello");
            return str;
        }
    }
}
