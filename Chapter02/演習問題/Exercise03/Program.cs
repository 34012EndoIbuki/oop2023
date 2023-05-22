using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(@"data\sales.csv");
            
            Console.WriteLine("**売上集計**");
            Console.WriteLine("1:店舗別売上");
            Console.WriteLine("2:商品カテゴリー別売上");
            Console.Write("1 or 2:");
            int select = int.Parse(Console.ReadLine());

            if (select == 1) {
                IDictionary<string, int> amountPerStore = sales.GetPerStoreSales();
                foreach (KeyValuePair<string, int> obj in amountPerStore) {
                    Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
                }
            } else {
                IDictionary<string, int> amountPerCategory = sales.GetPerCategorySales();
                foreach (KeyValuePair<string, int> obj in amountPerCategory) {
                    Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
                }
            }
        }
    }
}
