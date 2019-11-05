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
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ADD_BUTTON
            // 
            this.ADD_BUTTON.Location = new System.Drawing.Point(537, 121);
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
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "보내는 분";
            // 
            // Send_TEXTBOX
            // 
            this.Send_TEXTBOX.Location = new System.Drawing.Point(112, 12);
            this.Send_TEXTBOX.Name = "Send_TEXTBOX";
            this.Send_TEXTBOX.Size = new System.Drawing.Size(255, 21);
            this.Send_TEXTBOX.TabIndex = 2;
            // 
            // Send_Phone_TEXTBOX
            // 
            this.Send_Phone_TEXTBOX.Location = new System.Drawing.Point(112, 39);
            this.Send_Phone_TEXTBOX.Name = "Send_Phone_TEXTBOX";
            this.Send_Phone_TEXTBOX.Size = new System.Drawing.Size(255, 21);
            this.Send_Phone_TEXTBOX.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "휴대전화";
            // 
            // Send_address_TEXTBOX
            // 
            this.Send_address_TEXTBOX.Location = new System.Drawing.Point(112, 66);
            this.Send_address_TEXTBOX.Name = "Send_address_TEXTBOX";
            this.Send_address_TEXTBOX.Size = new System.Drawing.Size(255, 21);
            this.Send_address_TEXTBOX.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "주소";
            // 
            // Contents_TEXTBOX
            // 
            this.Contents_TEXTBOX.Location = new System.Drawing.Point(112, 93);
            this.Contents_TEXTBOX.Name = "Contents_TEXTBOX";
            this.Contents_TEXTBOX.Size = new System.Drawing.Size(255, 21);
            this.Contents_TEXTBOX.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "내용물";
            // 
            // Requests_TEXTBOX
            // 
            this.Requests_TEXTBOX.Location = new System.Drawing.Point(527, 93);
            this.Requests_TEXTBOX.Name = "Requests_TEXTBOX";
            this.Requests_TEXTBOX.Size = new System.Drawing.Size(255, 21);
            this.Requests_TEXTBOX.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "배송시 요청사항";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Receive_address_TEXTBOX
            // 
            this.Receive_address_TEXTBOX.Location = new System.Drawing.Point(527, 66);
            this.Receive_address_TEXTBOX.Name = "Receive_address_TEXTBOX";
            this.Receive_address_TEXTBOX.Size = new System.Drawing.Size(255, 21);
            this.Receive_address_TEXTBOX.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "주소";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Receive_Phone_TEXTBOX
            // 
            this.Receive_Phone_TEXTBOX.Location = new System.Drawing.Point(527, 39);
            this.Receive_Phone_TEXTBOX.Name = "Receive_Phone_TEXTBOX";
            this.Receive_Phone_TEXTBOX.Size = new System.Drawing.Size(255, 21);
            this.Receive_Phone_TEXTBOX.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "휴대전화";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // Receive_TEXTBOX
            // 
            this.Receive_TEXTBOX.Location = new System.Drawing.Point(527, 12);
            this.Receive_TEXTBOX.Name = "Receive_TEXTBOX";
            this.Receive_TEXTBOX.Size = new System.Drawing.Size(255, 21);
            this.Receive_TEXTBOX.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "받는 분";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // Payment_COMBOBOX
            // 
            this.Payment_COMBOBOX.FormattingEnabled = true;
            this.Payment_COMBOBOX.Items.AddRange(new object[] {
            "선불",
            "착불"});
            this.Payment_COMBOBOX.Location = new System.Drawing.Point(112, 121);
            this.Payment_COMBOBOX.Name = "Payment_COMBOBOX";
            this.Payment_COMBOBOX.Size = new System.Drawing.Size(100, 20);
            this.Payment_COMBOBOX.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "지불방법";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 454);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Payment_COMBOBOX);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Requests_TEXTBOX);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.Receive_address_TEXTBOX);
            this.tabPage1.Controls.Add(this.Send_TEXTBOX);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Receive_Phone_TEXTBOX);
            this.tabPage1.Controls.Add(this.Send_Phone_TEXTBOX);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Receive_TEXTBOX);
            this.tabPage1.Controls.Add(this.Send_address_TEXTBOX);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ADD_BUTTON);
            this.tabPage1.Controls.Add(this.Contents_TEXTBOX);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "물품 등록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "물품 입고";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "선불",
            "착불"});
            this.comboBox1.Location = new System.Drawing.Point(72, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "내용물";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "내용물";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "등록";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(775, 268);
            this.dataGridView1.TabIndex = 20;
            // 
            // office_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "office_client";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.office_client_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
    }
}

