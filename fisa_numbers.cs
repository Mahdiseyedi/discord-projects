using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fisa_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_1 = (int)Convert.ToDouble(Console.ReadLine());
            int num_2 = (int)Convert.ToDouble(Console.ReadLine());
            int num_3 = (int)Convert.ToDouble(Console.ReadLine());

            if (Math.Pow(num_1, 2) == Math.Pow(num_2, 2)+Math.Pow(num_3, 2))
            {
                Console.WriteLine("Yes");
            }
            else if(Math.Pow(num_2, 2) == Math.Pow(num_1, 2) + Math.Pow(num_3, 2))
            {
                Console.WriteLine("Yes");
            }
            else if(Math.Pow(num_3, 2) == Math.Pow(num_2, 2) + Math.Pow(num_1, 2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
