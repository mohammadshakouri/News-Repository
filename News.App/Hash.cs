using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
namespace News.App
{
    public static class Hash
    {
        public static string TOHash(this string pass)
        {           
            SHA256CryptoServiceProvider md = new SHA256CryptoServiceProvider();
            byte[] B1 = UTF8Encoding.UTF8.GetBytes(pass);
            byte[] B2 = md.ComputeHash(B1);
            string HashedPassword = BitConverter.ToString(B2);
            return HashedPassword;
        }
        
    }
}