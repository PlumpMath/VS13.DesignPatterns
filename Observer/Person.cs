using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    //
    public class EmailChangedEventArgs:EventArgs {
        public string Email { get; set; }
    }

    //
    public class Person:ISubject<EmailChangedEventArgs> {
        //Members
        private string _email;
        public event EventHandler<EmailChangedEventArgs> EmailChanged;

        //Interface
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get { return _email; } set { _email = value; OnEmailChanged(value); } }
        private void OnEmailChanged(string value) {
            if (EmailChanged != null) EmailChanged(this,new EmailChangedEventArgs() { Email = value });
        }
        public void Attach(IObserver<EmailChangedEventArgs> observer) { EmailChanged += observer.Update; }
        public void Detach(IObserver<EmailChangedEventArgs> observer) { EmailChanged -= observer.Update;  }
    }

}
