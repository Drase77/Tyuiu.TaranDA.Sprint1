using Tyuiu.TaranDA.Sprint1.Task7.V27.Lib;

namespace Tyuiu.TaranDA.Sprint1.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("        2       2                                                          ");
            Console.WriteLine("    cosx  + siny      xy - 12                                              ");                                     
            Console.WriteLine("z = ------------- - -----------                                            ");                                       
            Console.WriteLine("      siny + 1       15 + cosx                                             ");
            Console.WriteLine("                                                                           ");

            double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
