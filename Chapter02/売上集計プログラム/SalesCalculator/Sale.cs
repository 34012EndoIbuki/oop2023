﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売上クラス
    class Sale {
        //店舗名
        public string ShapName { get; set; }
        //商品カテゴリー
        public string ProductCategory { get; set; }
        //売上高
        public int Amount { get; set; }
    }
}
