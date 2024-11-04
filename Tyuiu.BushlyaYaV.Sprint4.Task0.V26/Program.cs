
using Tyuiu.BushlyaYaV.Sprint4.Task0.V26.Lib;
namespace Tyuiu.BushlyaYaV.Sprint4.Task0.V26

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            Console.Title = "Спринт #4 │ Выполнил: Бушля Я. В. │ ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Вынолнил: Бушля Ярослав Владимирович | ИСТНб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму всех нечетных значений в массиве                        *");
            Console.WriteLine("* и вывести это значение                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" {9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Сумма нечетных элементов в массиве - " + ds.GetSumOddArrEl(array));
            Console.ReadKey();
        }
    }
}
