using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DarkSkyApp
{
    /// <summary>
    /// Extensions for double, datetime and string to work with local formatted numbers
    /// Also implements the unix time stamp do datetime convertion
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Returns a a value as a string formatted acording to the local culture
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToStringCultureFormatted(this double value)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            return value.ToString(culture);
        }

        /// <summary>
        /// Converts to double a string formatted acording to the local culture
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ToDoubleCultureFormatted(this string value)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            return Double.Parse(value,culture);
        }

        /// <summary>
        /// Converts to string a datetime formatted acording to the local culture
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToStringCultureFormatted(this DateTime value)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            return value.ToString(culture);
        }

        /// <summary>
        /// Convert UNIX timestamp to datetime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this int value)
        {
            DateTime dateTime = new DateTime(1970, 1, 1);
            dateTime = dateTime.AddSeconds(value);
            return dateTime;
        }
    }
}
