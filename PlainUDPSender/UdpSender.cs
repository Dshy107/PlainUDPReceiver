using ModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace PlainUDPSender
{
   internal class UdpSender
    {
        private readonly int Port;

        public UdpSender(int port)
        {
            Port = port;
        }

        public void Start()
        {
            Car nyBil = new Car("Tesla", "Red", "XX22333");
            string sendStr = nyBil.ToString();
            byte[] buffer = Encoding.ASCII.GetBytes(sendStr);

            UdpClient udp = new UdpClient();

            IPEndPoint OuterEP = new IPEndPoint(IPAddress.Broadcast, Port);
            udp.Send(buffer, buffer.Length, OuterEP);

            IPEndPoint ReceiverEP = new IPEndPoint(IPAddress.Any, 0);
            byte[] receivebuffer = udp.Receive(ref ReceiverEP);
            Console.WriteLine($"UDP datagram received lgt={receivebuffer.Length}");
            string incommingStr = Encoding.ASCII.GetString(receivebuffer);
            Console.WriteLine(incommingStr);
        }
    }
}
