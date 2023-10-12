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
            var orderyear = Library.Books.GroupBy(b => b.PublishedYear)
                .OrderByDescending(b => b.Key);
            foreach(var g in orderyear) {
                Console.WriteLine($"{ g.Key}");
                foreach(var book in g.OrderByDescending(b => b.Price)) {
                    Console.WriteLine($"{book}");
                }
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books.Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                    book => book.CategoryId,
                    category => category.Id,
                    (book,category) => category.Name).Distinct();
            foreach(var name in names) {
                Console.WriteLine(name);
                
            }

        }

        private static void Exercise1_6() {
            var groups = Library.Categories
                            .GroupJoin(Library.Books,
                                c => c.Id,
                                b => b.CategoryId,
                                (c, books) => new { Category = c.Name, Books = books });
            foreach(var group in groups.OrderBy( g => g.Category)) {
                Console.WriteLine($"{group.Category}");
                foreach(var book in group.Books) {
                    Console.WriteLine($"    {book.Title}({book.PublishedYear}年)");
                }
            }
        }

        private static void Exercise1_7() {
            var groups = Library.Books
                .Join(Library.Categories,
                    book => book.CategoryId,
                    category => category.Id,
                    (book, category) => category.Name).Distinct();
            foreach (var group in groups.Where(g => g.)) {
                Console.WriteLine($"{group}");
            }

        }

        private static void Exercise1_8() {
            var groups = Library.Categories
                            .GroupJoin(Library.Books,
                                c => c.Id,
                                b => b.CategoryId,
                                (c, books) => new { Category = c.Name, Books = books })
                            .Where(g => g.Books.Count() >= 4);
            foreach (var group in groups.OrderBy(g => g.Category)) {
                Console.WriteLine(group.Category);
                
            }
        }
    }
}
