using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEN_VAN_CHUYEN
{
    internal class encryptdata
    {
        string PUBLICKEY_BEN_VAN_CHUYEN = "<RSAKeyValue><Modulus>nU8BKCcpjJPivDo+rTZ5lNqDNLHy78+yaOM4L94tvr4LSqnIJcf/JpT5CSRO45Yd2TzKbWch+ZNcXOTUXGlr40gHbeMrAdSOZMAzKIvuQ8N7MTmWJywb91fg4ZA2ZIyEzfbJ4/oh0Ao1z665XQf/8jPK8CnuHJNDFqeLmKzhCtE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        string PRIVATEKEY_BEN_VAN_CHUYEN = "<RSAKeyValue><Modulus>nU8BKCcpjJPivDo+rTZ5lNqDNLHy78+yaOM4L94tvr4LSqnIJcf/JpT5CSRO45Yd2TzKbWch+ZNcXOTUXGlr40gHbeMrAdSOZMAzKIvuQ8N7MTmWJywb91fg4ZA2ZIyEzfbJ4/oh0Ao1z665XQf/8jPK8CnuHJNDFqeLmKzhCtE=</Modulus><Exponent>AQAB</Exponent><P>zcsAlWZhS1f7puBo81VFxkQp3OZNxPePCJ5JYxweXbUBtd2QLQnFF6TUjwNOqA35I72nX82/7jMRQdikAdW0Ew==</P><Q>w6/dWnFrz1Nlq3KLKfU8ah3cdvpXW5/WlEJJDSqDQU2REFL+kMkrEK3XNLmNfGJ2w2gQ/cvq+6sWdsa9W0I6Cw==</Q><DP>S77edh76zLqTm7aZqobGadWI+w+hrE/aS7fHFz2wR5lqCcCFYq5n5u36drEm8GBERU13H6IhdNFDFtNgenRoFQ==</DP><DQ>dOFN7P9hzWuahlTcGiuH8jnzvHy6QNevas5Mo7iIvTB/PKjVs9T0C/pJWAycHXcSSJSX0X9C0x7VRAxgfWmJEQ==</DQ><InverseQ>PniB7CBfZ8x5kRvJKT4eOAZW6Jq0aa0d2XoCckiCM5hrdHMzin1RFDggLAjPeCtij3RXzTY9gSPXisU8j0PAfg==</InverseQ><D>PUZg9PsMPC3+y8MEVwQ5J7pWEVifgLoujJy1bi/lMb9lNpgb1lupD6ZHuz/hWtVGmzAKycK6gTTdbXHVJooJ88nfxtLJPmiJ/PP3uXS/ZM+fpg4EPbuuz/U/kZKnGg7aA6RSldkAAEVE7ODDqpD5fY/Na4az/fI11rxKVuFFPWE=</D></RSAKeyValue>";

        string PUBLICKEY_BEN_BAN = "<RSAKeyValue><Modulus>tMThVn8nVIfh0dB/HuN+4Gv/XiY2GBKnagywIMJXXNoricwNf7PHzIhUizbLbIMYDkr7jaUl31AIROSIq7yWXtHr2wnd6iqv2YDjP6EB+oVwWQlG+G9OKpZwOCxtwZaMZBDe3zBPwhe2AWmd6lVSlXE+GhSvV35UsotuaEDz990=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        string PRIVATEKEY_BEN_BAN = "<RSAKeyValue><Modulus>tMThVn8nVIfh0dB/HuN+4Gv/XiY2GBKnagywIMJXXNoricwNf7PHzIhUizbLbIMYDkr7jaUl31AIROSIq7yWXtHr2wnd6iqv2YDjP6EB+oVwWQlG+G9OKpZwOCxtwZaMZBDe3zBPwhe2AWmd6lVSlXE+GhSvV35UsotuaEDz990=</Modulus><Exponent>AQAB</Exponent><P>xsUGi8uTGGJFrTfRGWOfauCmraboEm9/s0SveFVZKgQRKGrpjs5CN7vpjR3Yf5jKSPfzcColzlNajy5045ptBw==</P><Q>6NEQKrF6FPJUjhk0O6D4zIEipNUdebphbYli+/y4DdZCAhPFlPUi5mXmiC/L3G7PSJmAynDcPtbFUSWccUne+w==</Q><DP>HtX8AP3w8Ox18LxjBPROi+8UDIaDJDEF95KlQh7DeWAuJT4Iw6292hWd0tWZe5oBb7Z/npv7R3no56OGYLTZSw==</DP><DQ>a5bhj7lAn5l1Nc2z87JqB6fNqLrLyks1ZvdMhQK+07Yl/uvALRwzqqGArYLZBN84b2ZwvBz3yxpZSSzGZRwsLQ==</DQ><InverseQ>JFCAppeS2fVh2UMqcEgiwUBcXVfeKU6Z5yKAfw7bce7YJ0w8EP/nKAUy0aaaEvBboUoBgkvOw9+JGzNKZGrrSQ==</InverseQ><D>b/0cwPJrUkIQU2TArEkx/CTMAu7XSlicIOYVY2Yiq2J54JdqsXeWSw8WmVxr8CDTEV/AsgLjEJLLXKrcRNDDspUn30XsV1waYHtgWP9kzbcf7EbJOmofu+bFemqxtLUlybR/WKUdfCged+UNChykKKBsnB8bw8clIdIgskLyfn0=</D></RSAKeyValue>";


        public static string ENCRYPT_AND_SIGN_DATA(string data,string publickeyreceiver,string privatekeysender)
        {
            try
            {
                // Compute the hash of the data
                string hash = ComputeSHA256Hash(data);

                // Sign the hash using the private key of the sender
                byte[] signature = SignData(hash, privatekeysender);

                // Encrypt the data using the public key of the receiver
                string encryptedData = EncryptData(data, publickeyreceiver);

                /*// Create a container for the result
                StringBuilder result = new StringBuilder();

                // Append the signature and encrypted data to the result
                result.AppendLine("Signature: " + Convert.ToBase64String(signature));
                result.AppendLine("Encrypted Data: " + encryptedData);*/
                string result = encryptedData + Environment.NewLine + Convert.ToBase64String(signature);

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
          
        }
        public static bool DECRYPT_AND_VERIFY_DATA(string data,string publickeysender,string privatekeyreceiver)
        {
            try
            {
                string[] parts = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                string encryptedData = parts[0];
                string signatureString = parts[1];

                // Convert the signature string back to bytes
                byte[] signature = Convert.FromBase64String(signatureString);

                // Decrypt the data using the private key of the receiver
                string decryptedData = DecryptData(encryptedData, privatekeyreceiver);

                // Compute the hash of the decrypted data
                string decryptedHash = ComputeSHA256Hash(decryptedData);

                // Verify the signature using the public key of the sender
                bool isSignatureValid = VerifySignature(decryptedHash, signature, publickeysender);
                MessageBox.Show(isSignatureValid.ToString());
                return isSignatureValid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private static byte[] SignData(string data, string privateKey)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                byte[] signatureBytes = rsa.SignData(dataBytes, new SHA256CryptoServiceProvider());

                return signatureBytes;
            }
        }

        private static bool VerifySignature(string data, byte[] signature, string publicKey)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                bool isSignatureValid = rsa.VerifyData(dataBytes, new SHA256CryptoServiceProvider(), signature);

                return isSignatureValid;
            }
        }
        private static string EncryptData(string data, string publicKey)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            int chunkSize = 100; // Adjust this value to change the size of each chunk

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                List<byte[]> encryptedChunks = new List<byte[]>();

                for (int i = 0; i < dataBytes.Length; i += chunkSize)
                {
                    int chunkLength = Math.Min(chunkSize, dataBytes.Length - i);
                    byte[] chunk = new byte[chunkLength];
                    Array.Copy(dataBytes, i, chunk, 0, chunkLength);
                    byte[] encryptedChunk = rsa.Encrypt(chunk, false);
                    encryptedChunks.Add(encryptedChunk);
                }

                byte[] mergedEncryptedData = new byte[encryptedChunks.Sum(c => c.Length)];
                int offset = 0;

                foreach (byte[] encryptedChunk in encryptedChunks)
                {
                    encryptedChunk.CopyTo(mergedEncryptedData, offset);
                    offset += encryptedChunk.Length;
                }

                return Convert.ToBase64String(mergedEncryptedData);
            }
        }

        private static string DecryptData(string encryptedData, string privateKey)
        {
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedData);

                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(privateKey);

                    int blockSize = rsa.KeySize / 8; // Calculate the block size based on the key size
                    int encryptedBytesCount = encryptedBytes.Length;
                    List<byte[]> decryptedChunks = new List<byte[]>();

                    for (int offset = 0; offset < encryptedBytesCount; offset += blockSize)
                    {
                        int chunkSize = Math.Min(blockSize, encryptedBytesCount - offset);
                        byte[] chunk = new byte[chunkSize];
                        Buffer.BlockCopy(encryptedBytes, offset, chunk, 0, chunkSize);

                        byte[] decryptedChunk = rsa.Decrypt(chunk, false);
                        decryptedChunks.Add(decryptedChunk);
                    }

                    byte[] decryptedBytes = decryptedChunks.SelectMany(chunk => chunk).ToArray();
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /*private static string EncryptData(string data, string publicKey)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                byte[] encryptedData = rsa.Encrypt(dataBytes, false);

                return Convert.ToBase64String(encryptedData);
            }
        }*/

        /*private static string DecryptData(string encryptedData, string privateKey)
        {
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedData);

                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(privateKey);
                    byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, false);

                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }*/

        private static string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public static bool CompareHashes(string hash1, string hash2)
        {
            return StringComparer.OrdinalIgnoreCase.Compare(hash1, hash2) == 0;
        }
    }
}
