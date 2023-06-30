using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            //コンストラクタの呼び出し
            var abbrs = new Abbreviations();

            //addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            //7.2.1
            Console.WriteLine(abbrs.Count);
            Console.WriteLine();

            //7.2.2

            //NPT削除
            //abbrs.Remove("NPT");

            //7.2.3(Removeの呼び出し)
            if (abbrs.Remove("NPT")) {
                Console.WriteLine(abbrs.Count);
            } else if(!abbrs.Remove("NPT")) {
                Console.WriteLine("削除不可");
            }
            Console.WriteLine();

            //7.2.4(IEnumerable<>を実装したのでLinqが使える)
            Console.WriteLine("３文字の省略語だけを抽出");
            foreach(var item in abbrs.Where(x => x.Key.Length == 3)){
                Console.WriteLine("・{0} = {1}", item.Key, item.Value);
            }

        }
    }
}
