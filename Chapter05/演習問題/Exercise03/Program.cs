using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            string str = "Jackdaws love my big sphinx of quartz";

            var contains = str.Contains(' ');
            Console.WriteLine(contains);
        }
    }
}
