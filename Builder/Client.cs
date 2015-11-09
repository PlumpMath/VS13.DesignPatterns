using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class Client {
        //
        static void Main(string[] args) {
            //
            ConcreteBuilder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetProduct();
        }
    }
}
