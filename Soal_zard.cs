using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal_zard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            string mid_word = "";
            for (int i = 0; i < num; i++)
            {
                mid_word += "o";
            }
            Console.WriteLine("W" + mid_word + "w!");
            Console.ReadKey();
        }
    }
}
