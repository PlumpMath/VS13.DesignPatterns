using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class Client {
        //
        static void Main(string[] args) {
            //Create a new object by asking a prototype to clone itself
            Prototype prototype = new ConcretePrototype().Clone();
        }
    }
}
