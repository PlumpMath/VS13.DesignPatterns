using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //Declares an interface for cloning itself
    abstract class Prototype {
        //Members

        //Interface
        public Prototype() { }
        public abstract Prototype Clone();
    }
}
