using Tyuiu.TaranDA.Sprint1.Task1.V14.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double z = 3.0;
            var res = ds.Calculate(x, y, z);
            Assert.AreEqual(13.0 / 15.0, res, 1e-10);
        }
    }
}
