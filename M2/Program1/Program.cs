using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Input: ");
            int n = int.Parse(ReadLine());
            List<int> numbers = new List<int>(); //for output

            for(int i = 2; i <= n; i++)
            {
                bool prime = true;
            
                for (int j = 2; j*j <= i; j++) //since I couldn't use Math.Sqrt(i) used j^2 instead
                {
                    if (i % j == 0) //prime check

                    {
                        prime = false;                    
                        break;
                    }
                }
                if(prime == true)
                {
                    numbers.Add(i);
                }
            }
            foreach (int i in numbers)
            {
                Write(i + " ");
            }
        }
    }
}
