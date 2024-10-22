using Tyuiu.ZainetdinovRA.Sprint1.Task2.V6.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 132103;
            var result = ds.ConvertMToKm(x);
            var wait = 132.103;
            Assert.AreEqual(wait, result);
        }
    }
}