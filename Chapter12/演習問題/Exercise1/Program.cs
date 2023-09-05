using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var novels = new Employee[] {

                new Employee {
                    Id = 1,
                    Name = "pc",
                    HireDate = DateTime.Now,
                },
            };
            /*var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var stream = XmlWriter.Create("employee.xml",settings)) {
                var selializer = new DataContractSerializer(novels.GetType());
                selializer.WriteObject(stream, novels);
            }

            using (var reader = XmlReader.Create("employee.xml")) {
                var serializer = new DataContractSerializer(typeof(Employee));
                var novel = serializer.ReadObject(reader) as Employee;
                Console.WriteLine(novel);
            }*/






            Employee item = new Employee() {
                Id = 1,
                Name = "pc",
                HireDate = DateTime.Now,
            };


            string serializedData = null;
            //serialize
            {
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                StringWriter sw = new StringWriter();
                xs.Serialize(sw, item);
                serializedData = sw.ToString();
            }
            Console.WriteLine(serializedData);

            // Deserialize
            {
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                Employee deserilizedObject = xs.Deserialize(new StringReader(serializedData)) as Employee;
                Console.WriteLine(deserilizedObject);
            }

            /*//先生ver
            Employee emp = new Employee() {
                Id = 1,
                Name = "pc",
                HireDate = DateTime.Now,
            };
            
            //シリアル化
            //gettypeはインスタンスの型取得
            using (var writer = XmlWriter.Create(v)) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer,emp);
            }

            //逆シリアル化
            //typeof
            using (var reader = XmlReader.Create(v)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(employee);
            }*/

        }

        private static void Exercise1_2(string v) {
            var employee = new Employee[] {

                new Employee {
                    Id = 1,
                    Name = "pc",
                    HireDate = DateTime.Now,
                },
            };
            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var stream = XmlWriter.Create("employee.xml", settings)) {
                var selializer = new DataContractSerializer(employee.GetType());
                selializer.WriteObject(stream, employee);
            }


            //先生var
            /*var emps = new Employee[] {
                new Employee {
                    Id = 123,
                    Name = "出雲",
                    HireDate = new DateTime(2001,5,10),
                },
                new Employee {
                    Id = 139,
                    Name = "信濃",
                    HireDate = new DateTime(2004,12,1),
                },

            };

            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using(var writter = XmlWriter.Create(v.settings){
                var serializer = new DateContractSerializer(emps.GetType());
                serializer.WriteObject(writter, emps);
            }*/

        }

        private static void Exercise1_3(string v) {
            using (var reader = XmlReader.Create("employee.xml")) {
                var serializer = new DataContractSerializer(typeof(Employee));
                var novel = serializer.ReadObject(reader) as Employee;
                Console.WriteLine(novel);
            }

            //先生
            /*using (var reader = XmlReader.Create(v)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach(var emp in emps) {
                    Console.WriteLine("{0}{1}{2}", emp.Id, emp.Name, emp.HireDate);
                }
            }*/
        }

        private static void Exercise1_4(string v) {
            var emps = new Employee[] {
                new Employee {
                    Id = 123,
                    Name = "出雲",
                    HireDate = new DateTime(2001,5,10),
                },
                new Employee {
                    Id = 139,
                    Name = "信濃",
                    HireDate = new DateTime(2004,12,1),
                },
            };

            using (var stream = new FileStream(v, FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(emps.GetType());
                serializer.WriteObject(stream, emps);
            }

        }
    }
    [DataContract]
    public class Employee2 {
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; set; }
    }
}
