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
            string str;//ssibal byte
            Login_Connect.socket.Send(str);
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            Login_Connect.로그인소켓();
        }
    }
}
