using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
    class LineCounterProcessor : TextProcessor{
        private int _count;

        protected override void Initialize(string fname) {
            //base.Initialize(fname);
            _count = 0;
        }

        protected override void Execute(string line) {
            //base.Execute(line);
            _count++;
        }

        protected override void Terminate() {
            //base.Terminate();
            Console.WriteLine("{0}行",_count);
        }



    }
}
