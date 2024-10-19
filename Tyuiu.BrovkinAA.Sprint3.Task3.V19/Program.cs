using Tyuiu.BrovkinAA.Sprint3.Task3.V19.Lib;
namespace Tyuiu.BrovkinAA.Sprint3.Task3.V19
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
            Console.WriteLine("* Тема: Оператор цикла do-while                                               *");
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #19                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Используя цикл foreach заменить буквы x на цифру 2 в строке                 *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            Console.Write("Введите строку:\t");
            string str = Console.ReadLine();

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            str = ds.ReplaceCharOnNum(str, 'x', '2');
            Console.WriteLine("Новая строка:\t" + str);

            Console.ReadKey();
        }
    }
}
