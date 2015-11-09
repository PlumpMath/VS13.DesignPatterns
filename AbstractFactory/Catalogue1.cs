using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class ConcreteFactory1: AbstractFactory {
        //Members

        //Interface
        public ConcreteFactory1() { }
        public override Catalogue MakeCatalogue(string name) { return new Catalogue("Catalogue1 (Factory Made)"); }
        public override ProductA MakeProductA(string number) { return new ProductA1(number); }
        public override ProductB MakeProductB(string number) { return new ProductB1(number); }
    }

    class ProductA1:ProductA {
        //Members

        //Interface
        public ProductA1(string number): base(number) { }
        public override string ListProduct() { return "ProductA1" + base.mNumber; }
    }

    class ProductB1:ProductB {
        //Members

        //Interface
        public ProductB1(string number) : base(number) { }
        public override string ListProduct() { return "ProductB1" + base.mNumber; }
    }
}
