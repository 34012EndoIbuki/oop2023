using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            /*var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            //DayOfWeek dow = dateTime.DayOfWeek; //曜日

            var weekcode = new Dictionary<String, String>() {
                {"日","Sunday" },{"月","Monday" },{"火","Tuesday" },{"水","Wednesday" },
                {"木","Thursday" },{"金","Friday" },{"土","Saturday" },
            };
            int suu = 0;
            String item;
            String nextdow;
            Console.Write("何曜日(1文字):");
            nextdow = Console.ReadLine();
            foreach (var code in weekcode) {
                if (nextdow == code.Key) {
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
            Console.WriteLine(suu);*/


            var date = DateTime.Now;
            DayOfWeek[] weeks = {DayOfWeek.Sunday,DayOfWeek.Monday,DayOfWeek.Tuesday,DayOfWeek.Wednesday,
                                DayOfWeek.Thursday,DayOfWeek.Friday,DayOfWeek.Saturday};
            for (int i = 0; i < 7; i++) {
                Console.WriteLine(date.ToString("yyyy年M月d日(ddd)") + " の次の週の " + NextDay(date,weeks[i]).ToString("ddd曜日は yyyy年M月d日"));
            }
        }

        //基準日は日曜日
        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days <= 6) {
                days += 7;
            }
            return date.AddDays(days);
        }
    }
}
