using Tyuiu.TaranDA.Sprint1.Task3.V5.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите масштаб карты (км в одном см):");
            double mapScale = double.Parse(Console.ReadLine(),System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Введите расстояние между точками на карте (см):");
            double distanceBetweenPoints = double.Parse(Console.ReadLine(),System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Расстояние между населёнными пунктами: " + $"{ds.DistanceLength(mapScale, distanceBetweenPoints):F3} км");

            Console.ReadKey();
        }
    }
}
