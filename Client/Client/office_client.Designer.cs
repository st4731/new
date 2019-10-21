namespace Client
{
    partial class office_client
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ADD_BUTTON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Send_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Send_Phone_TEXTBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Send_address_TEXTBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Contents_TEXTBOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Requests_TEXTBOX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Receive_address_TEXTBOX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Receive_Phone_TEXTBOX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Receive_TEXTBOX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Payment_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ADD_BUTTON
            // 
            this.ADD_BUTTON.Location = new System.Drawing.Point(397, 272);
            this.ADD_BUTTON.Name = "ADD_BUTTON";
            this.ADD_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.ADD_BUTTON.TabIndex = 0;
            this.ADD_BUTTON.Text = "등록";
            this.ADD_BUTTON.UseVisualStyleBackColor = true;
            this.ADD_BUTTON.Click += new System.EventHandler(this.ADD_BUTTON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "보내는 분";
            // 
            // Send_TEXTBOX
            // 
            this.Send_TEXTBOX.Location = new System.Drawing.Point(154, 71);
            this.Send_TEXTBOX.Name = "Send_TEXTBOX";
            this.Send_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.Send_TEXTBOX.TabIndex = 2;
            // 
            // Send_Phone_TEXTBOX
            // 
            this.Send_Phone_TEXTBOX.Location = new System.Drawing.Point(154, 98);
            this.Send_Phone_TEXTBOX.Name = "Send_Phone_TEXTBOX";
            this.Send_Phone_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.Send_Phone_TEXTBOX.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "휴대전화";
            // 
            // Send_address_TEXTBOX
            // 
            this.Send_address_TEXTBOX.Location = new System.Drawing.Point(154, 125);
            this.Send_address_TEXTBOX.Name = "Send_address_TEXTBOX";
            this.Send_address_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.Send_address_TEXTBOX.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "주소";
            // 
            // Contents_TEXTBOX
            // 
            this.Contents_TEXTBOX.Location = new System.Drawing.Point(154, 152);
            this.Contents_TEXTBOX.Name = "Contents_TEXTBOX";
            this.Contents_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.Contents_TEXTBOX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "내용물";
            // 
            // Requests_TEXTBOX
            // 
            this.Requests_TEXTBOX.Location = new System.Drawing.Point(372, 152);
            this.Requests_TEXTBOX.Name = "Requests_TEXTBOX";
            this.Requests_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.Requests_TEXTBOX.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "배송시 요청사항";
            // 
            // Receive_address_TEXTBOX
            // 
            this.Receive_address_TEXTBOX.Location = new System.Drawing.Point(372, 125);
            this.Receive_address_TEXTBOX.Name = "Receive_address_TEXTBOX";
            this.Receive_address_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.Receive_address_TEXTBOX.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "주소";
            // 
            // Receive_Phone_TEXTBOX
            // 
            this.Receive_Phone_TEXTBOX.Location = new System.Drawing.Point(372, 98);
            this.Receive_Phone_TEXTBOX.Name = "Receive_Phone_TEXTBOX";
            this.Receive_Phone_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.Receive_Phone_TEXTBOX.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "휴대전화";
            // 
            // Receive_TEXTBOX
            // 
            this.Receive_TEXTBOX.Location = new System.Drawing.Point(372, 71);
            this.Receive_TEXTBOX.Name = "Receive_TEXTBOX";
            this.Receive_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.Receive_TEXTBOX.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "받는 분";
            // 
            // Payment_COMBOBOX
            // 
            this.Payment_COMBOBOX.FormattingEnabled = true;
            this.Payment_COMBOBOX.Items.AddRange(new object[] {
            "선불",
            "착불"});
            this.Payment_COMBOBOX.Location = new System.Drawing.Point(351, 194);
            this.Payment_COMBOBOX.Name = "Payment_COMBOBOX";
            this.Payment_COMBOBOX.Size = new System.Drawing.Size(121, 20);
            this.Payment_COMBOBOX.TabIndex = 17;
            // 
            // office_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Payment_COMBOBOX);
            this.Controls.Add(this.Requests_TEXTBOX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Receive_address_TEXTBOX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Receive_Phone_TEXTBOX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Receive_TEXTBOX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Contents_TEXTBOX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Send_address_TEXTBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Send_Phone_TEXTBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Send_TEXTBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADD_BUTTON);
            this.Name = "office_client";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.office_client_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD_BUTTON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Send_TEXTBOX;
        private System.Windows.Forms.TextBox Send_Phone_TEXTBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Send_address_TEXTBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contents_TEXTBOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Requests_TEXTBOX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Receive_address_TEXTBOX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Receive_Phone_TEXTBOX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Receive_TEXTBOX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Payment_COMBOBOX;
    }
}

