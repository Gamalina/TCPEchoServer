using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TCPServerLibrary.TCPServer;
using System.Security.Cryptography.X509Certificates;

namespace TCPEchoServer
{
    public class EchoServer : AbstractTCPServer
    {
        public EchoServer():base()
        { 
        }
        public EchoServer(int PORT) : base(PORT)
        {

        }
        public EchoServer(string configFilePath) :base(configFilePath)
        {
        }

        public EchoServer(string name, int port) : base(name, port)
        {
        }

        protected override void TcpServerWork(StreamReader sr, StreamWriter sw)
        {

            string? s = sr.ReadLine();
            sw.WriteLine(s);
        }
    }
}
