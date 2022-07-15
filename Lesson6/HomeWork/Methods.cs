using GBhomework6;

namespace GBhomework6
{
    class Methods
    {
        public string? str;
        public int [] GetArrayFromString(string str)
        {
            int [] arrayS = Array.ConvertAll(str.Split(' '), int.Parse);
            return arrayS;
        }

        public int [] PrintArray (int [] array)
        {
            for(int i = 0; i<array.Length; i++)
            {
                Console.Write(array[i] + " | ");
            }
            return array;
        }

        public int GetCount (int [] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i]>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}