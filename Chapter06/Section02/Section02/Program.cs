using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {

            //タイマーインスタンス生成
            Stopwatch sw = new Stopwatch();
            //タイマースタート
            sw.Start();

            //ToArray　配列
            var numbers = Enumerable.Range(1, 1000000).ToArray();
            WriteTotalMemory("配列各保護");

            //偶数だけ取り出す
            var evennumbers = numbers.Where(x => x % 2 == 0).ToArray();
            WriteTotalMemory("偶数抽出後");

            /*foreach(var item in evennumbers) {
                Console.Write(item + " ");
            }*/

            //取り出した偶数の平均値を求める
            var evenave = evennumbers.Average();
            WriteTotalMemory("偶数抽出後平均");

            //実行時間表示
            Console.WriteLine("実行時間 = {0}", sw.Elapsed.ToString(@"ss\fffff"));
        }

        static void WriteTotalMemory(string header) {
            var totalMemory = GC.GetTotalMemory(true) / 1024.0 / 1024.0;
            Console.WriteLine($"{header}: {totalMemory:0.000 MB}");
        }








        
    }
}
