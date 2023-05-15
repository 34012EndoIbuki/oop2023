﻿using System;
using System.Collections.Generic;
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
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount; //店名が存在する（売上換算）
                else
                    dict[sale.ShopName] = sale.Amount;  //店名が存在しない（新規格納）            
            }
            return dict;
        }

    }
}
