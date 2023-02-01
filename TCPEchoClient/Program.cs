// See https://aka.ms/new-console-template for more information
using TCPEchoClient;

Console.WriteLine("Hello, World!");

EchoClient client = new EchoClient();
client.Start();

Console.ReadLine();