//using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4, };

            Console.WriteLine(numbers.Average());
            Console.WriteLine();

            var books = Books.GetBooks();

            #region 500円以上の本のタイトルをすべて出力
            var fif = (books.Where(x => x.Price >= 500).OrderByDescending(x => x.Price));

            foreach(var price in fif) {
                Console.WriteLine("{0}:{1}円",price.Title,price.Price);
            }
            Console.WriteLine();
            #endregion


            #region Priceの昇順でTitleに物語がつく作品を表示
            var Mono = books.Where(x => x.Title.Contains("物語")).OrderByDescending(x => x.Price);
            foreach (var price in Mono) {
                Console.WriteLine("{0}:{1}円", price.Title, price.Price);
            }
            Console.WriteLine();
            #endregion


            #region 物語がつく作品の平均ページ数を表示
            var MonoAvg = books.Where(x => x.Title.Contains("物語")).Average(x => x.Pages);
            Console.WriteLine("物語シリーズの平均価格:{0}ページ", MonoAvg);
            Console.WriteLine();
            #endregion


            #region タイトルが長い順に表示
            var LongTitle= books.OrderByDescending(x => x.Title.Length);
            foreach (var Long in LongTitle) {
                Console.WriteLine("{0}:{1}円", Long.Title,Long.Price);
            }
            Console.WriteLine();
            #endregion

        }
    }
}
