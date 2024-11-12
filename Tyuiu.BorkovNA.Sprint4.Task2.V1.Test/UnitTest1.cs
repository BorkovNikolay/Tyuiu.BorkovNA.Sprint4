using Tyuiu.BorkovNA.Sprint4.Task2.V1.Lib;

namespace Tyuiu.BorkovNA.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[] ints = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };
            Assert.AreEqual(1769472, ds.Calculate(ints));
        }
    }
}