namespace WindowsFormsAppIMS2
{
    partial class registration
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
            this.newtxtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newtxtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmtxtpassword = new System.Windows.Forms.TextBox();
            this.registrationbutton = new System.Windows.Forms.Button();
            this.clearallbutton = new System.Windows.Forms.Button();
            this.directloginpage = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get  Started";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newtxtusername
            // 
            this.newtxtusername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newtxtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newtxtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newtxtusername.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtxtusername.Location = new System.Drawing.Point(91, 102);
            this.newtxtusername.Multiline = true;
            this.newtxtusername.Name = "newtxtusername";
            this.newtxtusername.Size = new System.Drawing.Size(245, 42);
            this.newtxtusername.TabIndex = 14;
            this.newtxtusername.TextChanged += new System.EventHandler(this.newtxtusername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // newtxtpassword
            // 
            this.newtxtpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newtxtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.newtxtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newtxtpassword.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtxtpassword.Location = new System.Drawing.Point(93, 190);
            this.newtxtpassword.Multiline = true;
            this.newtxtpassword.Name = "newtxtpassword";
            this.newtxtpassword.PasswordChar = '•';
            this.newtxtpassword.Size = new System.Drawing.Size(245, 46);
            this.newtxtpassword.TabIndex = 14;
            this.newtxtpassword.TextChanged += new System.EventHandler(this.newtxtpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm Password";
            // 
            // confirmtxtpassword
            // 
            this.confirmtxtpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmtxtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.confirmtxtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmtxtpassword.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmtxtpassword.Location = new System.Drawing.Point(92, 282);
            this.confirmtxtpassword.Multiline = true;
            this.confirmtxtpassword.Name = "confirmtxtpassword";
            this.confirmtxtpassword.PasswordChar = '•';
            this.confirmtxtpassword.Size = new System.Drawing.Size(245, 44);
            this.confirmtxtpassword.TabIndex = 14;
            this.confirmtxtpassword.TextChanged += new System.EventHandler(this.confirmtxtpassword_TextChanged);
            // 
            // registrationbutton
            // 
            this.registrationbutton.BackColor = System.Drawing.Color.BlueViolet;
            this.registrationbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationbutton.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.registrationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrationbutton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrationbutton.Location = new System.Drawing.Point(91, 510);
            this.registrationbutton.Name = "registrationbutton";
            this.registrationbutton.Size = new System.Drawing.Size(239, 42);
            this.registrationbutton.TabIndex = 16;
            this.registrationbutton.Text = "REGISTER";
            this.registrationbutton.UseVisualStyleBackColor = false;
            this.registrationbutton.Click += new System.EventHandler(this.registrationbutton_Click);
            // 
            // clearallbutton
            // 
            this.clearallbutton.BackColor = System.Drawing.Color.GhostWhite;
            this.clearallbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearallbutton.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.clearallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearallbutton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearallbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearallbutton.Location = new System.Drawing.Point(212, 558);
            this.clearallbutton.Name = "clearallbutton";
            this.clearallbutton.Size = new System.Drawing.Size(119, 32);
            this.clearallbutton.TabIndex = 16;
            this.clearallbutton.Text = "Clear All";
            this.clearallbutton.UseVisualStyleBackColor = false;
            this.clearallbutton.Click += new System.EventHandler(this.clearallbutton_Click);
            // 
            // directloginpage
            // 
            this.directloginpage.AutoSize = true;
            this.directloginpage.Font = new System.Drawing.Font("Nirmala UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directloginpage.ForeColor = System.Drawing.Color.BlueViolet;
            this.directloginpage.Location = new System.Drawing.Point(121, 605);
            this.directloginpage.Name = "directloginpage";
            this.directloginpage.Size = new System.Drawing.Size(123, 25);
            this.directloginpage.TabIndex = 17;
            this.directloginpage.Text = " LOGIN PAGE";
            this.directloginpage.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(91, 339);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(54, 23);
            this.txtemail.TabIndex = 10;
            this.txtemail.Text = "Email";
            // 
            // textemail
            // 
            this.textemail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textemail.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemail.Location = new System.Drawing.Point(94, 365);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(245, 45);
            this.textemail.TabIndex = 14;
            this.textemail.TextChanged += new System.EventHandler(this.textemail_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contact Number";
            // 
            // txtcontact
            // 
            this.txtcontact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcontact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontact.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(94, 450);
            this.txtcontact.Multiline = true;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(245, 43);
            this.txtcontact.TabIndex = 14;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 667);
            this.Controls.Add(this.directloginpage);
            this.Controls.Add(this.clearallbutton);
            this.Controls.Add(this.registrationbutton);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.confirmtxtpassword);
            this.Controls.Add(this.newtxtpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.newtxtusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registration";
            this.Text = "registrationpage";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newtxtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newtxtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmtxtpassword;
        private System.Windows.Forms.Button registrationbutton;
        private System.Windows.Forms.Button clearallbutton;
        private System.Windows.Forms.Label directloginpage;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcontact;
    }
}