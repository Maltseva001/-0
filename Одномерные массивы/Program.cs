using System;

namespace Одномерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var array = new int[17];
            int countNegative=0;
            int sumNegative=0;

            // Заполняем массив рандомом
            for (var i = 0; i < 17; i++)
            {
                array[i] = rand.Next(-100, 100);

                // Находим кол-во и сумму модулей отриц. элементов
                if (array[i] < 0)
                {
                    sumNegative += Math.Abs(array[i]);
                    countNegative++;
                }
            }

            // Находим ср. арифм. найденной выше суммы
            int avgNegative = avgNegative = sumNegative / countNegative;
            int sumTotal=0;

            for (var i = 0; i < 17; i++)
            {
                if (array[i] > avgNegative) sumTotal += array[i];;
            }

            Console.WriteLine("Сумма: " + sumTotal.ToString());
            Console.ReadKey();
        }
    }
}
