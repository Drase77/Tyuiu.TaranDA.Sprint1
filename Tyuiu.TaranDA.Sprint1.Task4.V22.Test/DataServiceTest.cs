using Tyuiu.TaranDA.Sprint1.Task4.V22.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 2;
            double expected = 0.054;

            double result = ds.Calculate(x, y);

            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}