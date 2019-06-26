using System;
using System.Collections.Generic;
using System.Text;

namespace Tribunus.Classes {
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

        private string _Password;
        public string Password {
            get { return _Password; }
            set { _Password = value; }
        }

        public string PhotoFullPath {
            get {
                if (string.IsNullOrEmpty(this.Photo))
                    return string.Empty;

                return string.Format("http://tribunus.somee.com{0}", this.Photo.Substring(1));
            }
        }

    }
}
