using Tyuiu.BorkovNA.Sprint4.Task3.V23.Lib; 

namespace Tyuiu.BorkovNA.Sprint4.Task3.V23.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[,] input = { { 7, 5, 5, 6, 7 }, { 8, 7, 8, 4, 3 }, { 5, 6, 7, 8, 3 }, { 4, 2, 3, 6, 4 }, { 5, 2, 4, 2, 3 } };
            Assert.AreEqual(13, ds.Calculate(input));
        }
    }
}