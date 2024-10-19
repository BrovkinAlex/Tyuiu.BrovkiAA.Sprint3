using Tyuiu.BrovkinAA.Sprint3.Task0.V18.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int x = 1;
            int startV = 1, stopV = 6;
            double res = ds.GetMultiplySeries(x, startV, stopV);
            double wait= 914700.940;

            Assert.AreEqual(wait, res);
        }
    }
}