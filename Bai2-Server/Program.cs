using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Bai2_Server
{
    class Program
    {
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        IPEndPoint iep = new IPEndPoint(IPAddress.Parse("224.100.0.1"), 9050);
        byte[] data = Encoding.ASCII.GetBytes("This is a test message");
        server.SendTo(data, iep);  
        server.Close();

        }
    }
}
