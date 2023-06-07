using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using Newtonsoft.Json;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Drawing.Drawing2D;

namespace NGUOI_BAN
{
    public partial class Form1 : Form
    {
        int PORT = 0;
        string PRIVATEKEY_NGUOI_BAN = "<RSAKeyValue><Modulus>sLJNnlGqMw5+d+g8PCiD5hULAAhee0cpZpMjPrcaD6dNN4bS7gk2bIECSD/75XKH1DleXWYHtRdXMNCbolcfOqCnxk3paNCXVOb5EgR/HFSCZYRKT8UTb6wGiCG1RgZ33LZE3T2ka1JQZTBbNdydgknJYArvwsKcSl/70GuYwLk=</Modulus><Exponent>AQAB</Exponent><P>6UzJl889laJXJONAWIMuGHe995Ky0dSPEH2VyLjZV8fVW20AT7EbMKTOdIhOfIXmwIY7XdGSBU+7uZeMR/qpVw==</P><Q>weOYByeFfxqXePBqQOTs9XnmXth0eqQQa0WealLYrwR6yyX96P5BUls6teqsBpSDlWbw3QdD8S1K0ZJSTcjMbw==</Q><DP>wWw/axSP64JXm6apj3ja+8AzCJJgnWUMY9CrIWpYD9YHBzC85FVixJau8KCd6dGeOZpQl/0LgknTyxBhZr/kKw==</DP><DQ>HcGaMW7lVA52tL7g77iyjTH6IxBBQBkx0+TJXTP9wU6EsezQvRNYXxVVO1oasJ/WWfWEfceBq9/xnZxBOWLZzQ==</DQ><InverseQ>wkf6NDn/rjOB3A5/FhRPw20FUDc4oWe0awPaEX/ni9R4Mjm7648FCSIyVf0V7jPhdSd7bMvc92LKLPZy2tcDWQ==</InverseQ><D>H09pG53C+Asgc+TuD4bqYHHoIhhZjaS9fFSkUS+m6ZEuyKEWbWGqiC2QFvdnjm/uC7gitZAn23oIVDkS6wBfIvu0LV4m1yFjgO6DN0EtsWcsrV6QhZ5haHS06YGIARaz8lNgJHG/buFjjvro/ONOrIbkxTWhalJ9U8q5bQ4EHqU=</D></RSAKeyValue>";
        //string PUBLICKEY_NGUOI_BAN = "<RSAKeyValue><Modulus>sLJNnlGqMw5+d+g8PCiD5hULAAhee0cpZpMjPrcaD6dNN4bS7gk2bIECSD/75XKH1DleXWYHtRdXMNCbolcfOqCnxk3paNCXVOb5EgR/HFSCZYRKT8UTb6wGiCG1RgZ33LZE3T2ka1JQZTBbNdydgknJYArvwsKcSl/70GuYwLk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>\r\n";
        string PRIVATEKEY_NGAN_HANG = "<RSAKeyValue><Modulus>9lV/FkYK4iCkbqI4BHA4iKci3x6p8YXCV2xhWyDlmQdnBF+IwNb+sdX2pMC30TIYEIMqk0P6083gdhT5InmGh6DasYRsVxejM/djgqJDytGaojIzoAP+teDRGM13Lgr53bSfv4jaaY/KNf3lYQwfnxQSGRZ54BR9fonF1KlERVE=</Modulus><Exponent>AQAB</Exponent><P>/8zqSCQ4USge5lrbc0NQi5bxZPB9NrsIVjPwgOY61OfOUakjDnRRRDZg8A5rL8nenoeXXj+LP8UnsJuk6MJ33w==</P><Q>9oaw1ZsIN4bVeTuHvKmxfsHoxhd08gZxYW45HDhswt6eFbo4t6oHhrogzAbprp5/toV7YwMWu5G4n6EXQgWozw==</Q><DP>dXgU3qxDcIGMLxzqSjRPeMsIb+JAnjGl0nBnscoIml0ZUkbp4mloKHsQaS016+w4X3TE/nMP72kKoP/Y60ri4Q==</DP><DQ>q1LVh80S+8vHhVX6sgFYKdhGlYvtqNkTaHt6UwNfilm9kSn2iqUuT9IAQuo28jSSWt0O77NQ1A+kN8Ny714Rfw==</DQ><InverseQ>WJofVHtGX88cgqL5Mq42buEb3HZGYKHvyAIqhgc8lQLGVU9h4Tb8gB2ZIkn9dOky35oT3szlmGOT9OXwdjZecQ==</InverseQ><D>ulOJQavRZ6IRPq3teU35NURXGDX1jf8DNWWBbpC/mrUCs0ggBN2a4aFaYtxzLgWaNkNA3Qu6mqNLeYX7vJv3qPuIGuWnXzzae4+zVGoEQvKVS1xBKcx/0RXFrp7/FxPkgXtOhpcx8e00TyjI2a1qw8q5XkTu+EXF9EDI9oIWHRE=</D></RSAKeyValue>";
        //string PUBLICKEY_NGAN_HANG = "<RSAKeyValue><Modulus>9lV/FkYK4iCkbqI4BHA4iKci3x6p8YXCV2xhWyDlmQdnBF+IwNb+sdX2pMC30TIYEIMqk0P6083gdhT5InmGh6DasYRsVxejM/djgqJDytGaojIzoAP+teDRGM13Lgr53bSfv4jaaY/KNf3lYQwfnxQSGRZ54BR9fonF1KlERVE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";


