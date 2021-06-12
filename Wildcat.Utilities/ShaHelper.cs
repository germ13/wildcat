using System;
using System.IO;
using System.Security.Cryptography;

namespace Wildcat.Utilities
{
    public class ShaHelper
    {
        /// <summary>
        /// Performs the SHA256 Hash function on file
        /// </summary>
        /// <param name="filename">
        /// The filename to be hashed.
        /// </param>
        /// <returns>
        /// SHA256 Hash value associated with the file
        /// </returns>
        public static byte[] SHA256HashFile(string filename)
        {
            string hashedValue = string.Empty;

            //create our SHA1 provider
            SHA256CryptoServiceProvider hashAlgorithm = new SHA256CryptoServiceProvider();

            //hash the data from the file
            byte[] hashedData = hashAlgorithm.ComputeHash(File.ReadAllBytes(filename));

            //loop through each byte in the returned byte array to convert into printed ASCII
            foreach (byte b in hashedData)
            {
                hashedValue += String.Format("{0,2:x2}", b);
            }

            //return the hashed value to the caller
            return hashedData;
        }
    }
}
