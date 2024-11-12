
using Tyuiu.BushlyaYaV.Sprint4.Task7.V25.Lib;

namespace Tyuiu.BushlyaYaV.Sprint4.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 3;
            int sum = 0;

            int[,] mtrx = new int[n, m];

            string str = "348561792486";

            DataService ds = new DataService();
            Console.Title = "Спринт #4 │ Выполнил: Бушля Я. В. │ ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #25                                                            *");
            Console.WriteLine("* Вынолнил: Бушля Ярослав Владимирович | ИСТНб-24-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"348561792486\". Преобразуйте ее    *");
            Console.WriteLine("* в матрицу 4 на 3 и подсчитайте сумму четных чисел.                     *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);
            Console.WriteLine("Сумма четных элементов = " + res);
            Console.ReadKey();



        }
    }
}
