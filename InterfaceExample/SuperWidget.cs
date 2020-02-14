using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample {


    public class SuperWidget : IPrintable {

        public void Print() {
            Console.WriteLine("SuperWidget");
        }
    }
}
