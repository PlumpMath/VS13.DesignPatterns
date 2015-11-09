using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class ConcreteFactory2: AbstractFactory {
        //Members

        //Interface
        public ConcreteFactory2() { }
        public override Catalogue MakeCatalogue(string name) { return new Catalogue("Catalogue2 (Factory Made)"); }
        public override ProductA MakeProductA(string number) { return new ProductA2(number); }
        public override ProductB MakeProductB(string number) { return new ProductB2(number); }
    }

    class ProductA2:ProductA {
        //Members

        //Interface
        public ProductA2(string number) : base(number) { }
        public override string ListProduct() { return "ProductA2" + base.mNumber; }
    }

    class ProductB2:ProductB {
        //Members

        //Interface
        public ProductB2(string number) : base(number) { }
        public override string ListProduct() { return "ProductB2" + base.mNumber; }
    }
}
