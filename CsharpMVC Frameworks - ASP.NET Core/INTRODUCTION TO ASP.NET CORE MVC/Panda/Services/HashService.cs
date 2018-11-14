using System;
using System.Security.Cryptography;
using System.Text;
using Panda.Services.Contracts;

namespace Panda.Services
{
    public class HashService : IHashService
    {
        public string Hash(string value)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(value);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}