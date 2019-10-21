using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class hubclient : Form
    {
        public hubclient()
        {
            InitializeComponent();
        }
        private void hub_client_Shown(object sender, EventArgs e)
        {
            try
            {
                Client_Connect.클라이언트소켓();
            }
            catch
            {
                MessageBox.Show("로그인 서버와 연결실패");
            }
        }

        private void Update_BUTTON_Click(object sender, EventArgs e)
        {
            string str = "[{id}:{" + Num_TEXTBOX.Text + "}]";
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
            // MessageBox.Show(Convert.ToString(StrByte));
            Client_Connect.socket.Send(StrByte);
            Text_Clear();
        }
        void Text_Clear()
        {
            Num_TEXTBOX.Clear();
        }
    }
}
