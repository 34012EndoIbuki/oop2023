using System;
using System.IO;
using System.Runtime.Serialization;
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

            

        }

        private static void Exercise1_3(string v) {
            using (var reader = XmlReader.Create("employee.xml")) {
                var serializer = new DataContractSerializer(typeof(Employee));
                var novel = serializer.ReadObject(reader) as Employee;
                Console.WriteLine(novel);
            }

        }

        private static void Exercise1_4(string v) {
        
        
        }
    }
}
