using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class SalesCounter {



        private List<Sale> _sales;
        //コンストラクタ
        public SalesCounter(List<Sale> sales) {
            _sales = sales;

        }

        //店舗別の売り上げを求める処理
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) {
                    dict[sale.ShopName] += sale.Amount; //店名が存在する（売上換算）
                } else {
                    dict[sale.ShopName] = sale.Amount;  //店名が存在しない（新規格納）
                }                                        
            }
            return dict;
        }

        //売上データを読み込み、saleオブジェクトのリストを返す
        public static List<Sale> ReadSales(string filePath) {   //データ読みこみ
            List<Sale> sales = new List<Sale>();    //売上データ格納
            string[] lines = File.ReadAllLines(filePath);   //ファイルからすべてのデータを読み込む

            foreach (string line in lines) {    //すべての行から一行ずつ取り出す
                string[] items = line.Split(',');   //,区切りでitemsにデータを格納　項目別に分ける
                Sale sale = new Sale {  //saleインスタンスを生成
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);    //saleインスタンスをコレクションに追加
            }


            return sales;

        }

    }
}
