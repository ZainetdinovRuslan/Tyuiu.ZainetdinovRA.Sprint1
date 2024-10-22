using Tyuiu.ZainetdinovRA.Sprint1.Task1.V24.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var wait = 0;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}