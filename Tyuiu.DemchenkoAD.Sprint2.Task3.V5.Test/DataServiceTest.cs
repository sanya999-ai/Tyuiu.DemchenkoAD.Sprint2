using Tyuiu.DemchenkoAD.Sprint2.Task3.V5.Lib;
namespace Tyuiu.DemchenkoAD.Sprint2.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(-7, res);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(-0.083, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            double x = -1;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.1, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();

            double x = -10;
            double res = ds.Calculate(x);
            Assert.AreEqual(-1100.01, res);
        }
    }
}