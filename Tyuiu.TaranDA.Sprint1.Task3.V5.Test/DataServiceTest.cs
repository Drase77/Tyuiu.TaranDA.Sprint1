using Tyuiu.TaranDA.Sprint1.Task3.V5.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 6;
            var res = ds.DistanceLength(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
