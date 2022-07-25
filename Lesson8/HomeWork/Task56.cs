// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

using GBhomework8;

namespace GBhomework8
{
    class Task56
    {
        public void GetTask56()
        {
            Text task56 = new();
            Methods method = new();
            task56.task2main();
            int [,] matrix = new int [5,4];
            method.FillMatrix(matrix);
            method.PrintMatrix(matrix);
            int [] array = new int [matrix.GetLength(0)];
            method.GetSumRow(matrix, array);
            task56.task2result1(array);
            task56.task2result2(array, method.GetMinSum(array));
        }
    }
}