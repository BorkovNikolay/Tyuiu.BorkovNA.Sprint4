using Tyuiu.BorkovNA.Sprint4.Task6.V22.Lib ;

namespace Tyuiu.BorkovNA.Sprint4.Task6.V22.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string[] input = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            Assert.AreEqual(4, ds.Calculate(input));
        }
    }
}