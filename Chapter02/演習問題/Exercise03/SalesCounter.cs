using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class SalesCounter {



        private IEnumerable<Sale> _sales;
        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);

        }

        //店舗別の売り上げを求める処理
        public IDictionary<string, int> GetPerStoreSales() {
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            foreach(var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) {
                    dict[sale.ShopName] += sale.Amount; //店名が存在する（売上換算）
                } else {
                    dict[sale.ShopName] = sale.Amount;  //店名が存在しない（新規格納）
                }                                        
            }
            return dict;
        }

        public IDictionary<string, int> GetPerCategorySales() {
            SortedDictionary<string, int> dic = new SortedDictionary<string, int>();
            foreach (var sale in _sales) {
                if (dic.ContainsKey(sale.ProductCategory)) {
                    dic[sale.ProductCategory] += sale.Amount; //カテゴリが存在する（売上換算）
                } else {
                    dic[sale.ProductCategory] = sale.Amount;  //カテゴリが存在しない（新規格納）
                }
            }
            return dic;
        }

        //売上データを読み込み、saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string filePath) {   //データ読みこみ
            var sales = new List<Sale>();    //売上データ格納
            var lines = File.ReadAllLines(filePath);   //ファイルからすべてのデータを読み込む

            foreach (var line in lines) {    //すべての行から一行ずつ取り出す
                var items = line.Split(',');   //,区切りでitemsにデータを格納　項目別に分ける
                var sale = new Sale {  //saleインスタンスを生成
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
