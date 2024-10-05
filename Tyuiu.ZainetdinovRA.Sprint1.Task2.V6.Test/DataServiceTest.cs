using Tyuiu.ZainetdinovRA.Sprint1.Task2.V6.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            
            DataService ds = new DataService();
            int x = 2;
            var result = ds.ConvertMToKm(x);
            Assert.AreEqual(0.002, result);
        }
    }
}