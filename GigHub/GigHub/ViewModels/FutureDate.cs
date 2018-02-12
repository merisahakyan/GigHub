using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GigHub.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            DateTime result;
            var isValid = DateTime.TryParseExact(value.ToString(),
                                   "d MMM yyyy",
                                   CultureInfo.CurrentCulture,
                                   DateTimeStyles.None,
                                   out result);
            return isValid && result>DateTime.Now;
        }
    }

    public class FutureTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;
            DateTime result;
            var isValid = DateTime.TryParseExact(value.ToString(),
                                   "HH:mm",
                                   CultureInfo.CurrentCulture,
                                   DateTimeStyles.None,
                                   out result);
            return isValid ;
        }
    }
}