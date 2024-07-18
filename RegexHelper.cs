using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexSample
{
    public static class RegexHelper
    {
        private const string phoneNumberPattern = @"^(\+98|0)9\d{9}$";
        private const string emailPattern = @"^[\w\d_.]+@[\w]+(\.[\w]{2,})+$";
        private const string urlPattern = @"^(https?:\/\/)?[\w\d.-]+\.[\w]{2,}(:\d+)?(\/[\w\d._#~%+=,-?&]*)*$";

        public static bool ValidatePhoneNumber(this string phoneNumber)
        {
            Regex regex = new Regex(phoneNumberPattern);
            return regex.IsMatch(phoneNumber);
        }
        public static bool ValidateEmailAddress(this string emailAddress)
        {
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(emailAddress);
        }
        public static bool ValidateUrlAddress(this string urlAddress)
        {
            Regex regex = new Regex(urlPattern);
            return regex.IsMatch(urlAddress);
        }
    }
    
}
