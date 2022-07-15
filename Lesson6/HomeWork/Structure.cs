using GBhomework6;

namespace GBhomework6
{
    class Structure
    {
        public int choice;
        
        public int count;

        public void GetChoice(int n)
        {
            try
            {
                if (n == 1)
                {
                    Text task41 = new();
                    task41.task1main();
                    Methods method = new();
                    method.str = Console.ReadLine();
                    method.GetArrayFromString(method.str);
                    method.PrintArray(method.GetArrayFromString(method.str));
                    count = method.GetCount(method.GetArrayFromString(method.str)); 
                    Console.WriteLine();
                    task41.task1result(count);            
                }
                else
                {
                    if (n == 2)
                    {
                        Text task43 = new();
                        task43.task2main();
                    }
                }
                if (n != 2 && n != 1)
                {
                    Text mistake = new();
                    mistake.mistake();
                    choice = Convert.ToInt32(Console.ReadLine());
                    GetChoice(choice);
                }
            }
            catch (System.Exception)
            {
                Text mistake = new();
                mistake.mistake();
                choice = Convert.ToInt32(Console.ReadLine());
                GetChoice(choice);
            }
        }

    }
}