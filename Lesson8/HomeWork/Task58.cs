// Задайте две матрицы. Напишите программу, которая выведет матрицу 
// произведения элементов двух предыдущих матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

using GBhomework8;

namespace GBhomework8
{
    class Task58
    {
        public void GetTask58()
        {
            Text task58 = new();
            Methods method = new();
            task58.task3main();
            int [,] matrixFirst = new int [3,4];
            int [,] matrixSecond = new int [3,4];
            method.FillMatrix(matrixFirst);
            method.FillMatrix(matrixSecond);
            method.PrintMatrix(matrixFirst);
            Console.WriteLine();
            method.PrintMatrix(matrixSecond);
            task58.task3result();
            method.PrintMatrix(method.GetProductMatrix(matrixFirst, matrixSecond));
        }
    }
}