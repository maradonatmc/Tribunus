using System;
using System.Collections.Generic;
using System.Text;

namespace Tribunus.ApiRequest {
    public class MembroRequest {
        private string _USER_NAME;
        public string USER_NAME {
            get { return _USER_NAME; }
            set { _USER_NAME = value; }
        }

        private string _PASSWORD;
        public string PASSWORD {
            get { return _PASSWORD; }
            set { _PASSWORD = value; }
        }

    }
}
