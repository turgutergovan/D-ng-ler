using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=6;
            
           
            
            for(int i=0; i <=a; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("i is 5");
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("end of for");
        }
        
    }
}
