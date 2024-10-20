using Tyuiu.BrovkinAA.Sprint3.Task7.V30.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { -15.6, -12.35, -10.72, -8.88, -2.16, 3.25, 6.64, 10.3, 16.17, 28.1, 38.41 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}