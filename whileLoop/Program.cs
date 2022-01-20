using System;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            bool ısPrime = true;

            for (int i = 1; i <=number; i++)
            {
                for (int j = 2; j < i-1; j++)
                {
                    if (i % j == 0)
                    {
                        ısPrime = false;
                        break;
                    }
                }
                if (ısPrime)
                {
                    Console.WriteLine(i);
                }
                ısPrime = true;
            }
        }
    }
}
