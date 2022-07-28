// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29 (ошибка - ответ 9)


using GBhomework9;

namespace GBhomework9
{
    class Task68
    {
        public void GetTask68()
        {
            Text task68 = new();
            Methods method = new();
            task68.task3main1();
            int m = Convert.ToInt32(Console.ReadLine());
            task68.task3main2();
            int n = Convert.ToInt32(Console.ReadLine());
            task68.task3result(m,n);
            
        }
    }
}