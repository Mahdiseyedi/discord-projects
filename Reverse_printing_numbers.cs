using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_printing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int init_numb = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();

            numbers.Add(init_numb);
            while (init_numb != 0)
            {
                init_numb = Convert.ToInt32(Console.ReadLine());  
                numbers.Add(init_numb);
            }
            numbers.Reverse();
            numbers.Remove(0);
            Console.WriteLine("*******************");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
