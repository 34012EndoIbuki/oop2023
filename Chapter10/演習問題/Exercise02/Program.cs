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
                var buffer = lines.Split(' ');  //Splitは使わなくてもできるので使わないほうがいい
                foreach (var line in buffer) {
                    var match = Regex.IsMatch(line, @"^\d{3,}$");
                    if (match == true) {
                        Console.WriteLine(line);
                    }
                }

            }
        }
        
        //先生ver
        /*private static void Pickup3DigitNumber(string file) {
            foreach (var lines in File.ReadLines(file)) {
                var matches = Regex.Matches(lines, @"\b\d{3,}\b");
                foreach (Match m in matches) {
                    Console.WriteLine(m.Value);
                }
            }
        }*/
    }
}
