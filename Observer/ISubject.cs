using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    public interface ISubject<out T> where T:EventArgs {
        //Interface
        void Attach(IObserver<T> observer);
        void Detach(IObserver<T> observer);
    }

}
