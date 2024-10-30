using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEchoClient
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var clientBuilder = new ClientBuilder();
            clientBuilder.Run(echo =>
            {

                Console.WriteLine($"Echo:{echo}");
            });

            clientBuilder.Shutdown();

        }
    }
}
