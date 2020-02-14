using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {
    public class AdvWidget : IPrintable {

        public void Print() {
            Console.WriteLine("Adv Widget");
        }
    }
}
