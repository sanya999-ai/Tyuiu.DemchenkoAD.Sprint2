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
            Assert.AreEqual("1.12", ds.FindDateOfNextDay(30, 11));
        }
    }
}