namespace LibraryManagementSystem.Forms
{
    partial class ViewAllLibrariansForm
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
            this.DgvViewAllLibrarians = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllLibrarians)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvViewAllLibrarians
            // 
            this.DgvViewAllLibrarians.AllowUserToAddRows = false;
            this.DgvViewAllLibrarians.AllowUserToDeleteRows = false;
            this.DgvViewAllLibrarians.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvViewAllLibrarians.BackgroundColor = System.Drawing.Color.White;
            this.DgvViewAllLibrarians.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvViewAllLibrarians.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvViewAllLibrarians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvViewAllLibrarians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Password,
            this.Email,
            this.Phone});
            this.DgvViewAllLibrarians.GridColor = System.Drawing.Color.CadetBlue;
            this.DgvViewAllLibrarians.Location = new System.Drawing.Point(19, 26);
            this.DgvViewAllLibrarians.Name = "DgvViewAllLibrarians";
            this.DgvViewAllLibrarians.ReadOnly = true;
            this.DgvViewAllLibrarians.Size = new System.Drawing.Size(701, 292);
            this.DgvViewAllLibrarians.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username:";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password:";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email:";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone:";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // ViewAllLibrariansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(742, 346);
            this.Controls.Add(this.DgvViewAllLibrarians);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewAllLibrariansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Librarians:";
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllLibrarians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvViewAllLibrarians;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}