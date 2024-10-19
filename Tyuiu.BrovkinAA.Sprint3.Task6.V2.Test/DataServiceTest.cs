using Tyuiu.BrovkinAA.Sprint3.Task6.V2.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int res = ds.GetSumTheDivisors(12, 18);
            int wait = 29;

            Assert.AreEqual(wait, res);
        }
    }
}