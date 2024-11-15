using Tyuiu.ZainetdinovRA.Sprint1.Task6.V2.Lib;
namespace Tyuiu.ZainetdinovRA.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ExpressionValid()
        {
            DataService ds = new DataService();
            string input = "Hello World!";
            bool wait = true;
            bool result = ds.CheckHello(input);
            Assert.AreEqual(wait, result);
        }
    }
}
