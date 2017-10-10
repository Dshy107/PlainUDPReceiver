using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPReceiver
{
   internal class UdpReceiver
    {
        private readonly int Port;
        public UdpReceiver(int port)
        {
            Port = port;
        }
        public void Start()
        {
            byte[] buffer = new byte[11001];

            UdpClient udp = new UdpClient(Port);
            IPEndPoint senderEP = new IPEndPoint(IPAddress.Any, 0);

            buffer = udp.Receive(ref senderEP);
            Console.WriteLine($"UDP datagram received lgt={buffer.Length}");
            Console.WriteLine($"Afsender er {senderEP.Address}, port {senderEP.Port}");

            string incommingStr = Encoding.ASCII.GetString(buffer);
            Console.WriteLine(incommingStr);

            //Send tilbage
            string outgoingStr = incommingStr.ToUpper();
            byte[] outBuffer = Encoding.ASCII.GetBytes(outgoingStr);
            udp.Send(outBuffer, outBuffer.Length, senderEP);
        }
    }
}
