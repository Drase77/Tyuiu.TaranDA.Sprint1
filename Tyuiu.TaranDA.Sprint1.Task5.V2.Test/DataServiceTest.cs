using Tyuiu.TaranDA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double fahrenheit = 68;
            int expected = 20;

            int result = ds.FahrenheitToСelsius(fahrenheit);

            Assert.AreEqual(expected, result);
        }
    }
}