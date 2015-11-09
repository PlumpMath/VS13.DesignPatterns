using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //Implements an operation for cloning itself
    class ConcretePrototype:Prototype {
        //Members

        //Interface
        public ConcretePrototype() { }
        public override Prototype Clone() { return this; }
    }
}
