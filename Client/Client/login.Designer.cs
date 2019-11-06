namespace Client
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGIN_BUTTON = new System.Windows.Forms.Button();
            this.ID_TEXTBOX = new System.Windows.Forms.TextBox();
            this.PW_TEXTBOX = new System.Windows.Forms.TextBox();
            this.SIGNUP_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // LOGIN_BUTTON
            // 
            this.LOGIN_BUTTON.Location = new System.Drawing.Point(12, 70);
            this.LOGIN_BUTTON.Name = "LOGIN_BUTTON";
            this.LOGIN_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.LOGIN_BUTTON.TabIndex = 2;
            this.LOGIN_BUTTON.Text = "로그인";
            this.LOGIN_BUTTON.UseVisualStyleBackColor = true;
            this.LOGIN_BUTTON.Click += new System.EventHandler(this.LOGIN_BUTTON_Click);
            // 
            // ID_TEXTBOX
            // 
            this.ID_TEXTBOX.Location = new System.Drawing.Point(60, 6);
            this.ID_TEXTBOX.Name = "ID_TEXTBOX";
            this.ID_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.ID_TEXTBOX.TabIndex = 3;
            // 
            // PW_TEXTBOX
            // 
            this.PW_TEXTBOX.Location = new System.Drawing.Point(60, 43);
            this.PW_TEXTBOX.Name = "PW_TEXTBOX";
            this.PW_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.PW_TEXTBOX.TabIndex = 4;
            // 
            // SIGNUP_BUTTON
            // 
            this.SIGNUP_BUTTON.Location = new System.Drawing.Point(95, 70);
            this.SIGNUP_BUTTON.Name = "SIGNUP_BUTTON";
            this.SIGNUP_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.SIGNUP_BUTTON.TabIndex = 5;
            this.SIGNUP_BUTTON.Text = "회원가입";
            this.SIGNUP_BUTTON.UseVisualStyleBackColor = true;
            this.SIGNUP_BUTTON.Click += new System.EventHandler(this.SIGNUP_BUTTON_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 105);
            this.Controls.Add(this.SIGNUP_BUTTON);
            this.Controls.Add(this.PW_TEXTBOX);
            this.Controls.Add(this.ID_TEXTBOX);
            this.Controls.Add(this.LOGIN_BUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LOGIN_BUTTON;
        private System.Windows.Forms.TextBox ID_TEXTBOX;
        private System.Windows.Forms.TextBox PW_TEXTBOX;
        private System.Windows.Forms.Button SIGNUP_BUTTON;
    }
}