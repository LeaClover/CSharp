// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

using GBhomework9;

namespace GBhomework9
{
    class Task64
    {
        public void GetTask64()
        {
            Text task64 = new();
            Methods method = new();
            task64.task1main1();
            int m = Convert.ToInt32(Console.ReadLine());
            task64.task1main2();
            int n = Convert.ToInt32(Console.ReadLine());
            method.GetNmbersInOrderMN(m, n);
        }
    }
}