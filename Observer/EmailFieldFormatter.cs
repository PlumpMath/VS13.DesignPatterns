using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    public class EmailFieldFormatter:IObserver<EmailChangedEventArgs> {
        private readonly TextBox _emailField;

        public EmailFieldFormatter(TextBox emailField) {
            _emailField = emailField;
        }

        public void Update(object sender,EmailChangedEventArgs e) {
            var highlightColor = Color.FromArgb(255,255,255,255);

            if (!string.IsNullOrEmpty(e.Email)) {
                highlightColor = Color.FromArgb(255,255,255,0);
            }

            _emailField.Background = new SolidColorBrush(highlightColor);
        }
    }

}
