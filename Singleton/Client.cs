using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns {
    //
    class Client {
        //
        static void Main(string[] args) {
            //
            Singleton.Instance().DoSomething();
        }
    }
}
