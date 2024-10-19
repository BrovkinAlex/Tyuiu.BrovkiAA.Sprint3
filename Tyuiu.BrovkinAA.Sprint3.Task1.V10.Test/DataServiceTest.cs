using Tyuiu.BrovkinAA.Sprint3.Task1.V10.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSumSeries()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(5, 1, 17);
            double wait = 0.168;

            Assert.AreEqual(wait, res);
        }
    }
}