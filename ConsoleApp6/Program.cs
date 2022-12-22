using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number : ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second Number : ");
            int second = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = first; i <= second; i++)
            {
                for (int g = 1; g < i; g++)
                {
                    if (i%g==0)
                    {
                        sum = g + sum;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                    sum = 0;
                }
                else
                    sum = 0;
            }
            
            
        }
        

        
    }
}
