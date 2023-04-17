using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            Console.Write("いくつ:");
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {
                for (int h = 0; h < i; h++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < num - i*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
//            Console.ReadKey();
        }
    }
}
