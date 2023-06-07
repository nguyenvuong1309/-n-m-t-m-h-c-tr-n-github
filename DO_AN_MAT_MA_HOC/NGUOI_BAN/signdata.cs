using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NGUOI_BAN
{
    internal class signdata
    {
        public static byte[] SignData(byte[] data, RSAParameters privateKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                byte[] signatureBytes = rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                return signatureBytes;
            }
        }
    }
}
