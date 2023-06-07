using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);

        }

        private static void Exercise1_1(int[] numbers) {
            var Maxnum = numbers.Max(x => x);
            Console.WriteLine(Maxnum);
            Console.WriteLine();
        }

        private static void Exercise1_2(int[] numbers) {
            //未完成
            var num = numbers.Length;
            num -= 2;
            var item = numbers.Where(x => Array.IndexOf(numbers, x) >= num).Take(3);
            foreach (var back in item) {
                Console.WriteLine(back);
            }
            Console.WriteLine();

            //先生
            //Skipで要素数-2 子分の要素をSkipしている
            var skip = numbers.Length - 2;
            foreach(var n in numbers.Skip(skip)) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            var tostr = numbers.Select(x => x.ToString());
            foreach(var str in tostr) {
                Console.WriteLine(str);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var tosmall = numbers.OrderBy(x => x).Take(3);
            foreach (var small in tosmall) {
                Console.WriteLine(small);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            
        }
    }
}
