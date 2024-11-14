using Tyuiu.BorkovNA.Sprint4.Task7.V15.Lib;
namespace Tyuiu.BorkovNA.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(4, ds.Calculate(3, 3, "246813579"));
        }
    }
}