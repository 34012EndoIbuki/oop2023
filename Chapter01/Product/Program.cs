using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {

            #region P26のサンプルプログラム
            //インスタンスの生成
            //Product karinto = new Product(123, "かりんとう", 180);   //インスタンス
            //Product daifuku = new Product(235, "大福もち", 160);   //インスタンス

            //Console.WriteLine("税込み価格:" + karinto.GetPriceIncludingTax());
            //Console.WriteLine("税込み価格:" + daifuku.GetPriceIncludingTax());
            #endregion

            //DateTime date = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("今日の10日後は" + daysAfter10 + "日です");

            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);
            Console.WriteLine("今日の10日前は" + daysBefore10 + "日です");

        }
    }
}
