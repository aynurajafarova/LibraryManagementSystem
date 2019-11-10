namespace LibraryManagementSystem.Forms
{
    partial class ReturnBookForm
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblClient = new System.Windows.Forms.Label();
            this.CmbMember = new System.Windows.Forms.ComboBox();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.LblAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblReturningBook = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.DgvOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtReturningBook = new System.Windows.Forms.TextBox();
            this.TxtPayment = new System.Windows.Forms.TextBox();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(478, 403);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(118, 40);
            this.BtnCancel.TabIndex = 25;
            this.BtnCancel.Text = "Sifarişi ləğv et";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Visible = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.Location = new System.Drawing.Point(106, 8);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(58, 13);
            this.LblClient.TabIndex = 24;
            this.LblClient.Text = "Istifadechi:";
            // 
            // CmbMember
            // 
            this.CmbMember.FormattingEnabled = true;
            this.CmbMember.Location = new System.Drawing.Point(106, 28);
            this.CmbMember.Name = "CmbMember";
            this.CmbMember.Size = new System.Drawing.Size(176, 21);
            this.CmbMember.TabIndex = 23;
            this.CmbMember.SelectedIndexChanged += new System.EventHandler(this.CmbMember_SelectedIndexChanged);
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PnlHeader.Controls.Add(this.LblAdd);
            this.PnlHeader.Location = new System.Drawing.Point(106, 68);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(588, 31);
            this.PnlHeader.TabIndex = 22;
            // 
            // LblAdd
            // 
            this.LblAdd.AutoSize = true;
            this.LblAdd.Location = new System.Drawing.Point(3, 9);
            this.LblAdd.Name = "LblAdd";
            this.LblAdd.Size = new System.Drawing.Size(100, 13);
            this.LblAdd.TabIndex = 5;
            this.LblAdd.Text = "Click to return Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ödəniş";
            // 
            // LblReturningBook
            // 
            this.LblReturningBook.AutoSize = true;
            this.LblReturningBook.Location = new System.Drawing.Point(106, 402);
            this.LblReturningBook.Name = "LblReturningBook";
            this.LblReturningBook.Size = new System.Drawing.Size(92, 13);
            this.LblReturningBook.TabIndex = 19;
            this.LblReturningBook.Text = "Qaytarılacaq kitab";
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(602, 402);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(92, 40);
            this.BtnReturn.TabIndex = 17;
            this.BtnReturn.Text = "Qaytar";
            this.BtnReturn.UseVisualStyleBackColor = false;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
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
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.DgvOrders.Location = new System.Drawing.Point(106, 99);
            this.DgvOrders.Name = "DgvOrders";
            this.DgvOrders.ReadOnly = true;
            this.DgvOrders.Size = new System.Drawing.Size(588, 274);
            this.DgvOrders.TabIndex = 16;
            this.DgvOrders.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvOrders_RowHeaderMouseClick);
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
            this.Column2.HeaderText = "Kitabın adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Götürüldüyü tarix";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tehvil verildiyi tarix";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Məbləğ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Qaytarıldı";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // TxtReturningBook
            // 
            this.TxtReturningBook.Location = new System.Drawing.Point(106, 419);
            this.TxtReturningBook.Name = "TxtReturningBook";
            this.TxtReturningBook.Size = new System.Drawing.Size(100, 20);
            this.TxtReturningBook.TabIndex = 26;
            // 
            // TxtPayment
            // 
            this.TxtPayment.Location = new System.Drawing.Point(296, 422);
            this.TxtPayment.Name = "TxtPayment";
            this.TxtPayment.Size = new System.Drawing.Size(100, 20);
            this.TxtPayment.TabIndex = 27;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPayment);
            this.Controls.Add(this.TxtReturningBook);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblClient);
            this.Controls.Add(this.CmbMember);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblReturningBook);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.DgvOrders);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblClient;
        private System.Windows.Forms.ComboBox CmbMember;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Label LblAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblReturningBook;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.DataGridView DgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox TxtReturningBook;
        private System.Windows.Forms.TextBox TxtPayment;
    }
}