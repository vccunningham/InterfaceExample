using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {
    class Italian : ISpeakable {
        public void SayHello() {
            Console.WriteLine("Ciao");
        }

        public void SayGoodbye() {
            Console.WriteLine("Addio");
        }

    }
}
