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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLibrariansForm));
            this.DgvViewAllLibrarians = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibrarianName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtLibrarianPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TxtLibrarianPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TxtLibrarianEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.TxtLibrarianName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnBackArrow = new System.Windows.Forms.Button();
            this.BtnEditLibrarians = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllLibrarians)).BeginInit();
            this.panel6.SuspendLayout();
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
            this.Id,
            this.LibrarianName,
            this.Email,
            this.Password,
            this.Phone});
            this.DgvViewAllLibrarians.GridColor = System.Drawing.Color.CadetBlue;
            this.DgvViewAllLibrarians.Location = new System.Drawing.Point(581, 140);
            this.DgvViewAllLibrarians.Name = "DgvViewAllLibrarians";
            this.DgvViewAllLibrarians.ReadOnly = true;
            this.DgvViewAllLibrarians.Size = new System.Drawing.Size(695, 360);
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
            this.BtnDelete.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(220, 275);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 40);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(115, 275);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(95, 40);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Yenilə";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(115, 275);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(200, 40);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Əlavə et:";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.BtnDelete);
            this.panel6.Controls.Add(this.BtnUpdate);
            this.panel6.Controls.Add(this.BtnAdd);
            this.panel6.Controls.Add(this.TxtLibrarianPhone);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.TxtLibrarianPassword);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.TxtLibrarianEmail);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.TxtLibrarianName);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(105, 140);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(426, 360);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel7.Location = new System.Drawing.Point(133, 234);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 1);
            this.panel7.TabIndex = 22;
            // 
            // TxtLibrarianPhone
            // 
            this.TxtLibrarianPhone.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianPhone.Location = new System.Drawing.Point(133, 212);
            this.TxtLibrarianPhone.Multiline = true;
            this.TxtLibrarianPhone.Name = "TxtLibrarianPhone";
            this.TxtLibrarianPhone.Size = new System.Drawing.Size(250, 20);
            this.TxtLibrarianPhone.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefon:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel8.Location = new System.Drawing.Point(133, 192);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 1);
            this.panel8.TabIndex = 20;
            // 
            // TxtLibrarianPassword
            // 
            this.TxtLibrarianPassword.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianPassword.Location = new System.Drawing.Point(133, 170);
            this.TxtLibrarianPassword.Multiline = true;
            this.TxtLibrarianPassword.Name = "TxtLibrarianPassword";
            this.TxtLibrarianPassword.Size = new System.Drawing.Size(250, 20);
            this.TxtLibrarianPassword.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Şifrə:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel9.Location = new System.Drawing.Point(132, 152);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 1);
            this.panel9.TabIndex = 16;
            // 
            // TxtLibrarianEmail
            // 
            this.TxtLibrarianEmail.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianEmail.Location = new System.Drawing.Point(132, 130);
            this.TxtLibrarianEmail.Multiline = true;
            this.TxtLibrarianEmail.Name = "TxtLibrarianEmail";
            this.TxtLibrarianEmail.Size = new System.Drawing.Size(250, 20);
            this.TxtLibrarianEmail.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel10.Location = new System.Drawing.Point(132, 110);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(250, 1);
            this.panel10.TabIndex = 13;
            // 
            // TxtLibrarianName
            // 
            this.TxtLibrarianName.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianName.Location = new System.Drawing.Point(132, 88);
            this.TxtLibrarianName.Multiline = true;
            this.TxtLibrarianName.Name = "TxtLibrarianName";
            this.TxtLibrarianName.Size = new System.Drawing.Size(250, 20);
            this.TxtLibrarianName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "İdarəçinin adı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(150, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Yeni idarəçi:";
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
            this.BtnBackArrow.TabIndex = 8;
            this.BtnBackArrow.UseVisualStyleBackColor = true;
            this.BtnBackArrow.Click += new System.EventHandler(this.BtnBackArrow_Click);
            // 
            // BtnEditLibrarians
            // 
            this.BtnEditLibrarians.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnEditLibrarians.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditLibrarians.FlatAppearance.BorderSize = 0;
            this.BtnEditLibrarians.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnEditLibrarians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditLibrarians.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditLibrarians.ForeColor = System.Drawing.Color.White;
            this.BtnEditLibrarians.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditLibrarians.Image")));
            this.BtnEditLibrarians.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditLibrarians.Location = new System.Drawing.Point(1080, 577);
            this.BtnEditLibrarians.Name = "BtnEditLibrarians";
            this.BtnEditLibrarians.Size = new System.Drawing.Size(196, 42);
            this.BtnEditLibrarians.TabIndex = 9;
            this.BtnEditLibrarians.Text = "  Ana səhifəyə qayıt";
            this.BtnEditLibrarians.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditLibrarians.UseVisualStyleBackColor = false;
            this.BtnEditLibrarians.Click += new System.EventHandler(this.BtnEditLibrarians_Click);
            // 
            // EditLibrariansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.BtnEditLibrarians);
            this.Controls.Add(this.BtnBackArrow);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.DgvViewAllLibrarians);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditLibrariansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMembersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllLibrarians)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvViewAllLibrarians;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibrarianName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox TxtLibrarianEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox TxtLibrarianName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TxtLibrarianPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TxtLibrarianPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBackArrow;
        private System.Windows.Forms.Button BtnEditLibrarians;
    }
}