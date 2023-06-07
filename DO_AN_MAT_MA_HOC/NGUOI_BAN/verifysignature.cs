using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NGUOI_BAN
{
    internal class verifysignature
    {
        public static bool VerifySignature(byte[] data, byte[] signature, RSAParameters publicKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                bool isValid = rsa.VerifyData(data, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                return isValid;
            }
        }
    }
}
