namespace WindowsFormsAppIMS2
{
    partial class setting
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
            this.userDetailsLabel = new System.Windows.Forms.Label();
            this.totalStockLabel = new System.Windows.Forms.Label();
            this.totalStockSoldLabel = new System.Windows.Forms.Label();
            this.dataGridViewtbl1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewtbl2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewtbl3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewtbl4 = new System.Windows.Forms.DataGridView();
            this.totalStockReturnLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtbl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtbl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtbl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtbl4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(33, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 66);
            this.panel1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "• SETTINGS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.totalStockReturnLabel);
            this.panel2.Controls.Add(this.dataGridViewtbl4);
            this.panel2.Controls.Add(this.dataGridViewtbl3);
            this.panel2.Controls.Add(this.dataGridViewtbl2);
            this.panel2.Controls.Add(this.dataGridViewtbl1);
            this.panel2.Controls.Add(this.totalStockSoldLabel);
            this.panel2.Controls.Add(this.totalStockLabel);
            this.panel2.Controls.Add(this.userDetailsLabel);
            this.panel2.Location = new System.Drawing.Point(33, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 449);
            this.panel2.TabIndex = 83;
            // 
            // userDetailsLabel
            // 
            this.userDetailsLabel.AutoSize = true;
            this.userDetailsLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetailsLabel.Location = new System.Drawing.Point(50, 39);
            this.userDetailsLabel.Name = "userDetailsLabel";
            this.userDetailsLabel.Size = new System.Drawing.Size(110, 23);
            this.userDetailsLabel.TabIndex = 0;
            this.userDetailsLabel.Text = "User Details ";
            this.userDetailsLabel.Click += new System.EventHandler(this.userDetailsLabel_Click);
            // 
            // totalStockLabel
            // 
            this.totalStockLabel.AutoSize = true;
            this.totalStockLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockLabel.Location = new System.Drawing.Point(50, 155);
            this.totalStockLabel.Name = "totalStockLabel";
            this.totalStockLabel.Size = new System.Drawing.Size(103, 23);
            this.totalStockLabel.TabIndex = 0;
            this.totalStockLabel.Text = "Total Stock ";
            this.totalStockLabel.Click += new System.EventHandler(this.totalStockLabel_Click);
            // 
            // totalStockSoldLabel
            // 
            this.totalStockSoldLabel.AutoSize = true;
            this.totalStockSoldLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockSoldLabel.Location = new System.Drawing.Point(50, 255);
            this.totalStockSoldLabel.Name = "totalStockSoldLabel";
            this.totalStockSoldLabel.Size = new System.Drawing.Size(139, 23);
            this.totalStockSoldLabel.TabIndex = 0;
            this.totalStockSoldLabel.Text = "Total Stock Sold";
            this.totalStockSoldLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridViewtbl1
            // 
            this.dataGridViewtbl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtbl1.Location = new System.Drawing.Point(245, 12);
            this.dataGridViewtbl1.Name = "dataGridViewtbl1";
            this.dataGridViewtbl1.RowHeadersWidth = 51;
            this.dataGridViewtbl1.RowTemplate.Height = 24;
            this.dataGridViewtbl1.Size = new System.Drawing.Size(774, 91);
            this.dataGridViewtbl1.TabIndex = 1;
            // 
            // dataGridViewtbl2
            // 
            this.dataGridViewtbl2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtbl2.Location = new System.Drawing.Point(245, 121);
            this.dataGridViewtbl2.Name = "dataGridViewtbl2";
            this.dataGridViewtbl2.RowHeadersWidth = 51;
            this.dataGridViewtbl2.RowTemplate.Height = 24;
            this.dataGridViewtbl2.Size = new System.Drawing.Size(774, 94);
            this.dataGridViewtbl2.TabIndex = 1;
            // 
            // dataGridViewtbl3
            // 
            this.dataGridViewtbl3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtbl3.Location = new System.Drawing.Point(245, 233);
            this.dataGridViewtbl3.Name = "dataGridViewtbl3";
            this.dataGridViewtbl3.RowHeadersWidth = 51;
            this.dataGridViewtbl3.RowTemplate.Height = 24;
            this.dataGridViewtbl3.Size = new System.Drawing.Size(774, 92);
            this.dataGridViewtbl3.TabIndex = 1;
            // 
            // dataGridViewtbl4
            // 
            this.dataGridViewtbl4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtbl4.Location = new System.Drawing.Point(245, 343);
            this.dataGridViewtbl4.Name = "dataGridViewtbl4";
            this.dataGridViewtbl4.RowHeadersWidth = 51;
            this.dataGridViewtbl4.RowTemplate.Height = 24;
            this.dataGridViewtbl4.Size = new System.Drawing.Size(774, 92);
            this.dataGridViewtbl4.TabIndex = 1;
            // 
            // totalStockReturnLabel
            // 
            this.totalStockReturnLabel.AutoSize = true;
            this.totalStockReturnLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStockReturnLabel.Location = new System.Drawing.Point(50, 369);
            this.totalStockReturnLabel.Name = "totalStockReturnLabel";
            this.totalStockReturnLabel.Size = new System.Drawing.Size(157, 23);
            this.totalStockReturnLabel.TabIndex = 2;
            this.totalStockReturnLabel.Text = "Total Stock Return";
            this.totalStockReturnLabel.Click += new System.EventHandler(this.totalStockReturnLabel_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.Text = "Sset";
            this.Load += new System.EventHandler(this.setting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtbl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtbl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtbl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtbl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalStockLabel;
        private System.Windows.Forms.Label userDetailsLabel;
        private System.Windows.Forms.Label totalStockSoldLabel;
        private System.Windows.Forms.DataGridView dataGridViewtbl2;
        private System.Windows.Forms.DataGridView dataGridViewtbl1;
        private System.Windows.Forms.DataGridView dataGridViewtbl3;
        private System.Windows.Forms.DataGridView dataGridViewtbl4;
        private System.Windows.Forms.Label totalStockReturnLabel;
    }
}