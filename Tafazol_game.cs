using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tafazol_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string init_num = Console.ReadLine();

            int game(string num)
            {
                var num_1 = Convert.ToInt32(num[0]);
                var num_2 = Convert.ToInt32(num[1]);
                if (num_1 >= num_2)
                {
                    return (num_1 - num_2);
                }
                else
                {
                    return (num_2 - num_1);
                }
            }

            Console.WriteLine(game(init_num));

            Console.ReadKey();
        }
    }
}
