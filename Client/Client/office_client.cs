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
    public partial class office_client : Form
    {
        public office_client()
        {
            InitializeComponent();
            Payment_COMBOBOX.SelectedIndex = 0;
        }
        private void office_client_Shown(object sender, EventArgs e)
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
        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            string str = "[{보내는분}:{" + Send_TEXTBOX.Text + "},{보내는분 휴대전화}:{" + Send_Phone_TEXTBOX.Text + "},{보내는분 주소}:{" + Send_address_TEXTBOX.Text + "}," +
                "{받는분}:{" + Receive_TEXTBOX.Text + "},{받는분 휴대전화}:{" + Receive_Phone_TEXTBOX.Text + "}," + "{받는분 주소}:{" + Receive_address_TEXTBOX.Text + "}" +
                ",{내용물}:{" + Contents_TEXTBOX.Text + "},{요청사항}:{" + Requests_TEXTBOX.Text + "},{지불방법}:{" + Payment_COMBOBOX.Text + "}]";
            byte[] StrByte = Encoding.UTF8.GetBytes(str);
            // MessageBox.Show(Convert.ToString(StrByte));
            Client_Connect.socket.Send(StrByte);
            Text_Clear();
        }
        void Text_Clear()
        {
            Send_address_TEXTBOX.Clear();
            Send_Phone_TEXTBOX.Clear();
            Send_TEXTBOX.Clear();
            Requests_TEXTBOX.Clear();
            Receive_address_TEXTBOX.Clear();
            Receive_Phone_TEXTBOX.Clear();
            Receive_TEXTBOX.Clear();
            Contents_TEXTBOX.Clear();
            Payment_COMBOBOX.SelectedIndex = 0;
        }
    }
}
