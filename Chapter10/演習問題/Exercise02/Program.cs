using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Pickup3DigitNumber("sample.txt");
        }

        private static void Pickup3DigitNumber(string file) {
            foreach (var lines in File.ReadLines(file)) {
                var buffer = lines.Split(' ');
                foreach (var line in buffer) {
                    var match = Regex.IsMatch(line, @"^\d{3,}$");
                    if (match == true) {
                        Console.WriteLine(line);
                    }
                }

            }
        }
    }
}
