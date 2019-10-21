using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Client_Connect
    {

        public static Socket socket;
        public static void 클라이언트소켓()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string IP = "192.168.0.13";
            try
            {
                socket.Connect(IP, 5000);

                //socket.Send();
            }
            catch
            {
            }
        }

        void 받음()
        {

        }
    }
}
