﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            var name = books.Where(n => n.Title.Contains("ワンダフル・C#ライフ"));
            foreach(var mono in name) {
                Console.WriteLine("{0}円:{1}ページ", mono.Price, mono.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            var name = books.Count(n => n.Title.Contains("C#"));
            Console.WriteLine(name);
        }

        private static void Exercise2_3(List<Book> books) {
            var name = books.Where(n => n.Title.Contains("C#")).Average(n => n.Pages);
            Console.WriteLine("{0}ページ", name);
        }

        private static void Exercise2_4(List<Book> books) {
            var name = books.FirstOrDefault(n => n.Price > 4000);
            if (name != null) {
                Console.WriteLine(name.Title);
            }
        }

        private static void Exercise2_5(List<Book> books) {
            var name = books.Where(n => n.Price < 4000).Max(n => n.Price);
            Console.WriteLine(name);
            
        }

        private static void Exercise2_6(List<Book> books) {

        }

        private static void Exercise2_7(List<Book> books) {

        }
    }

    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}
