using Tyuiu.DemchenkoAD.Sprint2.Task7.V12.Lib;
namespace Tyuiu.DemchenkoAD.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double y = 0;
            double x = 0.1;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}