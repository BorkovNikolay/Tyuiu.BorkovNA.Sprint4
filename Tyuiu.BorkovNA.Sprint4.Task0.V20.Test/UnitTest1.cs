using Tyuiu.BorkovNA.Sprint4.Task0.V20.Lib;

namespace Tyuiu.BorkovNA.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                DataService ds = new();
                int[] ints = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
                Assert.AreEqual(24576, ds.GetMultEvenArrEl(ints));
        }
    }
}