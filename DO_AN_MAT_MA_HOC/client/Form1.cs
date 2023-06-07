using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        private TcpClient tcpClient;
        private NetworkStream clientStream;
        public Form1()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(ip.Text, Int32.Parse(port.Text));
                clientStream = tcpClient.GetStream();
                MessageBox.Show("connect to server");
                //LogMessage("Connected to server");

                // Start a new thread to listen for incoming data from the server
                Thread receiveThread = new Thread(ReceiveDataFromServer);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //LogMessage("Error connecting to server: " + ex.Message);
            }
        }
        private void ReceiveDataFromServer()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead = clientStream.Read(buffer, 0, buffer.Length);
                    string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    MessageBox.Show("Received data from server: " + receivedData);
                    //LogMessage("Received data from server: " + receivedData);

                    // Display the received data in the textbox
                    DisplayMessageInTextBox(receivedData);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                string data = textBox1.Text;
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                if(clientStream != null)
                {
                    clientStream.Write(buffer, 0, buffer.Length);
                    clientStream.Flush();

                    MessageBox.Show("Sent data to server: " + data);
                    //LogMessage("Sent data to server: " + data);
                }
                else
                {
                    MessageBox.Show("not connect to server");
                }

                /*// Receive a response from the server
                byte[] response = new byte[4096];
                int bytesRead = clientStream.Read(response, 0, 4096);
                string responseData = Encoding.ASCII.GetString(response, 0, bytesRead);
                MessageBox.Show("Received response from server: " + responseData);
                //LogMessage("Received response from server: " + responseData);

                // Display the response in the textbox
                DisplayMessageInTextBox(responseData);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //LogMessage("Error sending data to server: " + ex.Message);
            }
        }
        private void DisplayMessageInTextBox(string message)
        {
            if (textBox2.InvokeRequired)
            {
                textBox2.Invoke(new Action<string>(DisplayMessageInTextBox), new object[] { message });
            }
            else
            {
                textBox2.AppendText(message + Environment.NewLine);
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonsend_hover(object sender, EventArgs e)
        { 
           
        }
    }
}
