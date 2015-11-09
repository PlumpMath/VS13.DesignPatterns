using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class AbstractFactory {
        //Members

        //Interface
        public AbstractFactory() { }
        public virtual Catalogue MakeCatalogue(string name) { return new Catalogue(name); }
        public virtual ProductA MakeProductA(string number) { return new ProductA(number); }
        public virtual ProductB MakeProductB(string number) { return new ProductB(number); }
    }
}
