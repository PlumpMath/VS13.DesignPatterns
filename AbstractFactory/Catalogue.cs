using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class Catalogue {
        //Members
        private string mName = "";
        private List<ProductA> productA = new List<ProductA>();
        private ProductB productB = null;

        //Interface
        public Catalogue(string name) { this.mName = name; }
        public void AddProductA(ProductA product) { productA.Add(product); }
        public void AddProductB(ProductB product) { productB = product; }
        public string ListProducts() { 
            //
            string listing = this.mName + "\n";
            foreach(ProductA product in productA) {
                listing += product.ListProduct() + "\t";
            }
            if (productB != null) listing += "\n" + productB.ListProduct();
            listing += "\n";
            return listing;
        }
    }

    class ProductA {
        //Members
        protected string mNumber = "";

        //Interface
        public ProductA(string number) { this.mNumber = number; }
        public virtual string ListProduct() { return "ProductA" + this.mNumber; }
    }

    class ProductB {
        //Members
        protected string mNumber = "";

        //Interface
        public ProductB(string number) { this.mNumber = number; }
        public virtual string ListProduct() { return "ProductB" + this.mNumber; }
    }
}
