﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPReceiver
{
    class Program
    {
        private const int Port = 11001;
        static void Main(string[] args)
        {
            UdpReceiver receiver = new UdpReceiver(Port);
            receiver.Start();

            Console.ReadLine();
        
        }
    }
}
