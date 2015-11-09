using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //Constructs an object using the Builder interface
    class Director {
        //Members
        private Builder mBuilder = null;

        //Interface
        public Director(Builder builder) { this.mBuilder = builder; }
        public void Construct() { 
            //
            this.mBuilder.BuildPartA();
            this.mBuilder.BuildPartB();
        }
    }
}
