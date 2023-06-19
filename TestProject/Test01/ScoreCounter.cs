using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);



        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();    //生徒データ格納
            var lines = File.ReadAllLines(filePath);   //ファイルからすべてのデータを読み込む

            foreach (var line in lines) {    //すべての行から一行ずつ取り出す
                var items = line.Split(',');   //,区切りでitemsにデータを格納　項目別に分ける
                var student = new Student {  //studentインスタンスを生成
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);    //studentインスタンスをコレクションに追加
            }


            return students;
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    dict[student.Subject] += student.Score; //科目が存在する（点数換算）
                } else {
                    dict[student.Subject] = student.Score;  //科目が存在しない（新規格納）
                }
            }
            return dict;





        }
    }
}
