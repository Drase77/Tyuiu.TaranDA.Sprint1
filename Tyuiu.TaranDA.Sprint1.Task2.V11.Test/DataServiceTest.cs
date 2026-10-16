using Tyuiu.TaranDA.Sprint1.Task2.V11.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 30;
            var res = ds.ConvertHoursMinutesToSeconds(x, y);
            Assert.AreEqual(9000, res);
        }
    }
}
