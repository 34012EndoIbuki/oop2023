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
                Console.Write("*");
            }
                
        }
    }
}
