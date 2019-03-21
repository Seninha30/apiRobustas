using System.Security.Cryptography;
using System.Text;

namespace XGame.Domain.Extension
{                 
    public static class StringExtension
    {
        public static string ConvertToMD5(this string passWord)
        {
            var password = (passWord += "|2d331caa-f6c0-40c0-bb43-6e32989c2881");
            var md5 = MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var item in data)
            {
                sbString.Append(item.ToString("x2"));
            }
            return sbString.ToString();
        }
    }
}
