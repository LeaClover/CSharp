// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
// элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

using GBhomework8;

namespace GBhomework8
{
    class Task54
    {
        public void GetTask54()
        {
            Text task54 = new();
            Methods method = new();
            task54.task1main();
            int [,] matrix = new int [3,4];
            method.FillMatrix(matrix);
            method.PrintMatrix(matrix);
            method.GetMatrixSort(matrix);
            task54.task1result();
            method.PrintMatrix(matrix);
        }
    }
}