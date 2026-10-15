using Tyuiu.TaranDA.Sprint1.Task2.V11.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите количество часов (целое число):");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество минут (целое число):");
            int minutes = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(
                "Количество секунд: {0}",
                ds.ConvertHoursMinutesToSeconds(hours, minutes));

            Console.ReadLine();

        }
    }
}
