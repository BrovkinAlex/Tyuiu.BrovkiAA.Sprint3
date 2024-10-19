using Tyuiu.BrovkinAA.Sprint3.Task2.V7.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(1, 10);
            double wait = 81.083;

            Assert.AreEqual(wait, res);
        }
    }
}