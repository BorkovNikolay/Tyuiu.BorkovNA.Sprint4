using Tyuiu.BorkovNA.Sprint4.Task1.V7.Lib;

namespace Tyuiu.BorkovNA.Sprint4.Task1.V7.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[] ints = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
            Assert.AreEqual(24, ds.GetMultOddArrEl(ints));
        }
    }
}