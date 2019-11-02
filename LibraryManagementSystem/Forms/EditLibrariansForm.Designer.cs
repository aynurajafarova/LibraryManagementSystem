namespace LibraryManagementSystem.Forms
{
    partial class EditLibrariansForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtLibrarianPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtLibrarianPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtLibrarianEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtLibrarianName = new System.Windows.Forms.TextBox();
            this.DgvViewAllLibrarians = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibrarianName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllLibrarians)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.TxtLibrarianPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.TxtLibrarianPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TxtLibrarianEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TxtLibrarianName);
            this.panel1.Location = new System.Drawing.Point(23, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 282);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefon:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Location = new System.Drawing.Point(8, 248);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 1);
            this.panel5.TabIndex = 24;
            // 
            // TxtLibrarianPhone
            // 
            this.TxtLibrarianPhone.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianPhone.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianPhone.Location = new System.Drawing.Point(8, 228);
            this.TxtLibrarianPhone.Multiline = true;
            this.TxtLibrarianPhone.Name = "TxtLibrarianPhone";
            this.TxtLibrarianPhone.Size = new System.Drawing.Size(223, 20);
            this.TxtLibrarianPhone.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Şifrə:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(8, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 1);
            this.panel4.TabIndex = 21;
            // 
            // TxtLibrarianPassword
            // 
            this.TxtLibrarianPassword.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianPassword.Location = new System.Drawing.Point(8, 173);
            this.TxtLibrarianPassword.Multiline = true;
            this.TxtLibrarianPassword.Name = "TxtLibrarianPassword";
            this.TxtLibrarianPassword.Size = new System.Drawing.Size(223, 20);
            this.TxtLibrarianPassword.TabIndex = 20;
            this.TxtLibrarianPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(8, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 1);
            this.panel3.TabIndex = 18;
            // 
            // TxtLibrarianEmail
            // 
            this.TxtLibrarianEmail.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianEmail.Location = new System.Drawing.Point(8, 115);
            this.TxtLibrarianEmail.Multiline = true;
            this.TxtLibrarianEmail.Name = "TxtLibrarianEmail";
            this.TxtLibrarianEmail.Size = new System.Drawing.Size(223, 20);
            this.TxtLibrarianEmail.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adı:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(8, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 1);
            this.panel2.TabIndex = 15;
            // 
            // TxtLibrarianName
            // 
            this.TxtLibrarianName.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianName.Location = new System.Drawing.Point(8, 58);
            this.TxtLibrarianName.Multiline = true;
            this.TxtLibrarianName.Name = "TxtLibrarianName";
            this.TxtLibrarianName.Size = new System.Drawing.Size(223, 20);
            this.TxtLibrarianName.TabIndex = 14;
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
            this.Id,
            this.LibrarianName,
            this.Email,
            this.Password,
            this.Phone});
            this.DgvViewAllLibrarians.GridColor = System.Drawing.Color.CadetBlue;
            this.DgvViewAllLibrarians.Location = new System.Drawing.Point(299, 28);
            this.DgvViewAllLibrarians.Name = "DgvViewAllLibrarians";
            this.DgvViewAllLibrarians.ReadOnly = true;
            this.DgvViewAllLibrarians.Size = new System.Drawing.Size(706, 343);
            this.DgvViewAllLibrarians.TabIndex = 2;
            this.DgvViewAllLibrarians.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvViewAllLibrarians_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // LibrarianName
            // 
            this.LibrarianName.HeaderText = "Adı:";
            this.LibrarianName.Name = "LibrarianName";
            this.LibrarianName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Şifrə:";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Telefon:";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(157, 369);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(105, 43);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(32, 369);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(105, 43);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Yenilə";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(32, 369);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(231, 43);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Əlavə et:";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // EditLibrariansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1043, 528);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.DgvViewAllLibrarians);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditLibrariansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMembersForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllLibrarians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtLibrarianName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtLibrarianPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtLibrarianEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxtLibrarianPhone;
        private System.Windows.Forms.DataGridView DgvViewAllLibrarians;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibrarianName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
    }
}