using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var ym = new YearMonth(2023, 5);
            var c21 = ym.Is21Century;
            var ymNextMonth = ym.AddOneMonth();

            Console.WriteLine(c21);
            Console.WriteLine(ym);
            Console.WriteLine(ymNextMonth);

            // 4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            // 4.2.2
            Console.WriteLine("\n- 4.2.2 ---");
            Exercise2_2(ymCollection);
            Console.WriteLine("\n- 4.2.4 ---");

            // 4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("\n- 4.2.5 ---");


            // 4.2.5
            Exercise2_5(ymCollection);
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach(var n in ymCollection) {
                Console.WriteLine(n);
            }
        }

        // 4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var n in yms)
                if (n.Is21Century == true) {
                    return n;
                }
            return null;   
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            if(ymCollection != null) {
                Console.WriteLine(ymCollection);
            } else {
                Console.WriteLine
            }
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            
        }
    }
}
