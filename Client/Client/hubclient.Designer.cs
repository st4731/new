namespace Client
{
    partial class hubclient
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
            this.Num_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Update_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Num_TEXTBOX
            // 
            this.Num_TEXTBOX.Location = new System.Drawing.Point(69, 50);
            this.Num_TEXTBOX.Name = "Num_TEXTBOX";
            this.Num_TEXTBOX.Size = new System.Drawing.Size(100, 21);
            this.Num_TEXTBOX.TabIndex = 1;
            // 
            // Update_BUTTON
            // 
            this.Update_BUTTON.Location = new System.Drawing.Point(198, 48);
            this.Update_BUTTON.Name = "Update_BUTTON";
            this.Update_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.Update_BUTTON.TabIndex = 2;
            this.Update_BUTTON.Text = "button1";
            this.Update_BUTTON.UseVisualStyleBackColor = true;
            this.Update_BUTTON.Click += new System.EventHandler(this.Update_BUTTON_Click);
            // 
            // hubclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update_BUTTON);
            this.Controls.Add(this.Num_TEXTBOX);
            this.Controls.Add(this.label1);
            this.Name = "hubclient";
            this.Text = "hubclient";
            this.Shown += new System.EventHandler(this.hub_client_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Num_TEXTBOX;
        private System.Windows.Forms.Button Update_BUTTON;
    }
}