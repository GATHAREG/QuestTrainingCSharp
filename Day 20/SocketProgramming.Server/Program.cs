using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgramming.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;

            var listener = new TcpListener(ip, port);
            listener.Start();
            Console.WriteLine($"App is listening on{ip}:{port}");

            Socket socket = listener.AcceptSocket();
            Console.WriteLine("Client Connected");
            while (true)
            {


                var buffer = new byte[1024];
                var dataLength = socket.Receive(buffer);
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                Console.WriteLine($"Message Received : {message}");

                //response of server to client
                Console.Write("Server:");
                string response = Console.ReadLine();
                byte[] responseData = Encoding.ASCII.GetBytes(response);
                socket.Send(responseData);

            }
            socket.Close();
            listener.Stop();
        }
    }
}
