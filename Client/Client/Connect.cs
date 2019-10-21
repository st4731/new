using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Connect
    {
        public static void 소켓()
        {
            string IP = "210.93.84.207";
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Boolean connected = false;
            try
            {
                socket.Connect(IP, 5000);
                connected = true;
                while (connected)
                {

                }
            }
            catch
            {
                connected = false;
            }
        }
        void 보냄()
        {

        }
        void 받음()
        {

        }
    }
}
