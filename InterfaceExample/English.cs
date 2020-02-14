using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {
    class English : ISpeakable {
        public void SayHello() {
            Console.WriteLine("Hello");
        }

        public void SayGoodbye() {
            Console.WriteLine("Bye");
        }
    }
}
