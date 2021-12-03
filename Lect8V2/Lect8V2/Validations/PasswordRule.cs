using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lect8.Validations
{
    public class PasswordRule<T> : IValidationRule<T>
    {
        public string ValidationMessage { get; set; }

        public bool Check(T value)
        {
            if (value == null)
                return false;
            var str = value.ToString();
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            return hasNumber.IsMatch(str) && hasUpperChar.IsMatch(str) && hasMinimum8Chars.IsMatch(str);
        }
    }
}
