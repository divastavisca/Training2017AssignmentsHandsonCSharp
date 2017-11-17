using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ChatServer
{
    public class Program
    {

        public static void Main(string[] args)
        {
            ActivateListener();
            TcpClient client = new TcpClient("192.168.6.16", 500);
            while (true)
            {
                Console.WriteLine("Connected");
                string msg = Console.ReadLine();
                NetworkStream stream = client.GetStream();
                byte[] buffer = Encoding.ASCII.GetBytes(msg);
                stream.Write(buffer, 0, msg.Length);
                byte[] newBuffer = new byte[1000];
                stream.Read(newBuffer, 0, newBuffer.Length);
                Console.WriteLine(Encoding.ASCII.GetString(newBuffer) + "\n");
            }
        }
        private static void ActivateListener()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 500);
            listener.Start();
            Console.WriteLine("Listening");
            Socket serverSocket = listener.AcceptSocket();
            Console.WriteLine(((IPEndPoint)(serverSocket.RemoteEndPoint)).Address.ToString());
            while (true)
            {
                byte[] messageStream = new byte[serverSocket.ReceiveBufferSize];
                serverSocket.Receive(messageStream);
                string message = Encoding.ASCII.GetString(messageStream).Trim('\0');
                Console.WriteLine(message);
                string toBeSend = Console.ReadLine();
                serverSocket.Send(Encoding.ASCII.GetBytes(toBeSend));
            }
        }

    }
}