        private TcpClient client;
        private NetworkStream stream;
        private NetworkStream streamrecive;
        private byte[] buffer = new byte[4096];
        string message = "";
        private Thread receiveThread;
        private bool isReceiving = false;
        byte[] encryptData = null;
        RSA aliceKeyPair;
        RSA bobKeyPair;
        string[] parts;
        string CONTRACT = "";

        static MongoClient mongoClient = new MongoClient();
        static IMongoDatabase db = mongoClient.GetDatabase("contractDB");
        static IMongoCollection<Contract> collection = db.GetCollection<Contract>("contract");

        public Form1()
        {
            InitializeComponent();
            DataReceived += OnDataReceived;
        }

        private bool isConnected = false;
        public event Action<string> DataReceived;
        private void OnDataReceived(string data)
        {
            // Handle received data here
            MessageBox.Show("Data received: " + data);

            parts = data.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            byte [] contractDescrypt = Convert.FromBase64String(parts[0]);
            string signatureBenBan = parts[1];
            byte[] signatureNganHang = Convert.FromBase64String(parts[2]);
            string hashData = parts[3];

            // bên bán xác thực chữ ký 
            bool isSignatureValid = verifysignature.VerifySignature(contractDescrypt, (signatureNganHang), bobKeyPair.ExportParameters(false));
            string decryptedData = null;
            if (isSignatureValid)
            {
                // Bob giải mã dữ liệu bằng khóa riêng tư của mình
                decryptedData = DecryptData(contractDescrypt, bobKeyPair.ExportParameters(true));
                //contract = decryptedData.ToString();
                MessageBox.Show("Dữ liệu đã được xác thực và giải mã thành công: " + decryptedData);
                CONTRACT = decryptedData;
            }
            else
            {
                MessageBox.Show("Chữ ký không hợp lệ. Dữ liệu không được giải mã.");
            }
            string verifyHashString = GetHash(parts[0] + Environment.NewLine + (parts[2]) + Environment.NewLine);
            if (CompareHashes(verifyHashString, hashData))
            {
                MessageBox.Show("Xác thực tính toàn vẹn dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Xác thực tính toàn vẹn dữ liệu không thành công");
            }
            string text = decryptedData + Environment.NewLine + "Chữ ký người bán: " + parts[1] + Environment.NewLine + "Chữ kí ngân hàng: " + parts[2] + Environment.NewLine; 
            if (textBox.InvokeRequired)
            {
                textBox.Invoke((Action)(() =>
                {
                    textBox.Text = text;
                }));
            }
            else
            {
                textBox.Text = text;
            }
        }
        

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(ip.Text, Int32.Parse(port.Text));
                stream = client.GetStream();
                MessageBox.Show("Connected to the server.");

