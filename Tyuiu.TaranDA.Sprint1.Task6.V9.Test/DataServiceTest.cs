using Tyuiu.TaranDA.Sprint1.Task6.V9.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "abc*def";
            DataService ds = new DataService();
            string res = ds.MoveLetterToStart(strTest);
            string wait = "cab fde";
            Assert.AreEqual(wait, res);
        }
    }
}
