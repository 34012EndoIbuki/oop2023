using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise2 {
    [DataContract]
    public class Novelist {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string[] Masterpieces { get; set; }
    }
}