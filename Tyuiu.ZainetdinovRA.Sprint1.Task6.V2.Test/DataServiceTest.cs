using Tyuiu.ZainetdinovRA.Sprint1.Task6.V2.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string text = "Hello privet!";
            var result = ds.CheckHello(text);
            bool wait = true;
            Assert.AreEqual(wait, result);
        }
    }
}