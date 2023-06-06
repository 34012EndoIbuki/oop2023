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

            var books = Books.GetBooks();

            var fif = (books.Where(x => x.Price >= 500).OrderByDescending(x => x.Price));

            foreach(var price in fif) {
                Console.WriteLine("{0}:{1}円",price.Title,price.Price);
            }

            var mono = books.Where(x => x.Title.Contains("物語").OrderByDescending(x => x.Price));

        }
    }
}
