using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            PW_LABEL.Text = "패스워드가 일치합니다.";
            LABEL.Text = "0";
            VAR_COMCOBOX.SelectedIndex = 0;
        }
        //COMBOBOX.SelectedIndex = 0;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SIGNUP_BUTTON_Click(object sender, EventArgs e)
        {
            string sResponse = "";
            string add = "id=" + ID_TEXTBOX.Text + "&pw=" + PW_TEXTBOX.Text + "&name=" + NAME_TEXTBOX.Text + "&phone=" + NUM_TEXTBOX.Text + "&branch=" + BRANCH_TEXTBOX.Text + "&job=" + VAR_COMCOBOX.Text;
            WebClient webClient = new WebClient();
            webClient.Encoding = UTF8Encoding.UTF8;
            sResponse = webClient.DownloadString("http://210.93.84.207/rest/signup.php?"+add);
            MessageBox.Show("가입"+ sResponse);
        }

        private void SIGNUP_BUTTON_EnabledChanged(object sender, EventArgs e)
        {
            if (PW_LABEL.Text == "패스워드가 일치합니다." && LABEL.Text == "1")
            {
                SIGNUP_BUTTON.Enabled = true;
            }
            else if (PW_LABEL.Text == "패스워드가 불일치합니다." && LABEL.Text == "0")
            {
                SIGNUP_BUTTON.Enabled = false;
            }
        }

        private void PW_OK_TEXTBOX_Leave(object sender, EventArgs e)
        {

        }

        private void SIGNUP_BUTTON_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
