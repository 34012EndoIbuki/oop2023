using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {
            Product karinto = new Product(123, "かりんとう", 180);   //インスタンス
            Console.WriteLine("税込み価格:"+karinto.GetPriceIncludingTax());
            Product daifuku = new Product(235, "大福もち", 160);   //インスタンス
            Console.WriteLine("税込み価格:" + daifuku.GetPriceIncludingTax());

        }
    }
}
