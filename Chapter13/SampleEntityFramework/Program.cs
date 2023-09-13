﻿using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //InsertBooks();
            //DisplayAllBooks();
            //AddAuthors();
            //AddBooks();
            //UpdateBook();
            //DeleteBook();

            foreach(var book in GetBooks()) {
                Console.WriteLine($"{book.Title}{book.Auther.Name}");
            }

            Console.Write("データを挿入しました。続けるにはEnterキーを押してください");
            Console.ReadLine();
            Console.WriteLine();
        }
        // List 13-5
        //Idは自動
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Auther = new Auther {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);
                var book2 = new book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Auther = new Auther {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();   //データベースを更新
                //Console.WriteLine($"{book1.Id}{book2.Id}"); //Id確認

                //List 13-7
                

            }
        }


        //List 13-7
        static IEnumerable<book> GetBooks() {
            using(var db = new BooksDbContext()) {
                return db.Books.Where(book => book.PublishedYear > 1900)
                    .Include(nameof(Auther)).ToList();
            }
        }
        
        //List 13-8
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach(var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }
            Console.ReadLine();
        }

        //List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Auther {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子",
                };
                db.Authers.Add(author1);
                var author2 = new Auther {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治",
                };
                db.Authers.Add(author2);
                db.SaveChanges();
            }
        }

        //List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authers.Single(a => a.Name == "与謝野晶子");
                var book1 = new book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Auther = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authers.Single(a => a.Name == "宮沢賢治");
                var book2 = new book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Auther = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }

        //List 13-11
        private static void UpdateBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        //List 13-12
        private static void DeleteBook() {
            using(var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
    }
}
