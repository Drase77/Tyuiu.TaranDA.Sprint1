using Tyuiu.TaranDA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите температуру в градусах Фаренгейта: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int celsius = ds.FahrenheitToСelsius(fahrenheit);
            Console.WriteLine($"{celsius} °C");

            Console.ReadKey();
        }
    }
}