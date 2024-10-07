// See https://aka.ms/new-console-template for more information
using TCPEchoServer;


EchoServer server = new EchoServer("Test", 7007);
EchoServer server1 = new EchoServer("C:\\Users\\Danie\\source\\repos\\TCPEchoServer\\TCPServerLibrary\\TCPServer");
server1.Start();
