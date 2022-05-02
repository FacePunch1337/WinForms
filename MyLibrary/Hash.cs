using System;

namespace MyLibrary
{
    public class Hash
    {
        //128-битный алгоритм хеширования
        public static System.String Md5(System.String str)
        {
            using (System.Security.Cryptography.MD5 md5 =
                new System.Security.Cryptography.MD5CryptoServiceProvider()) 
                {
                byte[] inp = System.Text.Encoding.UTF8.GetBytes(str);
                byte[] hash = md5.ComputeHash(inp);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        //128-битный алгоритм хеширования
        public static System.String Sha1(System.String str)
        {
            using (System.Security.Cryptography.SHA1 hasher =
                System.Security.Cryptography.SHA1.Create())
            {
                byte[] inp = System.Text.Encoding.UTF8.GetBytes(str);
                byte[] hash = hasher.ComputeHash(inp);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        //256-битный алгоритм хеширования
        public static System.String Sha256(System.String str)
        {
            using (System.Security.Cryptography.SHA256 hasher =
                System.Security.Cryptography.SHA256.Create())
            {
                byte[] inp = System.Text.Encoding.UTF8.GetBytes(str);
                byte[] hash = hasher.ComputeHash(inp);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        //384-битный алгоритм хеширования
        public static System.String Sha384(System.String str)
        {
            using (System.Security.Cryptography.SHA384 hasher =
                System.Security.Cryptography.SHA384.Create())
            {
                byte[] inp = System.Text.Encoding.UTF8.GetBytes(str);
                byte[] hash = hasher.ComputeHash(inp);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        //512-битный алгоритм хеширования
        public static System.String Sha512(System.String str)
        {
            using (System.Security.Cryptography.SHA512 hasher =
                System.Security.Cryptography.SHA512.Create())
            {
                byte[] inp = System.Text.Encoding.UTF8.GetBytes(str);
                byte[] hash = hasher.ComputeHash(inp);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }


    }
}
