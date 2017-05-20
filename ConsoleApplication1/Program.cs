using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int k = 0;
            int number = 0;

            for (int i = 0; i < args.Length; i++)
            {
                int chislo = int.Parse(args[i]);
                for (int j = 1; j < args.Length; j++)
                {
                    int chislo2 = int.Parse(args[j]);
                    if (chislo == chislo2) { k++;  }
                }
                if (k > n) { n = k; number = chislo; }
                k = 0;
            }
            Console.WriteLine("The most frequent number is " + number + " With an occurence of " + n);
            return;
        }
    }
}
