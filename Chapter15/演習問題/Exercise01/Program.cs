﻿using System;
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
            var minyear = Library.Books.Min(b => b.PublishedYear);
            var maxyear = Library.Books.Max(b => b.PublishedYear);
            for (int i = minyear; minyear <= maxyear; i++) {

            }
        }

        private static void Exercise1_4() {
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
