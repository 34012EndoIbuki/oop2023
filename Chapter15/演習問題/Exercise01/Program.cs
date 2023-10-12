using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var maxprice = Library.Books.Max(b => b.Price);
            var bookinfo = Library.Books.Where(b => b.Price == maxprice);
            foreach(var info in bookinfo) {
                Console.WriteLine(info);
                //Console.WriteLine("Title = {0}:CategoryId = {1}:Price = {2}:PublishedYear = {3}");
            }
        }

        private static void Exercise1_3() {
            /*var minyear = Library.Books.Min(b => b.PublishedYear);
            var maxyear = Library.Books.Max(b => b.PublishedYear);
            var count = 0;
            //Console.WriteLine(maxyear);
            //Console.WriteLine(minyear);
            for (int i = minyear; i <= maxyear; i++) {
                *//*count = Library.Books.Count(b => b.PublishedYear == i);
                Console.WriteLine(i + "年:"+count + "籍");*//*
                Console.WriteLine(i + $"年:{Library.Books.Count(b => b.PublishedYear == i)}");
            }*/

            var groups = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(g => g.Key);
            foreach(var g in groups) {
                Console.WriteLine("{0}年:{1}籍", g.Key, $"{Library.Books.Count(b => b.PublishedYear == g.Key)}");
                //Console.WriteLine("{0}年:{1}籍", g.Key, g.Count());
            }

        }

        private static void Exercise1_4() {
            var orderyear = Library.Books.GroupBy(b => b.PublishedYear).OrderByDescending(b => b.Key);
            foreach(var g in orderyear) {
                Console.WriteLine($"{ g.Key}");
                foreach(var book in g.OrderByDescending(b => b.Price)) {
                    Console.WriteLine($"{book}");
                }
            }
        }

        private static void Exercise1_5() {
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