                receiveThread = new Thread(ReceiveData);
                receiveThread.Start();
                isReceiving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ReceiveData()
        {
            try
            {
                byte[] buffer = new byte[4096];
                while (isReceiving)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                        DataReceived?.Invoke(data);

                        Array.Clear(buffer, 0, buffer.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving data: " + ex.Message);
            }
        }
        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
                stream.Flush();
                MessageBox.Show("Message sent: " + message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void disconnect_Click(object sender, EventArgs e)
        {
            isConnected = false; // Set isConnected to false before closing connections
            stream.Close();
            client.Close();
            MessageBox.Show("Disconnected from the server.");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            aliceKeyPair = RSA.Create();
            bobKeyPair = RSA.Create();

            //keyPairNganHang = RSA.Create();
            aliceKeyPair.FromXmlString(PRIVATEKEY_NGUOI_BAN);

            //keyPairNguoiBan = RSA.Create();
            bobKeyPair.FromXmlString(PRIVATEKEY_NGAN_HANG);

            string aliceKeyString = aliceKeyPair.ToXmlString(includePrivateParameters: true);

            // Export Bob'
            string bobKeyString = bobKeyPair.ToXmlString(includePrivateParameters: true);


            // Alice mã hóa dữ liệu bằng khóa công khai của Bob
            byte[] encryptedData_ = EncryptData( Environment.NewLine + "Buyer: Nguyen Thanh Tai" + Environment.NewLine +"Seller: Nguyen Duc Vuong" + Environment.NewLine +"Sum: 1000000" + Environment.NewLine, bobKeyPair.ExportParameters(false));
            
            string dataString = Convert.ToBase64String(encryptedData_);
            byte[] encryptedData = Convert.FromBase64String(dataString);

            // Hash dữ liệu.
            string hashData = GetHash(dataString);


            // Alice ký dữ liệu bằng khóa riêng tư của mình
            byte[] signature = signdata.SignData(encryptedData, aliceKeyPair.ExportParameters(true));
            message = dataString + Environment.NewLine +
                      Convert.ToBase64String(signature) + Environment.NewLine +
                      hashData + Environment.NewLine;
            /*aliceKeyString + Environment.NewLine +
            bobKeyString + Environment.NewLine;*/
            textBox.Text = "\nBuyer: Nguyen Thanh Tai\nSeller: Nguyen Duc Vuong\nSum: 1000000\n";



            // Bob xác thực chữ ký
            bool isSignatureValid = verifysignature.VerifySignature(encryptedData, signature, aliceKeyPair.ExportParameters(false));

            if (isSignatureValid)
            {
                // Bob giải mã dữ liệu bằng khóa riêng tư của mình
                string decryptedData = DecryptData(encryptedData, bobKeyPair.ExportParameters(true));
                MessageBox.Show("Dữ liệu đã được xác thực và giải mã thành công: " + decryptedData);
            }
            else
            {
                MessageBox.Show("Chữ ký không hợp lệ. Dữ liệu không được giải mã.");
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

        /*public static byte[] SignData(byte[] data, RSAParameters privateKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                byte[] signatureBytes = rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                return signatureBytes;
            }
        }*/

        /*public static bool VerifySignature(byte[] data, byte[] signature, RSAParameters publicKey)
        {
            using (var rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                bool isValid = rsa.VerifyData(data, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                return isValid;
            }
        }*/

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
        static string ToJsonString(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        // Helper method to convert a JSON string to an object
        static T FromJsonString<T>(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
        public void ReadAllDocuments()
        {
            List<Contract> list = collection.AsQueryable().ToList<Contract>();
            dataGridView.DataSource = list;
        }

        private void add_Click(object sender, EventArgs e)
        {
            string[] temp = CONTRACT.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show(temp.Length.ToString() + temp);
            MessageBox.Show(temp[0].ToString());
            MessageBox.Show(temp[1].ToString());
            MessageBox.Show(float.Parse(temp[2].Substring(4, 8)).ToString());
            MessageBox.Show(parts[1].ToString());
            MessageBox.Show(parts[2].ToString());
            try
            {
                Contract c = new Contract(temp[0].ToString(), temp[1].ToString(), float.Parse(temp[2].Substring(4, 8)), parts[1].ToString(), parts[2].ToString());
                collection.InsertOneAsync(c);
                MessageBox.Show("Success add data to mongodb");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        static IMongoDatabase dbKey = mongoClient.GetDatabase("keyDB");
        static IMongoCollection<key> collectionkey = dbKey.GetCollection<key>("key");

        private void getkey_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "6479994ed90f01e7ea4b792f";
                var filterDefinition = Builders<key>.Filter.Eq(a => a._id, id);
                var product = collectionkey.Find(filterDefinition).FirstOrDefault();
                MessageBox.Show(product.value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool CompareHashes(string hash1, string hash2)
        {
            return StringComparer.OrdinalIgnoreCase.Compare(hash1, hash2) == 0;
        }
        private void save_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
