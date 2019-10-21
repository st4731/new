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
            string str = "[{id}:{" + ID_TEXTBOX.Text + "},{pw}:{" + PW_TEXTBOX.Text + "}]";
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
           // MessageBox.Show(Convert.ToString(StrByte));
            Login_Connect.socket.Send(StrByte);
        }

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
