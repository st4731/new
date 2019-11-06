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
            PW_LABEL.Text = "";
            LABEL.Text = "";
            VAR_COMCOBOX.SelectedIndex = 0;
        }
        //COMBOBOX.SelectedIndex = 0;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SIGNUP_BUTTON_Click(object sender, EventArgs e)
        {
            String sResponse = "";

            WebClient webClient = new WebClient();
            webClient.Encoding = UTF8Encoding.UTF8;
            sResponse = webClient.UploadString("http://210.93.84.207/rest/signup.php", "id=" + ID_TEXTBOX + "&pw=" + PW_TEXTBOX + "&name="+NAME_TEXTBOX+"&phone="+NUM_TEXTBOX+"&branch="+BRANCH_TEXTBOX+"&job="+ VAR_COMCOBOX);
        }

        private void SIGNUP_BUTTON_EnabledChanged(object sender, EventArgs e)
        {
            if (PW_LABEL.Text=="패스워드가 일치합니다." &&) {
                SIGNUP_BUTTON.Enabled = false;
            }
            else if (int i; i<0; i++){

            }
        }

        private void PW_OK_TEXTBOX_Leave(object sender, EventArgs e)
        {

        }
    }
}
