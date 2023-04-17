using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411_1 {
    class Program {
        static void Main(string[] args) {

            //            int mil,ftho,tho,fhan,han,ften,ten,fiv,one;


            Console.Write("金額:");
            int aom = int.Parse(Console.ReadLine());
            Console.Write("支払い:");
            int pay = int.Parse(Console.ReadLine());

            int cha = pay - aom;    //お釣り

            string[] moneyname = { "一万円札", "五千円札", "千円札", "五百円玉", "百円玉", "五十円玉", "十円玉", "五円玉", "一円玉" };

            int[] name = {10000,5000,1000,500,100,50,10,5,1};

            Console.WriteLine("お釣り:" + cha);

            for (int i = 0; i < moneyname.Length; i++)
            {
                Console.WriteLine(moneyname[i] + ":{0}", cha / name[i] + "枚");
                cha %= name[i];
            }



/*          int cha = pay - aom;
            int money = cha; 

                        mil = cha / 10000;
                        　cha %= 10000;
                        ftho = cha / 5000;
                        　cha %= 5000;
                        tho = cha / 1000;
                        　cha %= 1000;
                        fhan = cha / 500;
                        　cha %= 500;
                        han = cha / 100;
                        　cha %= 100;
                        ften = cha / 50;
                       　 cha %= 50;
                        ten = cha / 10;
                        　cha %= 10;
                        fiv = cha / 5;
                       　 cha %= 5;
                        one = cha / 1;
                       　 cha %= 1;
                        if (cha != 0) {
                            Console.WriteLine("エラー");
                        }
            

            Console.WriteLine("お釣り:" + money+"円");
            Console.WriteLine("一万円札:"+mil+ "枚");
            Console.WriteLine("五千円札:"+ftho+ "枚");
            Console.WriteLine("千円札:"+tho+ "枚");
            Console.WriteLine("五百円玉:"+fhan+ "枚");
            Console.WriteLine("百円玉:"+han+ "枚");
            Console.WriteLine("五十円玉:"+ften+ "枚");
            Console.WriteLine("十円玉:"+ten+ "枚");
            Console.WriteLine("五円玉:"+fiv+ "枚");
            Console.WriteLine("一円玉:"+one+ "枚");
*/

        }
    }
}
