using System;
using System.Collections.Generic;
using System.Text;

namespace SalesWebMVC.Classes {
    public class User {
        private int _UserId;
        public int UserId {
            get { return _UserId; }
            set { _UserId = value; }
        }

        private string _UserName;
        public string UserName {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private string _FirstName;
        public string FirstName {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;
        public string LastName {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private string _Photo;
        public string Photo {
            get { return _Photo; }
            set { _Photo = value; }
        }
    }
}
