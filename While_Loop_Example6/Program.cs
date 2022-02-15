using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Example6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number less than 12 ");
            int n = int.Parse(Console.ReadLine());
            int factoriel = 1;
            while (true)
            {
                factoriel *= n;
                n--;
                if (n <= 1)
                {
                    break;
                }
            }
            Console.WriteLine("n!="+factoriel);
        }
    }
}
