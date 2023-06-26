using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {

            var prefOfficeDict = new Dictionary<string, List<CityInfo>>();
            string pref, city;
            int population;

            Console.WriteLine("都市の登録");
            while (true) {
                Console.Write("県名：");
                pref = Console.ReadLine();
                if (pref == "999") break;

                Console.Write("都市：");
                city = Console.ReadLine();

                Console.Write("人口：");
                population = int.Parse(Console.ReadLine());


                //既に県名が登録済みか？
                if (prefOfficeDict.ContainsKey(pref)) {
                    /*Console.WriteLine("既に県名が登録されています。");
                    Console.Write("上書きしますか？(y,n)：");
                    if (Console.ReadLine() != "y") {
                        continue;
                    }*/

                    prefOfficeDict[pref].Add(new CityInfo { City = city, Population = population });
                } else {
                    prefOfficeDict[pref] = new List<CityInfo>();
                }

                //登録処理
                /*prefOfficeDict[pref] = new CityInfo {
                    City = city,
                    Population = population,
                };*/
            }
            Console.WriteLine();
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var selected = Console.ReadLine();

            if (selected == "1") {
                //一覧表示
                foreach (var item in prefOfficeDict) {
                    foreach(var list in item.Value)
                    Console.WriteLine("{0}【{1}(人口：{2}人)】", item.Key, list.City, list.Population);
                }
            }else {
                //県名指定表示
                Console.Write("県名を入力：");
                foreach (var item in prefOfficeDict) {
                    foreach (var list in item.Value)
                        Console.WriteLine("【{0}(人口：{1}人)】", list.City, list.Population);
                }
            }
        }
    }
}

class CityInfo {
    public string City { get; set; }        //都市
    public int Population { get; set; }     //人口
}

