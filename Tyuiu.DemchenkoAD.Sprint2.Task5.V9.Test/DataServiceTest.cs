using Tyuiu.DemchenkoAD.Sprint2.Task5.V9.Lib;
namespace Tyuiu.DemchenkoAD.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 06;
            int m = 28;
            string wait = "29.06";
            var res = ds.FindDateOfNextDay(m, n);
            Assert.AreEqual(wait, res);
        }
    }
}