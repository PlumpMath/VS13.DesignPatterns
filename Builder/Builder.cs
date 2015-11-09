using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //Specifies an abstract interface for creating parts of a Procut object
    class Builder {
        //Members

        //Interface
        public Builder() { }
        public virtual void BuildPartA() { }
        public virtual void BuildPartB() { }
        public Product GetProduct() { return null; }
    }

    class ConcreteBuilder:Builder {
        //Members
        private Product mProduct = null;

        //Interface
        public ConcreteBuilder() { this.mProduct = new Product(); }
        public override void BuildPartA() { this.mProduct.AddPartA(); }
        public override void BuildPartB() { this.mProduct.AddPartB(); }
        public Product GetProduct() { return this.mProduct; }
    }
}
