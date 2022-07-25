using GBhomework8;

namespace GBhomework8
{
    class Methods
    {
        Text result = new();
        
        public int[,] FillMatrix(int[,] matrixFill)
        {
            for (int i = 0; i < matrixFill.GetLength(0); i++)
            {
                for (int j = 0; j < matrixFill.GetLength(1); j++)
                {
                    matrixFill[i, j] = new Random().Next(1, 10);
                }
            }
            return matrixFill;
        }

       public int[,] PrintMatrix(int[,] matrixPrint)
        {
            for (int i = 0; i < matrixPrint.GetLength(0); i++)
            {
                for (int j = 0; j < matrixPrint.GetLength(1); j++)
                {
                    Console.Write(matrixPrint[i, j] + " | ");
                }
                Console.WriteLine();
            }
            return matrixPrint;
        }
        
        public int[,] GetMatrixSort(int[,] matrixSort)
        {
            for (int i = 0; i < matrixSort.GetLength(0); i++)
            {
                int min = matrixSort[i, 0];
                for (int j = 0; j < matrixSort.GetLength(1); j++)
                {
                    int minPos = j;
                    for (int jSecond = j + 1; jSecond < matrixSort.GetLength(1); jSecond++)
                    {
                        if (matrixSort[i,minPos] > matrixSort[i, jSecond])
                        {
                            minPos = jSecond;
                        }
                    }
                    int change = matrixSort[i,minPos];
                    matrixSort[i,minPos] = matrixSort[i,j];
                    matrixSort[i,j] = change;
                }
            }
            return matrixSort;
        }

        public int [] GetSumRow(int [,] matrixMain, int [] arraySum)
        {
            for (int i = 0; i < matrixMain.GetLength(0); i++)
            {
                int resultSumRow = 0;
                for (int j = 0; j < matrixMain.GetLength(1); j++)
                {
                    resultSumRow = resultSumRow + matrixMain[i,j];
                }
                arraySum[i] = resultSumRow;
            }
            return arraySum;
        }

        public int GetMinSum(int [] array)
        {
            int min = array[0];
            int minPos = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    min = array[i];
                    minPos = i;
                }
            }
            return minPos;
        }

        public int[,] GetProductMatrix(int[,] matrixFirst, int [,] matrixSecond)
        {
            for (int i = 0; i < matrixFirst.GetLength(0); i++)
            {
                for (int j = 0; j < matrixFirst.GetLength(1); j++)
                {
                    matrixFirst[i,j] = matrixFirst[i,j] * matrixSecond[i,j];
                }
            }
            return matrixFirst;
        }
    }
}