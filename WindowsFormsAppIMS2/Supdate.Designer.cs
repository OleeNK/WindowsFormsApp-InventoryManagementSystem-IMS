namespace WindowsFormsAppIMS2
{
    partial class stockupdate
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtdeleteitems = new System.Windows.Forms.Button();
            this.txtmodifyitems = new System.Windows.Forms.Button();
            this.txtadditems = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 67;
            this.label8.Text = "Quantity";
            // 
            // txtdeleteitems
            // 
            this.txtdeleteitems.BackColor = System.Drawing.Color.Red;
            this.txtdeleteitems.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeleteitems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdeleteitems.Location = new System.Drawing.Point(704, 226);
            this.txtdeleteitems.Name = "txtdeleteitems";
            this.txtdeleteitems.Size = new System.Drawing.Size(139, 41);
            this.txtdeleteitems.TabIndex = 65;
            this.txtdeleteitems.Text = "Delete Item";
            this.txtdeleteitems.UseVisualStyleBackColor = false;
            this.txtdeleteitems.Click += new System.EventHandler(this.txtdeleteitems_Click);
            // 
            // txtmodifyitems
            // 
            this.txtmodifyitems.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtmodifyitems.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodifyitems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtmodifyitems.Location = new System.Drawing.Point(453, 228);
            this.txtmodifyitems.Name = "txtmodifyitems";
            this.txtmodifyitems.Size = new System.Drawing.Size(139, 41);
            this.txtmodifyitems.TabIndex = 64;
            this.txtmodifyitems.Text = "Modify Item";
            this.txtmodifyitems.UseVisualStyleBackColor = false;
            this.txtmodifyitems.Click += new System.EventHandler(this.txtmodifyitems_Click);
            // 
            // txtadditems
            // 
            this.txtadditems.BackColor = System.Drawing.Color.SeaGreen;
            this.txtadditems.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadditems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtadditems.Location = new System.Drawing.Point(205, 226);
            this.txtadditems.Name = "txtadditems";
            this.txtadditems.Size = new System.Drawing.Size(139, 41);
            this.txtadditems.TabIndex = 63;
            this.txtadditems.Text = "Add Item";
            this.txtadditems.UseVisualStyleBackColor = false;
            this.txtadditems.Click += new System.EventHandler(this.txtadditems_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(907, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "Inlist Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(713, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Manufacturer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Price";
            // 
            // txtcategory
            // 
            this.txtcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcategory.Location = new System.Drawing.Point(399, 156);
            this.txtcategory.Multiline = true;
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(143, 33);
            this.txtcategory.TabIndex = 60;
            this.txtcategory.Text = " ";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(241, 158);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 33);
            this.txtPrice.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Items Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(55, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 52);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "• STOCK MANAGER";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(399, 158);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(143, 33);
            this.txtQuantity.TabIndex = 62;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(561, 156);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 33);
            this.textBox2.TabIndex = 60;
            this.textBox2.Text = " ";
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(75, 158);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(143, 33);
            this.txtItemName.TabIndex = 62;
            // 
            // textCategory
            // 
            this.textCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCategory.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategory.Location = new System.Drawing.Point(561, 158);
            this.textCategory.Multiline = true;
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(143, 33);
            this.textCategory.TabIndex = 62;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtManufacturer.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(718, 158);
            this.txtManufacturer.Multiline = true;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(143, 33);
            this.txtManufacturer.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 185);
            this.dataGridView1.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 68;
            this.label2.Text = "Items List : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(878, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 70;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = global::WindowsFormsAppIMS2.Properties.Resources.edit;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(420, 236);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(27, 29);
            this.button11.TabIndex = 56;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::WindowsFormsAppIMS2.Properties.Resources.trash;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(672, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 28);
            this.button9.TabIndex = 49;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::WindowsFormsAppIMS2.Properties.Resources.add;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(174, 236);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 25);
            this.button7.TabIndex = 53;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // stockupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 591);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtdeleteitems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmodifyitems);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtadditems);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stockupdate";
            this.Text = "Supdate";
            this.Load += new System.EventHandler(this.stockupdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtdeleteitems;
        private System.Windows.Forms.Button txtmodifyitems;
        private System.Windows.Forms.Button txtadditems;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}