using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class Login_Connect
    {
        public static Socket socket;
        public static void 로그인소켓()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string IP = "192.168.0.13";//"210.93.84.207";
            try
            {
                socket.Connect(IP, 5000);
            }
            catch
            {
                Console.WriteLine("연결 x");
            }
        }
    }
}
