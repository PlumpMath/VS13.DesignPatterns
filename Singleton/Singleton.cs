using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class Singleton {
        //Members
        private static Singleton _Instance = null;

        //Interface
        private Singleton() { }
        public static Singleton Instance() {
            //
            if (_Instance == null) _Instance = new Singleton();
            return _Instance;
        }
        public void DoSomething() { }
    }
}
