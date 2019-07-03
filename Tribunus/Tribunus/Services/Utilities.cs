using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tribunus.Services {
    public class Utilities {
        public static bool IsValidEmail(string email) {
            return Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success;
        }
    }
}
