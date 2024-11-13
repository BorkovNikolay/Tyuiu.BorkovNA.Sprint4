using Tyuiu.BorkovNA.Sprint4.Task5.V15.Lib;

namespace Tyuiu.BorkovNA.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[,] input = { { 3, 6, 4, 6, 6 }, { 7, 5, 5, 5, 8 }, { 8, 3, 6, 7, 7 }, { 5, 3, 8, 4, 5 }, { 3, 7, 4, 3, 8 } };
            Assert.AreEqual(68, ds.Calculate(input));

        }
    }
}