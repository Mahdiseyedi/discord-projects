using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adad_chapkon_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string init_num = Console.ReadLine();

            List<string> numbers = new List<string>();
            for (int i = 0; i < init_num.Length; i++)
            {
                numbers.Add(Convert.ToString(init_num[i]));
            }
            foreach (var item in numbers)
            {
                string chap = " ";
                for (int j = 0; j < Convert.ToInt32(item); j++)
                {
                    chap += item;
                }
                Console.WriteLine(item + ": " + chap);

            }
            Console.ReadKey();
        }
    }
}
