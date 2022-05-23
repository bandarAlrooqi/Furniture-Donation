using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ASP.NET
{
    public class Component
    {
        public static bool IsLogedIn = false;
        public static user user = null;
        public static string Encryptor(string pass)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            //get hash result after compute it  
            byte[] result = md5.Hash;
            StringBuilder sb = new StringBuilder();
            foreach (byte b in result)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}