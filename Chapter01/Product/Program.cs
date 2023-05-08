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

            #region 
            //DateTime date = new DateTime(2023, 5, 8);
            DateTime datee = DateTime.Today;

            //10日後を求める
            DateTime daysAfter10 = datee.AddDays(10);
            Console.WriteLine("今日の10日後は" + daysAfter10 + "日です");

            //10日前を求める
            DateTime daysBefore10 = datee.AddDays(-10);
            Console.WriteLine("今日の10日前は" + daysBefore10 + "日です");

            /* 
             * Console.WriteLine("10日後" + date.AddDays(10).Year + "年" + date.AddDays(10).Month + "月" + date.AddDays(10).Day + "日")
             */
            #endregion

            DateTime now = DateTime.Now;
            int date = now.Day;
            int month = now.Month;
            int year = now.Year;

            Console.WriteLine("誕生日を入力");
            Console.WriteLine("西暦:");
            String bdYear = Console.ReadLine();
            Console.WriteLine("月:");
            String bdMonth = Console.ReadLine();
            Console.WriteLine("日:");
            String bdDay = Console.ReadLine();





            Console.WriteLine("あなたは生まれてから今日で"　+ "日目です");

        }
    }
}
