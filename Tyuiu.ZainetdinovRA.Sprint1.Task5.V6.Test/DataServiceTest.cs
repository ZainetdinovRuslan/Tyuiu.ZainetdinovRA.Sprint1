using Tyuiu.ZainetdinovRA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint1.Task5.V6.Test
{
    [TestClass]
     public class DataServiceTest
     {
         [TestMethod]
         public void ValidExpression()
         {
            DataService ds = new DataService();
            int k = 65;
            var result = ds.Calculate(k);
            Assert.AreEqual(2, result);

        }
    }
}
