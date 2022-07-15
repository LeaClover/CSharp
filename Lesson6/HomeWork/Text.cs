using GBhomework6;

namespace GBhomework6
{
    class Text
    {
        public void maintext()
        {
            Console.Clear();
            Console.WriteLine("Выберите задачу, решение которой надо показать!");
            Console.WriteLine("-- введите цифру *1* для первой задачи (Задача 41)");
            Console.WriteLine("-- введите цифру *2* для второй задачи (Задача 43)");
        }

        public void task1main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали первую задачу (Задача 41)!");
            Console.WriteLine("Введите несколько положительных и несколько отрицательных чисел: ");
        }

        public void task1result()
        {
            Console.WriteLine($"Вы ввели M чисел больше 0!");
        }

        public void task2main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали вторую задачу (Задача 43)!");
            Console.WriteLine("Программа поиска точки пересечения двух прямых, заданных уравнениями: ");
            Console.WriteLine("y = k1 * x + b1");
            Console.WriteLine("y = k2 * x + b2");
        }

        public void task2result()
        {

        }

        public void mistake()
        {
            Console.WriteLine("Вы ввели недопустимое значение!!!");
            Console.WriteLine("Повторите попытку!");
        }

    }
}