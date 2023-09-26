using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {

            /*foreach(var book in GetBooks()) {
                Console.WriteLine($"{book.Title}{book.Auther.Name}");
            }*/

            /*using (var db = new BooksDbContext()) {

                db.Database.Log = sql => { Debug.Write(sql); };

                var count = db.Books.Count();
                Console.WriteLine(count);
            }



            Console.Write("データを挿入しました。続けるにはEnterキーを押してください");
            Console.ReadLine();
            Console.WriteLine();*/

            //InsertBooks();
            //DisplayAllBooks();
            //AddAuthors();
            //AddBooks();
            //UpdateBook();
            //DeleteBook();

            Console.WriteLine("# 1.1");
            //Exercise1_1();

            Console.WriteLine();
            Console.WriteLine("# 1.2");
            Exercise1_2();

            Console.WriteLine();
            Console.WriteLine("# 1.3");
            Exercise1_3();

            Console.WriteLine();
            Console.WriteLine("# 1.4");
            Exercise1_4();

            Console.WriteLine();
            Console.WriteLine("# 1.5");
            Exercise1_5();

            Console.ReadLine();
        }

        private static void Exercise1_1() {
            using (var db = new BooksDbContext()) {
                var ExeAut1 = new Auther {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛",
                };
                db.Authers.Add(ExeAut1);
                var ExeAut2 = new Auther {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成",
                };
                db.Authers.Add(ExeAut2);
                db.SaveChanges();   //データベースを更新
            }

            using (var db = new BooksDbContext()) {
                var Exeaut1 = db.Authers.Single(a => a.Name == "与謝野晶子");
                var ExeBoo1 = new book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Auther = Exeaut1,
                };
                db.Books.Add(ExeBoo1);

                var Exeaut2 = db.Authers.Single(a => a.Name == "川端康成");
                var ExeBoo2 = new book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Auther = Exeaut2,
                };
                db.Books.Add(ExeBoo2);
            
                var Exeaut3 = db.Authers.Single(a => a.Name == "菊池寛");
                var ExeBoo3 = new book {
                    Title = "真珠婦人",
                    PublishedYear = 2002,
                    Auther = Exeaut3,
                };
                db.Books.Add(ExeBoo3);
            
                var Exeaut4 = db.Authers.Single(a => a.Name == "宮沢賢治");
                var ExeBoo4 = new book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Auther = Exeaut4,
                };
                db.Books.Add(ExeBoo4);
                db.SaveChanges();   //データベースを更新
            }
        }

        private static void Exercise1_2() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.Include(nameof(Auther)).ToList();
                foreach (var book in books) {
                    Console.WriteLine($"著者:{book.Auther.Name} タイトル:{book.Title} 発行年:{book.PublishedYear}");
                }
            }
        }
        private static void Exercise1_3() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.Where(a => a.Title.Length == db.Books.Max(b => b.Title.Length));

                foreach (var book in books) {
                    Console.WriteLine($"タイトル:{book.Title}");
                }
            }
        }
        private static void Exercise1_4() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderBy(a => a.PublishedYear).Take(3).ToList();
                foreach(var book in books) {
                    Console.WriteLine($"著者:{book.Auther.Name} タイトル:{book.Title}");
                }
            }
        }

        private static void Exercise1_5() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.Include(nameof(Auther)).OrderByDescending(a => a.Auther.Birthday).ToList();
                foreach (var book in books) {
                    Console.WriteLine($"著者:{book.Auther.Name} タイトル:{book.Title} 発行年:{book.PublishedYear}");
                }
            }
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

        /*static IEnumerable<book> ExeGetBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books.Where(book => book.Auther.Name.StartsWith(""))
            }
        }*/
    }
}
