using Tyuiu.BrovkinAA.Sprint3.Task4.V9.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);
            double wait = 1.708;

            Assert.AreEqual(wait, res);
        }
    }
}