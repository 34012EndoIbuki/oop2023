﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
           
            SalesCounter sales = new SalesCounter(@"data\sales.csv");
            IDictionary<string,int> amountPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<string,int> obj in amountPerStore) {
                Console.WriteLine("{0} {1:C}", obj.Key, obj.Value);
            }
        }
    }
}
