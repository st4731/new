using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            byte[] receiveBytes = new byte[11];
            string str = "[{id}:{" + ID_TEXTBOX.Text + "},{pw}:{" + PW_TEXTBOX.Text + "}]";
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
            Login_Connect.socket.Send(StrByte);

            //서버에서 보낸 값 받아서 볼라고 넣음. 받는건 잘됨.
            byte[] Buffer = new byte[Login_Connect.socket.SendBufferSize];
            Login_Connect.socket.Receive(Buffer, Buffer.Length, SocketFlags.None);
            //MessageBox.Show(Encoding.UTF8.GetString(Buffer));
            string ty = Encoding.UTF8.GetString(Buffer);
            MessageBox.Show(ty);

        }
        /*void asd(IAsyncResult ar)
        {
            byte[] buff = new byte[8192];
            Socket transferSock = (Socket)ar.AsyncState;
            int strLength = transferSock.EndReceive(ar);
            Console.WriteLine(Encoding.Default.GetString(receiveBytes));
            ;
        }*/

        private void Login_Shown(object sender, EventArgs e)
        {
            try
            {
                Login_Connect.로그인소켓();
            }
            catch
            {
                MessageBox.Show("로그인 서버와 연결실패");
            }
        }
    }
}
