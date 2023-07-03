using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            //各曜日を0～6で格納している
            //foreach (var dayofweak in Enum.GetValues(typeof(DayOfWeek)));

            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            DayOfWeek dow = dateTime.DayOfWeek; //曜日
            var s1 = dateTime.ToString("d");
            var s2 = dateTime.ToString("t");
            Console.WriteLine(s1 + " " + s2);

            var s3 = dateTime.ToString("D");
            var s4 = dateTime.ToString("HH時mm分ss秒");
            Console.WriteLine(s3 + " " + s4);

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            Console.WriteLine(dateTime.ToString("ggyy年 M月 d日 (ddd曜日)", culture));

            Console.WriteLine(" "); //改行

            //簡潔ver
            Console.WriteLine("{0} {1}", dateTime.ToString("d"),dateTime.ToString("t"));
            Console.WriteLine("{0} {1}", dateTime.ToString("D"), dateTime.ToString("HH時mm分ss秒"));
            Console.WriteLine(dateTime.ToString("ggyy年 M月 d日 (ddd曜日)", culture));

        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            DayOfWeek dow = dateTime.DayOfWeek; //曜日
            var weekcode = new Dictionary<String, String>() {
                {"日","Sunday" },{"月","Monday" },{"火","Tuesday" },{"水","Wednesday" },
                {"木","Thursday" },{"金","Friday" },{"土","Saturday" },
            };
            int suu = 0;
            String item;
            String nextdow;
            Console.Write("何曜日(1文字):");
            nextdow = Console.ReadLine();
            foreach(var code in weekcode) {
                if(nextdow == code.Key) {
                    item = code.Value;
                    foreach (var dayofweak in Enum.GetValues(typeof(DayOfWeek))) {
                        string color = Enum.GetName(typeof(DayOfWeek), dayofweak);
                        //Console.WriteLine("{0},{1}", color, (int)dayofweak);
                        if (item == color) {
                            suu = (int)dayofweak;
                            Console.WriteLine(suu);

                        }
                    }
                }
            }
            Console.WriteLine(suu);


            /*foreach (var dayofweak in Enum.GetValues(typeof(DayOfWeek))) {
                string color = Enum.GetName(typeof(DayOfWeek), dayofweak);
                //Console.WriteLine("{0},{1}", color, (int)dayofweak);
                if (item == color) {
                    suu = (int)dayofweak;
                    Console.WriteLine(suu);

                }

            }*/


            /*var days = (int)dow - int.Parse(nextdow);
            if(days <= 0) {
                days += 7;
            }
            Console.WriteLine(days);*/
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
            
        }
    }
}
