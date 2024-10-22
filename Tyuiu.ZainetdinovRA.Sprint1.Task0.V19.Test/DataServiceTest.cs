using Tyuiu.ZainetdinovRA.Sprint1.Task0.V19.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var result = ds.Calculate();
            var wait = 10;
            Assert.AreEqual(wait, result);
        }
    }
}