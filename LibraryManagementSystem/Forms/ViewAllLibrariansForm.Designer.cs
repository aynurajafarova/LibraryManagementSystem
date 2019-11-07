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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllLibrariansForm));
            this.DgvViewAllLibrarians = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBackArrow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtLibrarianPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtLibrarianEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSearchLibrarian = new System.Windows.Forms.Button();
            this.TxtLibrarianName = new System.Windows.Forms.TextBox();
            this.BtnEditLibrarians = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllLibrarians)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.DgvViewAllLibrarians.Location = new System.Drawing.Point(69, 277);
            this.DgvViewAllLibrarians.Name = "DgvViewAllLibrarians";
            this.DgvViewAllLibrarians.ReadOnly = true;
            this.DgvViewAllLibrarians.Size = new System.Drawing.Size(898, 356);
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
            // BtnBackArrow
            // 
            this.BtnBackArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBackArrow.BackgroundImage")));
            this.BtnBackArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBackArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackArrow.FlatAppearance.BorderSize = 0;
            this.BtnBackArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackArrow.Location = new System.Drawing.Point(971, 22);
            this.BtnBackArrow.Name = "BtnBackArrow";
            this.BtnBackArrow.Size = new System.Drawing.Size(37, 37);
            this.BtnBackArrow.TabIndex = 3;
            this.BtnBackArrow.UseVisualStyleBackColor = true;
            this.BtnBackArrow.Click += new System.EventHandler(this.BtnBackArrow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TxtLibrarianPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.TxtLibrarianEmail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnSearchLibrarian);
            this.panel1.Controls.Add(this.TxtLibrarianName);
            this.panel1.Location = new System.Drawing.Point(69, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 114);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(589, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 1);
            this.panel3.TabIndex = 24;
            // 
            // TxtLibrarianPhone
            // 
            this.TxtLibrarianPhone.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianPhone.Location = new System.Drawing.Point(589, 50);
            this.TxtLibrarianPhone.Multiline = true;
            this.TxtLibrarianPhone.Name = "TxtLibrarianPhone";
            this.TxtLibrarianPhone.Size = new System.Drawing.Size(214, 20);
            this.TxtLibrarianPhone.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(588, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Telefon nömrəsi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(299, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "İdarəçinin adı:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(302, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 1);
            this.panel4.TabIndex = 19;
            // 
            // TxtLibrarianEmail
            // 
            this.TxtLibrarianEmail.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianEmail.Location = new System.Drawing.Point(302, 49);
            this.TxtLibrarianEmail.Multiline = true;
            this.TxtLibrarianEmail.Name = "TxtLibrarianEmail";
            this.TxtLibrarianEmail.Size = new System.Drawing.Size(235, 20);
            this.TxtLibrarianEmail.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(29, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 1);
            this.panel2.TabIndex = 15;
            // 
            // BtnSearchLibrarian
            // 
            this.BtnSearchLibrarian.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchLibrarian.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearchLibrarian.BackgroundImage")));
            this.BtnSearchLibrarian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearchLibrarian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchLibrarian.FlatAppearance.BorderSize = 0;
            this.BtnSearchLibrarian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSearchLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchLibrarian.Location = new System.Drawing.Point(832, 40);
            this.BtnSearchLibrarian.Name = "BtnSearchLibrarian";
            this.BtnSearchLibrarian.Size = new System.Drawing.Size(36, 35);
            this.BtnSearchLibrarian.TabIndex = 2;
            this.BtnSearchLibrarian.UseVisualStyleBackColor = false;
            this.BtnSearchLibrarian.Click += new System.EventHandler(this.BtnSearchLibrarian_Click);
            // 
            // TxtLibrarianName
            // 
            this.TxtLibrarianName.BackColor = System.Drawing.Color.White;
            this.TxtLibrarianName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLibrarianName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtLibrarianName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibrarianName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtLibrarianName.Location = new System.Drawing.Point(29, 52);
            this.TxtLibrarianName.Multiline = true;
            this.TxtLibrarianName.Name = "TxtLibrarianName";
            this.TxtLibrarianName.Size = new System.Drawing.Size(235, 20);
            this.TxtLibrarianName.TabIndex = 1;
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
            this.BtnEditLibrarians.Location = new System.Drawing.Point(677, 667);
            this.BtnEditLibrarians.Name = "BtnEditLibrarians";
            this.BtnEditLibrarians.Size = new System.Drawing.Size(290, 42);
            this.BtnEditLibrarians.TabIndex = 8;
            this.BtnEditLibrarians.Text = "  İdarəçilər cədvəlində dəyişiklik et";
            this.BtnEditLibrarians.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditLibrarians.UseVisualStyleBackColor = false;
            this.BtnEditLibrarians.Click += new System.EventHandler(this.BtnEditLibrarians_Click);
            // 
            // ViewAllLibrariansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1031, 749);
            this.Controls.Add(this.BtnEditLibrarians);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBackArrow);
            this.Controls.Add(this.DgvViewAllLibrarians);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllLibrariansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Librarians:";
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllLibrarians)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvViewAllLibrarians;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Button BtnBackArrow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtLibrarianPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtLibrarianEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearchLibrarian;
        private System.Windows.Forms.TextBox TxtLibrarianName;
        private System.Windows.Forms.Button BtnEditLibrarians;
    }
}