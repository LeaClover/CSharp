using GBhomework9;

namespace GBhomework9
{
    class Text
    {
        public void maintext()
        {
            Console.Clear();
            Console.WriteLine("Выберите задачу, решение которой надо показать!");
            Console.WriteLine("-- введите цифру *1* для первой задачи (Задача 64)");
            Console.WriteLine("-- введите цифру *2* для второй задачи (Задача 66)");
            Console.WriteLine("-- введите цифру *3* для третьей задачи (Задача 68)");
        }

        public void task1main1()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали первую задачу (Задача 66). Числа в промежутке от M до N!");
            Console.Write("Введите число m: ");
            Console.WriteLine();
        }

        public void task1main2()
        {
            Console.Write("Введите число n: ");
            Console.WriteLine();
        }
        public void task1result1(int M, int N)
        {
            Console.Clear();
            Console.Write($"Числа по порядку от {N} до {M}: ");
            Console.WriteLine();
        }

        public void task1result2(int M, int N)
        {
            Console.Clear();
            Console.Write($"Числа по порядку от {M} до {N}: ");
            Console.WriteLine();
        }

        public void task2main1()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали вторую задачу (Задача 66). Сумма чисел от M до N!");
            Console.Write("Введите число m: ");
            Console.WriteLine();
        }

        public void task2main2()
        {
            Console.Clear();
            Console.Write("Введите число n: ");
            Console.WriteLine();
        }

        public void task2result1(int M, int N, int sumMN)
        {
            Console.Clear();
            Methods method = new();
            Console.Write($"Сумма чисел от {N} до {M} равна: {sumMN}");
            Console.WriteLine();
        }
        public void task2result2(int M, int N, int sumMN)
        {
            Console.Clear();
            Methods method = new();
            Console.Write($"Сумма чисел от {M} до {N} равна: {sumMN}");
            Console.WriteLine();
        }

        public void task3main1()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали третью задачу (Задача 68). Функция Аккермана!");
            Console.Write("Введите число m: ");
            Console.WriteLine();
        }

        public void task3main2()
        {
            Console.Clear();
            Console.Write("Введите число n: ");
            Console.WriteLine();
        }

        public void task3result(int m, int n)
        {
            Methods method = new();
            Console.WriteLine($"Функци Аккермана при A({m}, {n}) равна {method.GetAkkermanFunction(m, n)} ");
        }

        public void mistake()
        {
            Console.WriteLine("Вы ввели недопустимое значение!!!");
            Console.WriteLine("Повторите попытку!");
        }

    }
}