using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class GreetingMorning : IGreeting {
        public string GetMessage() {
            return "おはよう";
        }
    }

    class GreetingAfternoon : IGreeting {
        public string GetMessage() {
            return "こんにちわ";
        }
    }

    class GreetingEvening : IGreeting {
        public string GetMessage() {
            return "こんばんわ";
        }
    }
}
