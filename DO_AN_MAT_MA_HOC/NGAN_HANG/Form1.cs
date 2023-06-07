using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NGAN_HANG
{
    public partial class Form1 : Form
    {
        string PRIVATEKEY_NGUOI_BAN = "<RSAKeyValue><Modulus>sLJNnlGqMw5+d+g8PCiD5hULAAhee0cpZpMjPrcaD6dNN4bS7gk2bIECSD/75XKH1DleXWYHtRdXMNCbolcfOqCnxk3paNCXVOb5EgR/HFSCZYRKT8UTb6wGiCG1RgZ33LZE3T2ka1JQZTBbNdydgknJYArvwsKcSl/70GuYwLk=</Modulus><Exponent>AQAB</Exponent><P>6UzJl889laJXJONAWIMuGHe995Ky0dSPEH2VyLjZV8fVW20AT7EbMKTOdIhOfIXmwIY7XdGSBU+7uZeMR/qpVw==</P><Q>weOYByeFfxqXePBqQOTs9XnmXth0eqQQa0WealLYrwR6yyX96P5BUls6teqsBpSDlWbw3QdD8S1K0ZJSTcjMbw==</Q><DP>wWw/axSP64JXm6apj3ja+8AzCJJgnWUMY9CrIWpYD9YHBzC85FVixJau8KCd6dGeOZpQl/0LgknTyxBhZr/kKw==</DP><DQ>HcGaMW7lVA52tL7g77iyjTH6IxBBQBkx0+TJXTP9wU6EsezQvRNYXxVVO1oasJ/WWfWEfceBq9/xnZxBOWLZzQ==</DQ><InverseQ>wkf6NDn/rjOB3A5/FhRPw20FUDc4oWe0awPaEX/ni9R4Mjm7648FCSIyVf0V7jPhdSd7bMvc92LKLPZy2tcDWQ==</InverseQ><D>H09pG53C+Asgc+TuD4bqYHHoIhhZjaS9fFSkUS+m6ZEuyKEWbWGqiC2QFvdnjm/uC7gitZAn23oIVDkS6wBfIvu0LV4m1yFjgO6DN0EtsWcsrV6QhZ5haHS06YGIARaz8lNgJHG/buFjjvro/ONOrIbkxTWhalJ9U8q5bQ4EHqU=</D></RSAKeyValue>";
        string PUBLICKEY_NGUOI_BAN = "<RSAKeyValue><Modulus>sLJNnlGqMw5+d+g8PCiD5hULAAhee0cpZpMjPrcaD6dNN4bS7gk2bIECSD/75XKH1DleXWYHtRdXMNCbolcfOqCnxk3paNCXVOb5EgR/HFSCZYRKT8UTb6wGiCG1RgZ33LZE3T2ka1JQZTBbNdydgknJYArvwsKcSl/70GuYwLk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>\r\n";
        string PRIVATEKEY_NGAN_HANG = "<RSAKeyValue><Modulus>9lV/FkYK4iCkbqI4BHA4iKci3x6p8YXCV2xhWyDlmQdnBF+IwNb+sdX2pMC30TIYEIMqk0P6083gdhT5InmGh6DasYRsVxejM/djgqJDytGaojIzoAP+teDRGM13Lgr53bSfv4jaaY/KNf3lYQwfnxQSGRZ54BR9fonF1KlERVE=</Modulus><Exponent>AQAB</Exponent><P>/8zqSCQ4USge5lrbc0NQi5bxZPB9NrsIVjPwgOY61OfOUakjDnRRRDZg8A5rL8nenoeXXj+LP8UnsJuk6MJ33w==</P><Q>9oaw1ZsIN4bVeTuHvKmxfsHoxhd08gZxYW45HDhswt6eFbo4t6oHhrogzAbprp5/toV7YwMWu5G4n6EXQgWozw==</Q><DP>dXgU3qxDcIGMLxzqSjRPeMsIb+JAnjGl0nBnscoIml0ZUkbp4mloKHsQaS016+w4X3TE/nMP72kKoP/Y60ri4Q==</DP><DQ>q1LVh80S+8vHhVX6sgFYKdhGlYvtqNkTaHt6UwNfilm9kSn2iqUuT9IAQuo28jSSWt0O77NQ1A+kN8Ny714Rfw==</DQ><InverseQ>WJofVHtGX88cgqL5Mq42buEb3HZGYKHvyAIqhgc8lQLGVU9h4Tb8gB2ZIkn9dOky35oT3szlmGOT9OXwdjZecQ==</InverseQ><D>ulOJQavRZ6IRPq3teU35NURXGDX1jf8DNWWBbpC/mrUCs0ggBN2a4aFaYtxzLgWaNkNA3Qu6mqNLeYX7vJv3qPuIGuWnXzzae4+zVGoEQvKVS1xBKcx/0RXFrp7/FxPkgXtOhpcx8e00TyjI2a1qw8q5XkTu+EXF9EDI9oIWHRE=</D></RSAKeyValue>";
        string PUBLICKEY_NGAN_HANG = "<RSAKeyValue><Modulus>9lV/FkYK4iCkbqI4BHA4iKci3x6p8YXCV2xhWyDlmQdnBF+IwNb+sdX2pMC30TIYEIMqk0P6083gdhT5InmGh6DasYRsVxejM/djgqJDytGaojIzoAP+teDRGM13Lgr53bSfv4jaaY/KNf3lYQwfnxQSGRZ54BR9fonF1KlERVE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        byte[] encryptedData = null;
        byte[] signature = null;
        /*RSA aliceKeyPair = null;
        RSA bobKeyPair = null;*/
        string hashData = null;
        string contract = "";
        string signatureBenBan = "";
        string response = "";
        string signatureNganHang = "";
        RSA keyPairNganHang, keyPairNguoiBan;

        public Form1()
        {
            InitializeComponent();
        }
        private Thread serverThread;
        private TcpListener listener;
        private bool isServerRunning = false;

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                int serverPort;
                if (Int32.TryParse(port.Text, out serverPort))
                {
                    if (!isServerRunning)
                    {
                        serverThread = new Thread(() => StartServer(serverPort));
                        serverThread.Start();
                        MessageBox.Show("Server started on port " + serverPort);
                    }
                    else
                    {
                        MessageBox.Show("Server is already running.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid port number");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StartServer(int port)
        {
            IPAddress ipAddress = IPAddress.Any;
            listener = new TcpListener(ipAddress, port);
            listener.Start();
            isServerRunning = true;

            while (isServerRunning)
            {
                if (listener.Pending())
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Thread clientThread = new Thread(HandleClient);
                    clientThread.Start(client);
                }
            }

            listener.Stop();
            isServerRunning = false;
            MessageBox.Show("Server stopped.");
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[4096];
            int bytesRead;

             while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                // Chỗ này được sử dụng để chuyển dữ liệu được gửi từ người gửi. Gồm 4 dòng. Dòng đầu tiên là hợp đồng được mã hóa.
                // Dòng thứ hai là chữ ký, dòng thứ ba là alice key pair ở dạng string và dòng thứ 4 là bobkeypair ở dạng string.
                string[] parts = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                encryptedData = Convert.FromBase64String(parts[0]);
                signature = Convert.FromBase64String(parts[1]);

                signatureBenBan = parts[1];
                hashData = parts[2];
                /*try
                {
                    keyPairNguoiBan = RSA.Create();
                    keyPairNguoiBan.FromXmlString(parts[3]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    keyPairNganHang = RSA.Create();
                    keyPairNganHang.FromXmlString(parts[4]);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }*/
                //


                    
                MessageBox.Show("Message received: " + data);
                

                if (textBox.InvokeRequired)
                {
                    textBox.Invoke((Action)(() =>
                    {
                        textBox.AppendText(parts[0] + Environment.NewLine + parts[1] + Environment.NewLine + parts[2] + Environment.NewLine);
                    }));
                }
                else
                {
                    textBox.AppendText(data + Environment.NewLine);
                }

                if (sendFromServerButtonClicked)    // dòng này được dùng để gửi dữ liệu về cho phía người gửi.
                {
                    string message = contract + Environment.NewLine; //+ signatureBenBan + Environment.NewLine;
                    // Ngân hàng mã hóa dữ liệu bằng khóa công khai của ngân hàng.
                    byte[] encryptResponse = EncryptData(message, keyPairNganHang.ExportParameters(false));

                    //Ngân hàng kí dữ liệu bằng khóa bí mật của ngân hàng.
                    byte [] signature = SignData(encryptResponse, keyPairNganHang.ExportParameters(true));
                    signatureNganHang = Convert.ToBase64String(signature);

                    // hash dữ liệu của dữ liệu(hợp đồng và chữ ký người ngân hàng).
                    string hashData =  GetHash(Convert.ToBase64String(encryptResponse) + Environment.NewLine + signatureNganHang + Environment.NewLine);

                    response = Convert.ToBase64String(encryptResponse) + Environment.NewLine + signatureBenBan +Environment.NewLine + signatureNganHang + Environment.NewLine + hashData + Environment.NewLine;
                    byte[] responseData = Encoding.ASCII.GetBytes(response);
                    stream.Write(responseData, 0, responseData.Length);
                    stream.Flush();
                    sendFromServerButtonClicked = false; // Reset the flag
                }
            }
            client.Close();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (isServerRunning)
            {
                isServerRunning = false;
                serverThread.Join(); // Wait for the server thread to complete
            }
            MessageBox.Show("Server stopped.");
        }
        private bool sendFromServerButtonClicked = false;
        private void send_Click(object sender, EventArgs e)
        {
            sendFromServerButtonClicked = true;
            MessageBox.Show("Message sent from server.");
        }
        private void verify_Click(object sender, EventArgs e)
        {
            try
            {
                keyPairNganHang = RSA.Create();
                keyPairNganHang.FromXmlString(PRIVATEKEY_NGAN_HANG);

                keyPairNguoiBan = RSA.Create();
                keyPairNguoiBan.FromXmlString(PRIVATEKEY_NGUOI_BAN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Bob xác thực chữ ký
            bool isSignatureValid = VerifySignature(encryptedData, signature, keyPairNguoiBan.ExportParameters(false));
            string decryptedData = null;
            if (isSignatureValid)
            {
                // ngân hàng giải mã dữ liệu bằng khóa riêng tư của ngân hàng.
                decryptedData = DecryptData(encryptedData, keyPairNganHang.ExportParameters(true));
                contract = decryptedData.ToString();
                MessageBox.Show("Dữ liệu đã được xác thực và giải mã thành công: " + decryptedData);
            }
            else
            {
                MessageBox.Show("Chữ ký không hợp lệ. Dữ liệu không được giải mã.");
            }
            string verifyHashString = GetHash(Convert.ToBase64String(encryptedData));
            if (CompareHashes(verifyHashString, hashData))
            {
                MessageBox.Show("Xác thực tính toàn vẹn dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Xác thực tính toàn vẹn dữ liệu không thành công");
            }
        }
        public static bool VerifySignature(byte[] data, byte[] signature, RSAParameters publicKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                bool isValid = rsa.VerifyData(data, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                return isValid;
            }
        }
        public static string DecryptData(byte[] encryptedData, RSAParameters privateKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                byte[] decryptedBytes = rsa.Decrypt(encryptedData, RSAEncryptionPadding.Pkcs1);
                string decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                return decryptedData;
            }
        }
        static T FromJsonString<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
        public static string GetHash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Convert each byte to a two-digit hexadecimal string
                }

                return builder.ToString();
            }
        }

        public static bool CompareHashes(string hash1, string hash2)
        {
            return StringComparer.OrdinalIgnoreCase.Compare(hash1, hash2) == 0;
        }
        public static byte[] SignData(byte[] data, RSAParameters privateKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                byte[] signatureBytes = rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                return signatureBytes;
            }
        }
        public static byte[] EncryptData(string data, RSAParameters publicKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                byte[] plainBytes = Encoding.UTF8.GetBytes(data);
                byte[] encryptedBytes = rsa.Encrypt(plainBytes, RSAEncryptionPadding.Pkcs1);
                return encryptedBytes;
            }
        }
        private void sign_Click(object sender, EventArgs e)
        {

        }
    }
}
