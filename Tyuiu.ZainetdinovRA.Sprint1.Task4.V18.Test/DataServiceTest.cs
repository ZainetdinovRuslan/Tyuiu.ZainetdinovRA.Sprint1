using Tyuiu.ZainetdinovRA.Sprint1.Task4.V18.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            var result = ds.Calculate(x,y);

            Assert.AreEqual(result, 0.083);
        }
    }
}