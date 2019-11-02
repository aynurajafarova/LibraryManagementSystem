namespace LibraryManagementSystem.Forms
{
    partial class EditBooksForm
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
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtBookQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtBookPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtBookAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AllowUserToDeleteRows = false;
            this.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BooksName,
            this.BooksAuthor,
            this.Price,
            this.Quantity});
            this.DgvBooks.GridColor = System.Drawing.Color.CadetBlue;
            this.DgvBooks.Location = new System.Drawing.Point(348, 39);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            this.DgvBooks.Size = new System.Drawing.Size(675, 343);
            this.DgvBooks.TabIndex = 2;
            this.DgvBooks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBooks_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // BooksName
            // 
            this.BooksName.HeaderText = "Title of the book:";
            this.BooksName.Name = "BooksName";
            this.BooksName.ReadOnly = true;
            // 
            // BooksAuthor
            // 
            this.BooksAuthor.HeaderText = "Book author:";
            this.BooksAuthor.Name = "BooksAuthor";
            this.BooksAuthor.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price:";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity:";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.TxtBookQuantity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.TxtBookPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TxtBookAuthor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TxtBookName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 355);
            this.panel1.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnDelete.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(159, 281);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(117, 40);
            this.BtnDelete.TabIndex = 26;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnUpdate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(26, 281);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(111, 40);
            this.BtnUpdate.TabIndex = 25;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Location = new System.Drawing.Point(26, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 1);
            this.panel5.TabIndex = 24;
            // 
            // TxtBookQuantity
            // 
            this.TxtBookQuantity.BackColor = System.Drawing.Color.White;
            this.TxtBookQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtBookQuantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBookQuantity.Location = new System.Drawing.Point(26, 213);
            this.TxtBookQuantity.Multiline = true;
            this.TxtBookQuantity.Name = "TxtBookQuantity";
            this.TxtBookQuantity.Size = new System.Drawing.Size(250, 20);
            this.TxtBookQuantity.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantity:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(26, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 1);
            this.panel4.TabIndex = 21;
            // 
            // TxtBookPrice
            // 
            this.TxtBookPrice.BackColor = System.Drawing.Color.White;
            this.TxtBookPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtBookPrice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBookPrice.Location = new System.Drawing.Point(26, 155);
            this.TxtBookPrice.Multiline = true;
            this.TxtBookPrice.Name = "TxtBookPrice";
            this.TxtBookPrice.Size = new System.Drawing.Size(250, 20);
            this.TxtBookPrice.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(26, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 18;
            // 
            // TxtBookAuthor
            // 
            this.TxtBookAuthor.BackColor = System.Drawing.Color.White;
            this.TxtBookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtBookAuthor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBookAuthor.Location = new System.Drawing.Point(26, 98);
            this.TxtBookAuthor.Multiline = true;
            this.TxtBookAuthor.Name = "TxtBookAuthor";
            this.TxtBookAuthor.Size = new System.Drawing.Size(250, 20);
            this.TxtBookAuthor.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Book author:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(26, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 15;
            // 
            // TxtBookName
            // 
            this.TxtBookName.BackColor = System.Drawing.Color.White;
            this.TxtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtBookName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBookName.Location = new System.Drawing.Point(26, 45);
            this.TxtBookName.Multiline = true;
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(250, 20);
            this.TxtBookName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title of the book:";
            // 
            // EditBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvBooks);
            this.Name = "EditBooksForm";
            this.Text = "EditBooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxtBookQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtBookPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtBookAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}