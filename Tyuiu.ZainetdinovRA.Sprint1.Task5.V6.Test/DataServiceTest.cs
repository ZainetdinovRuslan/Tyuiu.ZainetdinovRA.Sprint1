using NuGet.Frameworks;
using Tyuiu.ZainetdinovRA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            int k = rnd.Next(1, 366) % 7;
            var wait = k;
            var result = ds.Calculate(k);
            Assert.AreEqual(wait, result);
        }
    }
}