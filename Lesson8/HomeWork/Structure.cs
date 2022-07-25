using GBhomework8;

namespace GBhomework8
{
    class Structure
    {
        public int choice;

        Program program = new();

        public void GetChoice(int n)
        {
            try
            {
                if (n == 1)
                {
                    Task54 task54 = new();
                    task54.GetTask54();
                }
                else
                {
                    if (n == 2)
                    {
                        Task56 task56 = new();
                        task56.GetTask56();
                    }
                    else
                    {
                        if (n == 3)
                        {
                            Task58 task58 = new();
                            task58.GetTask58();
                        }
                    }
                }
                if (n != 2 && n != 1 && n!=3)
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