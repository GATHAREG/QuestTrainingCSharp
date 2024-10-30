using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEchoServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //v
            var serverBuilder = new ServerBuilder();
            serverBuilder.Run(res =>
            {
                
                serverBuilder.SendMessage(res);
            });

            serverBuilder.Shutdown();
        }
    }
}
