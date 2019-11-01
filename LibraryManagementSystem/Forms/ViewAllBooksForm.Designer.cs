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
            this.DgvViewAllBooks = new System.Windows.Forms.DataGridView();
            this.BooksName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllBooks)).BeginInit();
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
            this.BooksName,
            this.BooksAuthor,
            this.Price,
            this.Quantity});
            this.DgvViewAllBooks.GridColor = System.Drawing.Color.CadetBlue;
            this.DgvViewAllBooks.Location = new System.Drawing.Point(29, 33);
            this.DgvViewAllBooks.Name = "DgvViewAllBooks";
            this.DgvViewAllBooks.ReadOnly = true;
            this.DgvViewAllBooks.Size = new System.Drawing.Size(706, 343);
            this.DgvViewAllBooks.TabIndex = 1;
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
            // ViewAllBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(762, 412);
            this.Controls.Add(this.DgvViewAllBooks);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewAllBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Books:";
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvViewAllBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}