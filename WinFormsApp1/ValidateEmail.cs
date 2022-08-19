using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SalaDeGimnastica
{
    class ValidateEmail
    {
        static Regex ValidEmailRegex = CreateValidEmailRegex();

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// returns true if string emailAddress is a valid email pattern.
        /// </summary>
        /// <param name="emailAddress">the email address to be checked.</param>
        /// <returns>True if valid email, false otherwise</returns>
        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }
    }
}
