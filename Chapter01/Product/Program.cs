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

            #region 演習1

            //DateTime date = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("今日の10日後は" + daysAfter10 + "日です");

            //10日前を求める
            DateTime daysBefore10 = date.AddDays(-10);
            Console.WriteLine("今日の10日前は" + daysBefore10 + "日です");

            /* 
             * Console.WriteLine("10日後" + date.AddDays(10).Year + "年" + date.AddDays(10).Month + "月" + date.AddDays(10).Day + "日")
             */
            #endregion

            #region 演習2
            DateTime now = DateTime.Now;
            int day = now.Day;
            int month = now.Month;
            int year = now.Year;


            Console.WriteLine("誕生日を入力");
            Console.Write("西暦:");
            int bdYear = int.Parse(Console.ReadLine());
            Console.Write("月:");
            int bdMonth = int.Parse(Console.ReadLine());
            Console.Write("日:");
            int bdDay = int.Parse(Console.ReadLine());

            DateTime mybd = new DateTime(bdYear, bdMonth,bdDay);
            DateTime nowDate = new DateTime(year, month, day);


            TimeSpan total = nowDate - mybd;

            Console.WriteLine("あなたは生まれてから今日で"　+ total.Days + "日目です");
            #endregion

            #region 演習3
            DayOfWeek dow = mybd.DayOfWeek;
            //Console.WriteLine(dow);

            switch (dow)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("あなたは日曜日生まれです");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("あなたは月曜日生まれです");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("あなたは火曜日生まれです");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("あなたは水曜日生まれです");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("あなたは木曜日生まれです");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("あなたは金曜日生まれです");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("あなたは土曜日生まれです");
                   
                    break;
            }

            /* 内山先生
            String[] DayOfWeeks = { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日", };

            Console.WriteLine("あなたは生まれてから今日で{0}日目です。", total.Days);
            Console.WriteLine("あなたは{0}生まれです。",DayOfWeeks);
            */
            #endregion




        }
    }
}
