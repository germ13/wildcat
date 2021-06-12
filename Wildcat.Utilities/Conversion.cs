
using System;
using System.Text.RegularExpressions;

namespace Wildcat.Utilities
{
    public static class Conversion
    {
        public static Decimal CelsiusToFahrenheit(Decimal Celsius)
        {
            Decimal rtv = ((9m / 5m) * Celsius) + 32m;

            rtv = Math.Round(rtv, 1);

            return rtv;
        }

        public static DateTime SafeDate(object input)
        {
            DateTime rtv = new DateTime(1900, 1, 1);

            try
            {
                DateTime.TryParse(input.ToString(), out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static DateTime SafeDate(string input)
        {
            input = input.Trim();

            DateTime rtv = new DateTime(1900, 1, 1);

            try
            {
                DateTime.TryParse(input, out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static DateTime SafeDate(DateTime? input)
        {
            DateTime rtv = new DateTime(1900, 1, 1);

            try
            {
                DateTime.TryParse(input.ToString(), out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static int SafeInteger(object input)
        {
            int rtv = -1;

            if (input == null)
                return rtv;

            decimal d = -1M;

            try
            {
                Decimal.TryParse(input.ToString(), out d);
                d = Math.Round(d, 0);

                Int32.TryParse(d.ToString(), out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static int SafeInteger(string input)
        {
            int rtv = -1;

            try
            {
                input = Regex.Replace(input, @"/^[\-]?\d*$/", String.Empty);
                input = Regex.Replace(input, "[^0-9.]", string.Empty);

                Int32.TryParse(input, out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static short SafeShort(int input)
        {
            short rtv = -1;

            try
            {
                if (input < Int16.MaxValue)
                    rtv = Convert.ToInt16(input);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static short SafeShort(string input)
        {
            short rtv = -1;

            try
            {
                input = Regex.Replace(input, @"/^[\-]?\d*$/", String.Empty);
                input = Regex.Replace(input, "[^0-9.]", string.Empty);

                Int16.TryParse(input, out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static bool SafeBoolean(bool? input)
        {
            bool rtv = false;

            try
            {
                rtv = (input != null && input == true);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static bool SafeBoolean(object input)
        {
            bool rtv = false;

            try
            {
                Boolean.TryParse(input.ToString(), out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static byte SafeByte(object input)
        {
            byte rtv = 0;

            try
            {
                Byte.TryParse(input.ToString(), out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static string SafeString(object input)
        {
            string rtv = string.Empty;

            try
            {
                if (input != null)
                    rtv = input.ToString();
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static double SafeDouble(decimal? input)
        {
            double rtv = 0D;

            try
            {
                if (input != null)
                    rtv = Convert.ToDouble(input);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static decimal SafeDecimal(decimal? input)
        {
            decimal rtv = 0M;

            try
            {
                if (input != null)
                    rtv = Convert.ToDecimal(input);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static decimal SafeDecimal(string input)
        {
            decimal rtv = 0M;

            try
            {
                if (input != null)
                    Decimal.TryParse(input, out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static decimal SafeDecimal(object input)
        {
            decimal rtv = -1M;

            try
            {
                if (input != null)
                    Decimal.TryParse(input.ToString(), out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static double SafeDouble(object input)
        {
            double rtv = 0D;

            try
            {
                if (input != null)
                    Double.TryParse(input.ToString(), out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static double SafeDouble(double? input)
        {
            double rtv = 0D;

            try
            {
                if (input != null)
                    Double.TryParse(input.ToString(), out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static double SafeDouble(string input)
        {
            double rtv = 0D;

            try
            {
                if (input != null)
                    Double.TryParse(input, out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }

        public static bool SafeBoolean(string input)
        {
            bool rtv = false;

            try
            {
                switch (input.ToUpper())
                {
                    case "Y":
                    case "YES":
                    case "T":
                    case "TRUE":
                    case "1":
                        input = "true";
                        break;
                }

                Boolean.TryParse(input, out rtv);
            }
            catch (Exception exc)
            {

            }

            return rtv;
        }
    }
}
