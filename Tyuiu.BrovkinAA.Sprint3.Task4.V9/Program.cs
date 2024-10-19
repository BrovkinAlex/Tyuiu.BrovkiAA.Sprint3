using Tyuiu.BrovkinAA.Sprint3.Task4.V9.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 3 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #3                                                                   *");
            Console.WriteLine("* Тема: Оператор цикла for                                                    *");
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #9                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                            *");
            Console.WriteLine("* вычислить значение функции y=x/(cos(x) - x). При х = 0 пропустить значение. *");
            Console.WriteLine("* Полученные значения перемножать.                                            *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.WriteLine("             5   /       x        \\");
            Console.WriteLine("       р =   П   | -------------- |");
            Console.WriteLine("            x=-5 \\  cos(x) - x    /");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            double res = ds.Calculate(-5, 5);
            Console.WriteLine("Значение p = " + res);

            Console.ReadKey();
        }
    }
}
