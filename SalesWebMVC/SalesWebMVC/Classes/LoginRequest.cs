using System;
using System.Collections.Generic;
using System.Text;

namespace SalesWebMVC.Classes {
    public class LoginRequest {
        private string  _User;
        public string User {
            get { return _User; }
            set { _User = value; }
        }

        private string _Password;
        public string Password {
            get { return _Password; }
            set { _Password = value; }
        }

    }
}
