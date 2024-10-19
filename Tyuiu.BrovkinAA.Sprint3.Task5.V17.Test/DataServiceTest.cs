using Tyuiu.BrovkinAA.Sprint3.Task5.V17.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(2, 1, 3, 1, 12);
            double wait = 38.124;

            Assert.AreEqual(wait, res);
        }
    }
}