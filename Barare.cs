using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barare_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int k = Convert.ToInt32(Console.ReadLine());

            if ( k % 2 == 0)
            {
                Console.WriteLine("Bala Barare");
            }
            else
            {
                Console.WriteLine("Payin Barare");
            }
            Console.ReadKey();
        }
    }
}
