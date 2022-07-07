using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jadval_zarb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write(i*j);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
