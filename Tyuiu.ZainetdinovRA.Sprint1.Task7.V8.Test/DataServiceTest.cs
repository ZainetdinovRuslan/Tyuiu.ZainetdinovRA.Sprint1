using Tyuiu.ZainetdinovRA.Sprint1.Task7.V8.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint1.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 0;
            var wait = 3.296;
            var result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}
