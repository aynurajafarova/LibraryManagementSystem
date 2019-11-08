namespace LibraryManagementSystem.Forms
{
    partial class ViewAllBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllBooksForm));
            this.DgvViewAllBooks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSearchBook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumBookPrice = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtBookAuthor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtBookName = new System.Windows.Forms.TextBox();
            this.BtnBackArrow = new System.Windows.Forms.Button();
            this.BtnEditBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllBooks)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBookPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvViewAllBooks
            // 
            this.DgvViewAllBooks.AllowUserToAddRows = false;
            this.DgvViewAllBooks.AllowUserToDeleteRows = false;
            this.DgvViewAllBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvViewAllBooks.BackgroundColor = System.Drawing.Color.White;
            this.DgvViewAllBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvViewAllBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvViewAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvViewAllBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BooksName,
            this.BooksAuthor,
            this.Price,
            this.Quantity,
            this.PurchaseDate});
            this.DgvViewAllBooks.GridColor = System.Drawing.Color.CadetBlue;
            this.DgvViewAllBooks.Location = new System.Drawing.Point(159, 256);
            this.DgvViewAllBooks.Name = "DgvViewAllBooks";
            this.DgvViewAllBooks.ReadOnly = true;
            this.DgvViewAllBooks.Size = new System.Drawing.Size(970, 343);
            this.DgvViewAllBooks.TabIndex = 3;
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
            this.BooksName.HeaderText = "Kitabın adı:";
            this.BooksName.Name = "BooksName";
            this.BooksName.ReadOnly = true;
            // 
            // BooksAuthor
            // 
            this.BooksAuthor.HeaderText = "Müəllif:";
            this.BooksAuthor.Name = "BooksAuthor";
            this.BooksAuthor.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Qiymət:";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Say:";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.HeaderText = "Tarix:";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            // 
            // BtnSearchBook
            // 
            this.BtnSearchBook.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearchBook.BackgroundImage")));
            this.BtnSearchBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearchBook.FlatAppearance.BorderSize = 0;
            this.BtnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchBook.Location = new System.Drawing.Point(828, 42);
            this.BtnSearchBook.Name = "BtnSearchBook";
            this.BtnSearchBook.Size = new System.Drawing.Size(30, 35);
            this.BtnSearchBook.TabIndex = 2;
            this.BtnSearchBook.UseVisualStyleBackColor = false;
            this.BtnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.NumBookPrice);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.TxtBookAuthor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnSearchBook);
            this.panel1.Controls.Add(this.TxtBookName);
            this.panel1.Location = new System.Drawing.Point(159, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 114);
            this.panel1.TabIndex = 6;
            // 
            // NumBookPrice
            // 
            this.NumBookPrice.BackColor = System.Drawing.Color.White;
            this.NumBookPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumBookPrice.DecimalPlaces = 2;
            this.NumBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBookPrice.Location = new System.Drawing.Point(645, 47);
            this.NumBookPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NumBookPrice.Name = "NumBookPrice";
            this.NumBookPrice.Size = new System.Drawing.Size(143, 20);
            this.NumBookPrice.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(645, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 1);
            this.panel3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(639, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kitabın qiyməti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(354, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kitabın müəllifi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kitabın adı:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(357, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 1);
            this.panel4.TabIndex = 19;
            // 
            // TxtBookAuthor
            // 
            this.TxtBookAuthor.BackColor = System.Drawing.Color.White;
            this.TxtBookAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBookAuthor.Location = new System.Drawing.Point(357, 49);
            this.TxtBookAuthor.Multiline = true;
            this.TxtBookAuthor.Name = "TxtBookAuthor";
            this.TxtBookAuthor.Size = new System.Drawing.Size(235, 20);
            this.TxtBookAuthor.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(84, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 1);
            this.panel2.TabIndex = 15;
            // 
            // TxtBookName
            // 
            this.TxtBookName.BackColor = System.Drawing.Color.White;
            this.TxtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBookName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBookName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBookName.Location = new System.Drawing.Point(84, 52);
            this.TxtBookName.Multiline = true;
            this.TxtBookName.Name = "TxtBookName";
            this.TxtBookName.Size = new System.Drawing.Size(235, 20);
            this.TxtBookName.TabIndex = 1;
            // 
            // BtnBackArrow
            // 
            this.BtnBackArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBackArrow.BackgroundImage")));
            this.BtnBackArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBackArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackArrow.FlatAppearance.BorderSize = 0;
            this.BtnBackArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackArrow.Location = new System.Drawing.Point(1287, 56);
            this.BtnBackArrow.Name = "BtnBackArrow";
            this.BtnBackArrow.Size = new System.Drawing.Size(37, 37);
            this.BtnBackArrow.TabIndex = 10;
            this.BtnBackArrow.UseVisualStyleBackColor = true;
            this.BtnBackArrow.Click += new System.EventHandler(this.BtnBackArrow_Click);
            // 
            // BtnEditBooks
            // 
            this.BtnEditBooks.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnEditBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditBooks.FlatAppearance.BorderSize = 0;
            this.BtnEditBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnEditBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditBooks.ForeColor = System.Drawing.Color.White;
            this.BtnEditBooks.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditBooks.Image")));
            this.BtnEditBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditBooks.Location = new System.Drawing.Point(854, 656);
            this.BtnEditBooks.Name = "BtnEditBooks";
            this.BtnEditBooks.Size = new System.Drawing.Size(275, 42);
            this.BtnEditBooks.TabIndex = 11;
            this.BtnEditBooks.Text = "  Kitablar cədvəlində dəyişiklik et";
            this.BtnEditBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditBooks.UseVisualStyleBackColor = false;
            this.BtnEditBooks.Click += new System.EventHandler(this.BtnEditBooks_Click);
            // 
            // ViewAllBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.BtnEditBooks);
            this.Controls.Add(this.BtnBackArrow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvViewAllBooks);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Books:";
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllBooks)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBookPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvViewAllBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.Button BtnSearchBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtBookAuthor;
        private System.Windows.Forms.NumericUpDown NumBookPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBackArrow;
        private System.Windows.Forms.Button BtnEditBooks;
    }
}