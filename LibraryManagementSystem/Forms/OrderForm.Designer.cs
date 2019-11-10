namespace LibraryManagementSystem.Forms
{
    partial class OrderForm
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
            this.LblMember = new System.Windows.Forms.Label();
            this.CmbMember = new System.Windows.Forms.ComboBox();
            this.LblReturnedTime = new System.Windows.Forms.Label();
            this.LblOrderingBook = new System.Windows.Forms.Label();
            this.DtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.BtnAddOrder = new System.Windows.Forms.Button();
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.DgvAllBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMember
            // 
            this.LblMember.AutoSize = true;
            this.LblMember.Location = new System.Drawing.Point(141, 28);
            this.LblMember.Name = "LblMember";
            this.LblMember.Size = new System.Drawing.Size(114, 13);
            this.LblMember.TabIndex = 22;
            this.LblMember.Text = "Istifadecinin ad,soyadi:";
            // 
            // CmbMember
            // 
            this.CmbMember.FormattingEnabled = true;
            this.CmbMember.Location = new System.Drawing.Point(143, 53);
            this.CmbMember.Name = "CmbMember";
            this.CmbMember.Size = new System.Drawing.Size(154, 21);
            this.CmbMember.TabIndex = 21;
            this.CmbMember.SelectedIndexChanged += new System.EventHandler(this.CmbMember_SelectedIndexChanged);
            // 
            // LblReturnedTime
            // 
            this.LblReturnedTime.AutoSize = true;
            this.LblReturnedTime.Location = new System.Drawing.Point(538, 31);
            this.LblReturnedTime.Name = "LblReturnedTime";
            this.LblReturnedTime.Size = new System.Drawing.Size(109, 13);
            this.LblReturnedTime.TabIndex = 20;
            this.LblReturnedTime.Text = "Geri qaytaracagi tarix:";
            // 
            // LblOrderingBook
            // 
            this.LblOrderingBook.AutoSize = true;
            this.LblOrderingBook.Location = new System.Drawing.Point(337, 28);
            this.LblOrderingBook.Name = "LblOrderingBook";
            this.LblOrderingBook.Size = new System.Drawing.Size(122, 13);
            this.LblOrderingBook.TabIndex = 19;
            this.LblOrderingBook.Text = "Sifarish etdiyi kitabin adi:";
            // 
            // DtpReturnDate
            // 
            this.DtpReturnDate.Location = new System.Drawing.Point(539, 54);
            this.DtpReturnDate.Name = "DtpReturnDate";
            this.DtpReturnDate.Size = new System.Drawing.Size(155, 20);
            this.DtpReturnDate.TabIndex = 17;
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAddOrder.FlatAppearance.BorderSize = 0;
            this.BtnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAddOrder.ForeColor = System.Drawing.Color.White;
            this.BtnAddOrder.Location = new System.Drawing.Point(735, 40);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(110, 34);
            this.BtnAddOrder.TabIndex = 16;
            this.BtnAddOrder.Text = "Elave et";
            this.BtnAddOrder.UseVisualStyleBackColor = false;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // TxtBookName
            // 
            this.TxtBookName.Location = new System.Drawing.Point(340, 53);
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(171, 20);
            this.TxtBookName.TabIndex = 24;
            // 
            // DgvAllBooks
            // 
            this.DgvAllBooks.AllowUserToAddRows = false;
            this.DgvAllBooks.AllowUserToDeleteRows = false;
            this.DgvAllBooks.AllowUserToResizeRows = false;
            this.DgvAllBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAllBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvAllBooks.GridColor = System.Drawing.Color.Black;
            this.DgvAllBooks.Location = new System.Drawing.Point(27, 161);
            this.DgvAllBooks.Name = "DgvAllBooks";
            this.DgvAllBooks.ReadOnly = true;
            this.DgvAllBooks.Size = new System.Drawing.Size(284, 263);
            this.DgvAllBooks.TabIndex = 25;
            this.DgvAllBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAllBooks_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitabin adi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qiymet";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Muellif";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // DgvOrders
            // 
            this.DgvOrders.AllowUserToAddRows = false;
            this.DgvOrders.AllowUserToDeleteRows = false;
            this.DgvOrders.AllowUserToResizeRows = false;
            this.DgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.DgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvOrders.GridColor = System.Drawing.Color.Black;
            this.DgvOrders.Location = new System.Drawing.Point(330, 161);
            this.DgvOrders.Name = "DgvOrders";
            this.DgvOrders.ReadOnly = true;
            this.DgvOrders.Size = new System.Drawing.Size(482, 263);
            this.DgvOrders.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Kitabin adi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Sifarish tarixi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qaytarilacaq tarix";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mebleg";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Qaytarildi";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.DgvOrders);
            this.Controls.Add(this.DgvAllBooks);
            this.Controls.Add(this.TxtBookName);
            this.Controls.Add(this.LblMember);
            this.Controls.Add(this.CmbMember);
            this.Controls.Add(this.LblReturnedTime);
            this.Controls.Add(this.LblOrderingBook);
            this.Controls.Add(this.DtpReturnDate);
            this.Controls.Add(this.BtnAddOrder);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblMember;
        private System.Windows.Forms.ComboBox CmbMember;
        private System.Windows.Forms.Label LblReturnedTime;
        private System.Windows.Forms.Label LblOrderingBook;
        private System.Windows.Forms.DateTimePicker DtpReturnDate;
        private System.Windows.Forms.Button BtnAddOrder;
        private System.Windows.Forms.TextBox TxtBookName;
        private System.Windows.Forms.DataGridView DgvAllBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView DgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}