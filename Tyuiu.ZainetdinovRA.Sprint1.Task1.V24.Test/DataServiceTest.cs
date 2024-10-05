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
            double x = 1.0;
            double y = 2.0;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(0, result);
        }
    }
}