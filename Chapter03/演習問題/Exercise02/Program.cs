using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise2_1(names);
            Console.WriteLine("--------------");
            Exercise2_2(names);
            Console.WriteLine("--------------");
            Exercise2_3(names);
            Console.WriteLine("--------------");
            Exercise2_4(names);


        }

        private static void Exercise2_1(List<string> names) {
            Console.Write("都市名:");
            var line = Console.ReadLine();
            do {
                var number = names.FindIndex(n => n == line);
                Console.WriteLine(number);
                Console.Write("都市名(空白で終了):");
                line = Console.ReadLine();
            } while (line != " ");
            
            
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(n => n.Contains('o'));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var lambda = names.Where(s => s.Contains("o")).Select(s => s);
            //var selected = names.Where(s => s.Contains('o').ToArry(); 先生
            foreach(var s in lambda) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var name = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            //var selected = names.Where(s => s.StartWith('B')).Select(s => new{s,s.Length}).ToArray();
            
            foreach (var s in name) {
                Console.WriteLine(s);
            }
            /*foreach (var item in selected) {
                Console.WriteLine("{0}", "{1}", item.s, item.Length);
            }*/
        }
    }
}
