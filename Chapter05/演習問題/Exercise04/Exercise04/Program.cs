#define NonArray
//define StringArray

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {

            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            var replace = line.Replace("Novelist", "作家");
            replace = replace.Replace("BestWork", "代表作");
            replace = replace.Replace("Born", "誕生日");

            var word = replace.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var words in word) {
                Console.WriteLine(words);
            }



            string[] lines = {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
            };


        }
    }
}
