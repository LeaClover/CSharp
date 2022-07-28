// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using GBhomework9;

namespace GBhomework9
{
    class Task66
    {
        public void GetTask66()
        {
            Text task66 = new();
            Methods method = new();
            task66.task2main1();
            int m = Convert.ToInt32(Console.ReadLine());
            task66.task2main2();
            int n = Convert.ToInt32(Console.ReadLine());
            method.GetSumNumbersInOrder(m, n);
        }
    }
}