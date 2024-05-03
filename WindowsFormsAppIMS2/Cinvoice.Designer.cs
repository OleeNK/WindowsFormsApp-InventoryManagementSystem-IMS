namespace WindowsFormsAppIMS2
{
    partial class createinvoice
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.generateinvoicebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtCICode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkitemtxtbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewresult = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.generateinvoicebtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtcustomername);
            this.panel2.Controls.Add(this.txtCICode);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.checkitemtxtbtn);
            this.panel2.Location = new System.Drawing.Point(53, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 151);
            this.panel2.TabIndex = 80;
            // 
            // generateinvoicebtn
            // 
            this.generateinvoicebtn.BackColor = System.Drawing.Color.DarkRed;
            this.generateinvoicebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateinvoicebtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateinvoicebtn.ForeColor = System.Drawing.Color.White;
            this.generateinvoicebtn.Location = new System.Drawing.Point(737, 90);
            this.generateinvoicebtn.Name = "generateinvoicebtn";
            this.generateinvoicebtn.Size = new System.Drawing.Size(205, 41);
            this.generateinvoicebtn.TabIndex = 67;
            this.generateinvoicebtn.Text = "Generate Invoice";
            this.generateinvoicebtn.UseVisualStyleBackColor = false;
            this.generateinvoicebtn.Click += new System.EventHandler(this.generateinvoicebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(757, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Customer\'s Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(19, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "♦Check Stock";
            // 
            // txtcustomername
            // 
            this.txtcustomername.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtcustomername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcustomername.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.Location = new System.Drawing.Point(626, 12);
            this.txtcustomername.Multiline = true;
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(378, 35);
            this.txtcustomername.TabIndex = 63;
            this.txtcustomername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCICode
            // 
            this.txtCICode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCICode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCICode.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCICode.Location = new System.Drawing.Point(202, 12);
            this.txtCICode.Multiline = true;
            this.txtCICode.Name = "txtCICode";
            this.txtCICode.Size = new System.Drawing.Size(378, 35);
            this.txtCICode.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(347, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Items Code";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // checkitemtxtbtn
            // 
            this.checkitemtxtbtn.BackColor = System.Drawing.Color.DarkRed;
            this.checkitemtxtbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkitemtxtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkitemtxtbtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkitemtxtbtn.ForeColor = System.Drawing.Color.White;
            this.checkitemtxtbtn.Location = new System.Drawing.Point(351, 89);
            this.checkitemtxtbtn.Name = "checkitemtxtbtn";
            this.checkitemtxtbtn.Size = new System.Drawing.Size(109, 42);
            this.checkitemtxtbtn.TabIndex = 24;
            this.checkitemtxtbtn.Text = "Check";
            this.checkitemtxtbtn.UseVisualStyleBackColor = false;
            this.checkitemtxtbtn.Click += new System.EventHandler(this.checkitemtxtbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(53, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 66);
            this.panel1.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "• CREATE INVOICE";
            // 
            // dataGridViewresult
            // 
            this.dataGridViewresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewresult.Location = new System.Drawing.Point(53, 243);
            this.dataGridViewresult.Name = "dataGridViewresult";
            this.dataGridViewresult.RowHeadersWidth = 51;
            this.dataGridViewresult.RowTemplate.Height = 24;
            this.dataGridViewresult.Size = new System.Drawing.Size(1053, 258);
            this.dataGridViewresult.TabIndex = 82;
            this.dataGridViewresult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewresult_CellContentClick);
            // 
            // createinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 591);
            this.Controls.Add(this.dataGridViewresult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createinvoice";
            this.Text = "Cinvoice";
            this.Load += new System.EventHandler(this.createinvoice_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewresult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCICode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button checkitemtxtbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewresult;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateinvoicebtn;
    }
}