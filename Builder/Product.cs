using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //Represents the complex product under construction
    class Product {
        //Members
        private PartA mPartA = null;
        private PartB mPartB = null;

        //Interface
        public Product() { }
        public void AddPartA() { this.mPartA = new PartA(); }
        public void AddPartB() { this.mPartB = new PartB(); }
    }

    class PartA { }
    class PartB { }
}
