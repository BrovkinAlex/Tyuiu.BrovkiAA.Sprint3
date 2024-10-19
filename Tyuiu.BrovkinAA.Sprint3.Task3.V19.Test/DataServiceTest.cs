using Tyuiu.BrovkinAA.Sprint3.Task3.V19.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "sxxrrg x vfrx";
            string res = ds.ReplaceCharOnNum(str, 'x', '2');
            string wait = "s22rrg 2 vfr2";

            Assert.AreEqual(wait, res);
        }
    }
}