
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;


namespace WebFormsSchoolApp.App_Code
{
    public class ValidationUtilities
    {
        public static bool IsValidEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;

                try
                {
                    // Normalize the domain
                    email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                          RegexOptions.None, TimeSpan.FromMilliseconds(200));

                    // Examines the domain part of the email and normalizes it.
                    string DomainMapper(Match match)
                    {
                        // Use IdnMapping class to convert Unicode domain names.
                        var idn = new IdnMapping();

                        // Pull out and process domain name (throws ArgumentException on invalid)
                        string domainName = idn.GetAscii(match.Groups[2].Value);

                        return match.Groups[1].Value + domainName;
                    }
                }
                catch (RegexMatchTimeoutException e)
                {
                    return false;
                }
                catch (ArgumentException e)
                {
                    return false;
                }

                try
                {
                    return Regex.IsMatch(email,
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                }
            catch (RegexMatchTimeoutException)
            {
                return false;
                }
        }

        public static bool IsValidBelgiumPhoneNr(string number)
        {
            //const string motif = @"^(((\+|00)32[ ]?(?:\(0\)[ ]?)?)|0){1}(4(60|[789]\d)\/?(\s?\d{2}\.?){2}(\s?\d{2})|(\d\/?\s?\d{3}|\d{2}\/?\s?\d{2})(\.?\s?\d{2}){2})$";
            //if (number != null) return Regex.IsMatch(number, motif);
            //else return false;

            var valid = true;

            if(number != null)
            {
                if(number.Length > 0)
                {
                    if(number.Length < 10)
                    {
                        valid = false;
                    }
                    else
                    {
                        //belgium intern: 0482 45 56 42
                        //belgium international: + 32 482 45 56 42
                        valid = true;
                    }
                }
                else { valid = true; }
            }
            else { valid = true; }

            return valid;
        }

        public static bool IsValidBelgiumZipCode(string number)
        {
            const string motif = @"^\d{4}$";
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }

        public static bool IsNumeric(string number)
        {
            return int.TryParse(number, out _);
        }

        public static bool PasswordContainsAtLeast1SpecialChar(string password)
        {
            string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialChArray = specialCh.ToCharArray();
            char[] passwordArray = password.ToCharArray();

            foreach (char ch in specialChArray)
            {
                if (passwordArray.Contains(ch))
                    return true;
            }
            return false;
        }

    }
}