using GBhomework9;

namespace GBhomework9
{
    class Methods
    {
        public void GetNmbersInOrderMN(int m, int n)
        {
            Text text64 = new();
            if (m > n)
            {
                text64.task1result1(m, n);
                int min = n;
                int max = m;
                while (min <= max)
                {
                    Console.Write(min + " | ");
                    min++;
                }
            }
            else
            {
                text64.task1result2(m, n);
                int min = m;
                int max = n;
                while (min <= max)
                {
                    Console.Write(min + " | ");
                    min++;
                }
            }
        }

        public void GetSumNumbersInOrder(int m, int n)
        {
            Text text66 = new();
            int sum = 0;
            if (m > n)
            {
                int min = n;
                int max = m;

                while (min <= max)
                {
                    sum = sum + min;
                    min++;
                }
                text66.task2result1(m, n, sum);
            }
            else
            {
                int min = m;
                int max = n;
                while (min <= max)
                {
                    sum = sum + min;
                    min++;
                }
                text66.task2result2(m, n, sum);
            }
        }

        public int GetAkkermanFunction(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (n == 0)
            {
                return GetAkkermanFunction(m - 1, 1);
            }
            else
            {
                return GetAkkermanFunction(m - 1, GetAkkermanFunction(m, n - 1));
            }
        }

    }
}