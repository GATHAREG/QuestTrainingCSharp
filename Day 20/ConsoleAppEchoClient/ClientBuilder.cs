using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEchoClient
{
    internal class ClientBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpClient _client;

        public void Connect()
        {
            _client = new TcpClient();
            _client.Connect(ipAddress, port);
            Console.WriteLine("Connected to server");
        }

        public void Run(Action<String> callback)
        {
            Connect();
            while (true)
            {


                Console.Write("Enter message: ");
                string message = Console.ReadLine();
                SendMessage(message);

                // Receive echo from server
                var buffer = new byte[1024];
                int dataLength = _client.GetStream().Read(buffer, 0, buffer.Length);
                string echoMessage = Encoding.ASCII.GetString(buffer, 0, dataLength);
                callback(echoMessage);
            }
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            _client.GetStream().Write(data, 0, data.Length);
        }
        public void Shutdown()
        {
            
            _client.Close();
        }
    }
}
