using GBhomework8;

namespace GBhomework8
{
    class Text
    {
        public void maintext()
        {
            Console.Clear();
            Console.WriteLine("Выберите задачу, решение которой надо показать!");
            Console.WriteLine("-- введите цифру *1* для первой задачи (Задача 54)");
            Console.WriteLine("-- введите цифру *2* для второй задачи (Задача 56)");
            Console.WriteLine("-- введите цифру *3* для третьей задачи (Задача 58)");
        }

        public void task1main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали первую задачу (Задача 54)!");
            Console.WriteLine("Сгенерирован случайный массив размера 3х4: ");
        }

        public void task1result()
        {
            Console.WriteLine("Отсортировали массив выше по строчкам " +
                                "от минимального элемента к максимальному");
        }

        public void task2main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали вторую задачу (Задача 56)!");
            Console.WriteLine("Сгенерирован массив размера 5х4: ");
        }

        public void task2result1(int [] arraySumRow)
        {
            for(int i = 0; i < arraySumRow.Length; i++)
            {
                Console.WriteLine($" Сумма элементов {i+1} строки равна {arraySumRow[i]}");
            }
        }

        public void task2result2(int [] array, int index)
        {
            Console.WriteLine($"Минимальный сумма элементов находится на {index+1} строке и равна {array[index]}");
        }

        public void task3main()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали третью задачу (Задача 58)!");
            Console.WriteLine("Сгенерированы два массива размера 3х4: ");
        }

        public void task3result()
        {
            Console.WriteLine($"Получено прооизведение двух массивов: ");
        }

        public void mistake()
        {
            Console.WriteLine("Вы ввели недопустимое значение!!!");
            Console.WriteLine("Повторите попытку!");
        }

    }
}