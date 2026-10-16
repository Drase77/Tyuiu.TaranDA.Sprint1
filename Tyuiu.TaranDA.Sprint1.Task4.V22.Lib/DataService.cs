using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TaranDA.Sprint1.Task4.V22.Lib
{
    public class DataService : ISprint1Task4V22
    {
        public double Calculate(double x, double y)
        {
            double result = Math.Sqrt(x * y) /(1 + Math.Pow(x + 2 * y, 2));
            return Math.Round(result, 3);
        }
    }
}