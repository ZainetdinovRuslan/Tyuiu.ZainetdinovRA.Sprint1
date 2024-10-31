using Tyuiu.ZainetdinovRA.Sprint1.Task4.V18.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            var wait = 2;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}