using GBhomework9;

namespace GBhomework9
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
                    Task64 task64 = new();
                    task64.GetTask64();
                }
                else
                {
                    if (n == 2)
                    {
                        Task66 task66 = new();
                        task66.GetTask66();
                    }
                    else
                    {
                        if (n == 3)
                        {
                            Task68 task58 = new();
                            task58.GetTask68();
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