using Tyuiu.DemchenkoAD.Sprint2.Task4.V12.Lib;
namespace Tyuiu.DemchenkoAD.Sprint2.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
       

        [TestMethod]
        public void ValidCondition2()
        {

            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 46.234;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 6.593;
            Assert.AreEqual(wait, res);
        }
    }
}