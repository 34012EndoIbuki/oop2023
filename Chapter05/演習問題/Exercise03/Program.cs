using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            int count = 0;
            char str = ' ';
            foreach(char n in text) {
                if(n == str) {
                    count++;
                }
            }
            
            Console.WriteLine("空白の数:" + count);
        }

        private static void Exercise3_2(string text) {
            string replace = "small";
            int index;
            string inter;
            string result;
            if (text.Contains("big")) {
                index = text.IndexOf("big");
                inter = text.Remove(index, 3);
                result = inter.Insert(index, replace);
                Console.WriteLine(result);
            }
        }

        private static void Exercise3_3(string text) {
            
        }

        private static void Exercise3_4(string text) {
            
        }

        private static void Exercise3_5(string text) {
            
        }
    }
}
