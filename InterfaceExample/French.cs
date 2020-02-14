using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {
    class French : ISpeakable {

        public void SayHello() {
            Console.WriteLine("Bonjour");
        }

        public void SayGoodbye() {
            Console.WriteLine("Au revoir");
        }
    }
}
