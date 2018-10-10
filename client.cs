using System;
using System.Net;
using System.Net.Sockets;
using System.IO;

public class client{
static void Main(){

	IPAddress ip = IPAddress.Parse("127.0.0.1");
	TcpClient client = new TcpClient("www.usask.ca",80);

	StreamReader stream = new StreamReader(client.GetStream());
	StreamWriter writer = new StreamWriter(client.GetStream());
	
	writer.WriteLine("GET / HTTP/1.0");
	writer.WriteLine();
	writer.Flush();

	Console.WriteLine(stream.ReadToEnd());
	Console.ReadLine();

}
}
