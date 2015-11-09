using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    //
    public interface IObserver<in T> where T:EventArgs {
        //Interface
        void Update(Object sender,T e);
    }

}
