namespace WindowsFormsAppIMS2
{
    partial class ModifyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMICode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.insertitmbtn = new System.Windows.Forms.Button();
            this.dataGridViewModifyFrm = new System.Windows.Forms.DataGridView();
            this.dateTimePickerM = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MtxtNa = new System.Windows.Forms.TextBox();
            this.MtxtPr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.MtxtQu = new System.Windows.Forms.TextBox();
            this.MtxtCa = new System.Windows.Forms.TextBox();
            this.MtxtMa = new System.Windows.Forms.TextBox();
            this.MitemBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyFrm)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 66);
            this.panel1.TabIndex = 82;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "•MODIFY";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMICode);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.insertitmbtn);
            this.panel2.Location = new System.Drawing.Point(25, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 254);
            this.panel2.TabIndex = 83;
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
            // txtMICode
            // 
            this.txtMICode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMICode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMICode.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMICode.Location = new System.Drawing.Point(104, 85);
            this.txtMICode.Multiline = true;
            this.txtMICode.Name = "txtMICode";
            this.txtMICode.Size = new System.Drawing.Size(258, 35);
            this.txtMICode.TabIndex = 63;
            this.txtMICode.TextChanged += new System.EventHandler(this.txtMICode_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Items Code";
            // 
            // insertitmbtn
            // 
            this.insertitmbtn.BackColor = System.Drawing.Color.DarkRed;
            this.insertitmbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.insertitmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertitmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertitmbtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertitmbtn.ForeColor = System.Drawing.Color.White;
            this.insertitmbtn.Location = new System.Drawing.Point(179, 190);
            this.insertitmbtn.Name = "insertitmbtn";
            this.insertitmbtn.Size = new System.Drawing.Size(110, 41);
            this.insertitmbtn.TabIndex = 24;
            this.insertitmbtn.Text = "Insert";
            this.insertitmbtn.UseVisualStyleBackColor = false;
            this.insertitmbtn.Click += new System.EventHandler(this.insertitmbtn_Click);
            // 
            // dataGridViewModifyFrm
            // 
            this.dataGridViewModifyFrm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModifyFrm.Location = new System.Drawing.Point(25, 344);
            this.dataGridViewModifyFrm.Name = "dataGridViewModifyFrm";
            this.dataGridViewModifyFrm.RowHeadersWidth = 51;
            this.dataGridViewModifyFrm.RowTemplate.Height = 24;
            this.dataGridViewModifyFrm.Size = new System.Drawing.Size(1098, 235);
            this.dataGridViewModifyFrm.TabIndex = 84;
            this.dataGridViewModifyFrm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewModifyFrm_CellContentClick);
            // 
            // dateTimePickerM
            // 
            this.dateTimePickerM.Location = new System.Drawing.Point(276, 161);
            this.dateTimePickerM.Name = "dateTimePickerM";
            this.dateTimePickerM.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerM.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "Category";
            // 
            // MtxtNa
            // 
            this.MtxtNa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MtxtNa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxtNa.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtNa.Location = new System.Drawing.Point(276, 5);
            this.MtxtNa.Multiline = true;
            this.MtxtNa.Name = "MtxtNa";
            this.MtxtNa.Size = new System.Drawing.Size(262, 20);
            this.MtxtNa.TabIndex = 95;
            // 
            // MtxtPr
            // 
            this.MtxtPr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MtxtPr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxtPr.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtPr.Location = new System.Drawing.Point(276, 33);
            this.MtxtPr.Multiline = true;
            this.MtxtPr.Name = "MtxtPr";
            this.MtxtPr.Size = new System.Drawing.Size(262, 22);
            this.MtxtPr.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 89;
            this.label6.Text = "Inlist Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 87;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 88;
            this.label2.Text = "Manufacturer";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.09452F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.90548F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MtxtNa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MtxtPr, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerM, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.MtxtQu, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.MtxtCa, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.MtxtMa, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.54099F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.45901F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(543, 194);
            this.tableLayoutPanel2.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 99;
            this.label7.Text = "Item Name";
            // 
            // MtxtQu
            // 
            this.MtxtQu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MtxtQu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxtQu.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtQu.Location = new System.Drawing.Point(276, 63);
            this.MtxtQu.Multiline = true;
            this.MtxtQu.Name = "MtxtQu";
            this.MtxtQu.Size = new System.Drawing.Size(262, 24);
            this.MtxtQu.TabIndex = 96;
            // 
            // MtxtCa
            // 
            this.MtxtCa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MtxtCa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxtCa.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtCa.Location = new System.Drawing.Point(276, 95);
            this.MtxtCa.Multiline = true;
            this.MtxtCa.Name = "MtxtCa";
            this.MtxtCa.Size = new System.Drawing.Size(262, 24);
            this.MtxtCa.TabIndex = 96;
            // 
            // MtxtMa
            // 
            this.MtxtMa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MtxtMa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtxtMa.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtMa.Location = new System.Drawing.Point(276, 129);
            this.MtxtMa.Multiline = true;
            this.MtxtMa.Name = "MtxtMa";
            this.MtxtMa.Size = new System.Drawing.Size(262, 24);
            this.MtxtMa.TabIndex = 96;
            // 
            // MitemBtn
            // 
            this.MitemBtn.BackColor = System.Drawing.Color.DarkRed;
            this.MitemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MitemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MitemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MitemBtn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MitemBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MitemBtn.Location = new System.Drawing.Point(224, 203);
            this.MitemBtn.Name = "MitemBtn";
            this.MitemBtn.Size = new System.Drawing.Size(110, 41);
            this.MitemBtn.TabIndex = 101;
            this.MitemBtn.Text = "Modify ";
            this.MitemBtn.UseVisualStyleBackColor = false;
            this.MitemBtn.Click += new System.EventHandler(this.MitemBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Controls.Add(this.MitemBtn);
            this.panel3.Location = new System.Drawing.Point(529, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 254);
            this.panel3.TabIndex = 84;
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 591);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewModifyFrm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyForm";
            this.Text = "Modify";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModifyFrm)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMICode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button insertitmbtn;
        private System.Windows.Forms.DataGridView dataGridViewModifyFrm;
        private System.Windows.Forms.DateTimePicker dateTimePickerM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MtxtNa;
        private System.Windows.Forms.TextBox MtxtPr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox MtxtQu;
        private System.Windows.Forms.TextBox MtxtCa;
        private System.Windows.Forms.TextBox MtxtMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button MitemBtn;
        private System.Windows.Forms.Panel panel3;
    }
}