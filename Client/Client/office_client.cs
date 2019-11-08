using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Client
{
    public partial class office_client : Form
    {
        public office_client()
        {
            InitializeComponent();
            Payment_COMBOBOX.SelectedIndex = 0;
        }
        WebClient webClient = new WebClient();
        string sResponse;
        string url = "http://210.93.84.207";
        string send_name = "";
        string send_phone = "";
        string send_address = "";
        string reipient_name = "";
        string reipient_phone = "";
        string reipient_address = "";
        string paymont = "";
        string param = "";
        private void office_client_Shown(object sender, EventArgs e)
        {
            try
            {
               //Client_Connect.클라이언트소켓();
            }
            catch
            {
                MessageBox.Show("로그인 서버와 연결실패");
            }
        }
        private void ADD_BUTTON_Click(object sender, EventArgs e)
        {
            param = "/rest/product_regi.php?";
            string data = "sender_name=" + Send_TEXTBOX.Text + "&sender_phone=" + Send_Phone_TEXTBOX.Text + "&sender_address=" + Send_address_TEXTBOX.Text + "&recipient_name=" + Receive_TEXTBOX.Text + "&recipient_phone=" + Receive_Phone_TEXTBOX.Text + "&recipient_address=" + Receive_address_TEXTBOX.Text + "&payment=" + Payment_COMBOBOX.Text;
            //+ Contents_TEXTBOX.Text + Requests_TEXTBOX.Text +
            string conn = url + param + data;
            webClient.Encoding = UTF8Encoding.UTF8;
            sResponse = webClient.DownloadString(conn);
            MessageBox.Show(sResponse);
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
        private void re(string con)
        {
            string conn = con;
            webClient.Encoding = UTF8Encoding.UTF8;
            sResponse = webClient.DownloadString(conn);
            JArray jarr = JArray.Parse("["+sResponse+"]");
            foreach(JObject jObject in jarr)
            {
                send_name = jObject["sender_name"].ToString();
                send_phone = jObject["sender_phone"].ToString();
                send_address = jObject["sender_address"].ToString();
                reipient_name = jObject["recipient_name"].ToString();
                reipient_phone = jObject["recipient_phone"].ToString();
                reipient_address = jObject["recipient_address"].ToString();
                paymont = jObject["payment"].ToString();
            }
        }
        private void CHECK_BUTTON_Click(object sender, EventArgs e)
        {
            param = "/rest/Check_invoice_num.php?invoice_number=1234";
            string con = url + param;
            re(con);
            DataTable table = new DataTable();
            table.Columns.Add("보내는 사람", typeof(string));
            table.Columns.Add("보내는 사람 번호", typeof(string));
            table.Columns.Add("보내는 사람 주소", typeof(string));
            table.Columns.Add("받는 사람", typeof(string));
            table.Columns.Add("받는 사람 번호", typeof(string));
            table.Columns.Add("받는 사람 주소", typeof(string));
            table.Columns.Add("지불 방법", typeof(string));
            table.Rows.Add(send_name, send_phone, send_address, reipient_name, reipient_phone, reipient_address, paymont);
            dataGridView1.DataSource = table;
        }
    }
}
