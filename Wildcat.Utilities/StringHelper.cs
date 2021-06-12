using System;

namespace Wildcat.Utilities
{
    public static class StringHelper
    {
        //This function became necessary because Rajeev was stingy on usernames...he allows
        // just 20 characters
        public static string ShortUserName(string UserName, int MaxLength)
        {
            string rtv = UserName;

            //First try to shorten the name by stripping out the domain
            int backSlashLocation = rtv.IndexOf('\\');

            if (backSlashLocation > -1)
                rtv = rtv.Substring(backSlashLocation, UserName.Length - backSlashLocation);

            //If domain stripping is not enough, take the right-most characters because
            //  last names are more likely to be unique
            if (rtv.Length > MaxLength)
            {
                int excessCharacters = rtv.Length - MaxLength;
                rtv = rtv.Substring(excessCharacters, MaxLength);
            }

            return rtv;
        }

        public static bool IsRoughlyEqual(string a, string b)
        {
            if ((a == null) && (b == null))
            {
                return true;
            }

            if ((a == null) || (b == null))
            {
                return false;
            }

            return (0 == String.Compare(a.Trim(), b.Trim(), StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
