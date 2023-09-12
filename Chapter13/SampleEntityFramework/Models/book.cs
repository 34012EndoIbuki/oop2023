using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models {
    public class book {
        public int Id { get; set; } //  主キー
        public string Title { get; set; }
        public int PublishedYear { get; set; }
        public virtual Auther Auther{ get; set; }
}
}
