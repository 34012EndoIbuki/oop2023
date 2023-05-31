using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            Console.Write("数字文字列:");
            string n1 = Console.ReadLine();

            Console.WriteLine(int.TryParse(n1, out int n2));
            Console.WriteLine(string.Format("{0:#,0}", n2));



        }
    }
}
