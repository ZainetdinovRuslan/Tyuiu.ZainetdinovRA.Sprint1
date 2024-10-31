using Tyuiu.ZainetdinovRA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double variable = 12.12032;
            var result = ds.ZeroCheck(variable);
            var wait = true;
            Assert.AreEqual(wait, result);
        }
    }
}