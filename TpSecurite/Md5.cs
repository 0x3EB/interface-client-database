using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TpSecurite
{
    class Md5
    {
        public Md5()
        {
            
        }
        /**
        * Transform a pasword into md5 passWord
        **/
        public String SetMd5(String source)
        {
            StringBuilder sb = new StringBuilder();

            using (MD5 md5 = MD5.Create())
            {
                byte[] md5HashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(source));

                foreach (byte b in md5HashBytes)
                {
                    sb.Append(b.ToString("X2"));
                }
            }
            return sb.ToString();
        }
        
    }
}
