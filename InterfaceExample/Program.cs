using System;
using System.Collections.Generic;

namespace InterfaceExample {
    class Program {
        static void Main(string[] args) {

            var english = new English();
            var spanish = new Spanish();
            var french = new French();
            var italian = new Italian();

            
            var Hello = new Hello(english);
            Hello.Speak();
            var hello2 = new Hello(spanish);
            hello2.Speak();
            var hello3 = new Hello(french);
            hello3.Speak();
            var hello4 = new Hello(italian);
            hello4.Speak();

          

            


            //hello3.Speak();
            //var hello3 = new Hello(new HelloInFrench());



        }


        static void TestInterfaceWidgets() { 

            var w1 = new Widget();
            w1.Print();
            var aw = new AdvWidget();
            aw.Print();
            var sw = new SuperWidget();
            sw.Print();

            var widgets = new List<IPrintable>();

            //IPrintable has one method called Print

            widgets.Add(w1);
            widgets.Add(aw);
            widgets.Add(sw);


            //inside the foreach loop, all it knows is Print
            foreach(var widget in widgets) {
                widget.Print();
            }
        }

    }
}
