using Tyuiu.ZainetdinovRA.Sprint1.Task7.V8.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            double wait = 1.517;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait, res);
        }
    }
}