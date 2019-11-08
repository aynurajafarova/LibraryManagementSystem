namespace LibraryManagementSystem.Forms
{
    partial class EditMembersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMembersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtMemberPassword = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DtpCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMemberAddress = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtMemberPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtMemberEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtMemberFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvViewAllMembers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBackArrow = new System.Windows.Forms.Button();
            this.BtnMainboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TxtMemberPassword);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.DtpCreatedAt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtMemberAddress);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.TxtMemberPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TxtMemberEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TxtMemberFullname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(90, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 421);
            this.panel1.TabIndex = 2;
            // 
            // TxtMemberPassword
            // 
            this.TxtMemberPassword.BackColor = System.Drawing.Color.White;
            this.TxtMemberPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMemberPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtMemberPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMemberPassword.Location = new System.Drawing.Point(113, 160);
            this.TxtMemberPassword.Multiline = true;
            this.TxtMemberPassword.Name = "TxtMemberPassword";
            this.TxtMemberPassword.Size = new System.Drawing.Size(250, 20);
            this.TxtMemberPassword.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel6.Location = new System.Drawing.Point(111, 182);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 1);
            this.panel6.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Şifrə:";
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
            this.BtnDelete.Location = new System.Drawing.Point(199, 345);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(95, 40);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(93, 345);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(95, 40);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Yenilə";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(94, 345);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(200, 40);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Əlavə et";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DtpCreatedAt
            // 
            this.DtpCreatedAt.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DtpCreatedAt.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DtpCreatedAt.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DtpCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpCreatedAt.Location = new System.Drawing.Point(114, 284);
            this.DtpCreatedAt.Name = "DtpCreatedAt";
            this.DtpCreatedAt.Size = new System.Drawing.Size(250, 21);
            this.DtpCreatedAt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tarix:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(107, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Yeni istifadəçi:";
            // 
            // TxtMemberAddress
            // 
            this.TxtMemberAddress.BackColor = System.Drawing.Color.White;
            this.TxtMemberAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMemberAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtMemberAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMemberAddress.Location = new System.Drawing.Point(114, 198);
            this.TxtMemberAddress.Multiline = true;
            this.TxtMemberAddress.Name = "TxtMemberAddress";
            this.TxtMemberAddress.Size = new System.Drawing.Size(250, 20);
            this.TxtMemberAddress.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Location = new System.Drawing.Point(114, 260);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 1);
            this.panel5.TabIndex = 22;
            // 
            // TxtMemberPhone
            // 
            this.TxtMemberPhone.BackColor = System.Drawing.Color.White;
            this.TxtMemberPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMemberPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtMemberPhone.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMemberPhone.Location = new System.Drawing.Point(114, 238);
            this.TxtMemberPhone.Multiline = true;
            this.TxtMemberPhone.Name = "TxtMemberPhone";
            this.TxtMemberPhone.Size = new System.Drawing.Size(250, 20);
            this.TxtMemberPhone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefon:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(114, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 1);
            this.panel4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ünvan:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(114, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 16;
            // 
            // TxtMemberEmail
            // 
            this.TxtMemberEmail.BackColor = System.Drawing.Color.White;
            this.TxtMemberEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMemberEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtMemberEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMemberEmail.Location = new System.Drawing.Point(114, 124);
            this.TxtMemberEmail.Multiline = true;
            this.TxtMemberEmail.Name = "TxtMemberEmail";
            this.TxtMemberEmail.Size = new System.Drawing.Size(250, 20);
            this.TxtMemberEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(114, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 13;
            // 
            // TxtMemberFullname
            // 
            this.TxtMemberFullname.BackColor = System.Drawing.Color.White;
            this.TxtMemberFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMemberFullname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtMemberFullname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberFullname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMemberFullname.Location = new System.Drawing.Point(114, 87);
            this.TxtMemberFullname.Multiline = true;
            this.TxtMemberFullname.Name = "TxtMemberFullname";
            this.TxtMemberFullname.Size = new System.Drawing.Size(250, 20);
            this.TxtMemberFullname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad, Soyad:";
            // 
            // DgvViewAllMembers
            // 
            this.DgvViewAllMembers.AllowUserToAddRows = false;
            this.DgvViewAllMembers.AllowUserToDeleteRows = false;
            this.DgvViewAllMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvViewAllMembers.BackgroundColor = System.Drawing.Color.White;
            this.DgvViewAllMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvViewAllMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvViewAllMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvViewAllMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fullname,
            this.Email,
            this.Password,
            this.Address,
            this.Phone,
            this.Date});
            this.DgvViewAllMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvViewAllMembers.GridColor = System.Drawing.Color.CadetBlue;
            this.DgvViewAllMembers.Location = new System.Drawing.Point(539, 149);
            this.DgvViewAllMembers.Name = "DgvViewAllMembers";
            this.DgvViewAllMembers.ReadOnly = true;
            this.DgvViewAllMembers.Size = new System.Drawing.Size(706, 421);
            this.DgvViewAllMembers.TabIndex = 3;
            this.DgvViewAllMembers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvViewAllMembers_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Ad, Soyad:";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email:";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Şifrə";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Ünvan:";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Telefon:";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Tarix:";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
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
            this.BtnBackArrow.TabIndex = 9;
            this.BtnBackArrow.UseVisualStyleBackColor = true;
            this.BtnBackArrow.Click += new System.EventHandler(this.BtnBackArrow_Click);
            // 
            // BtnMainboard
            // 
            this.BtnMainboard.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnMainboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMainboard.FlatAppearance.BorderSize = 0;
            this.BtnMainboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnMainboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMainboard.ForeColor = System.Drawing.Color.White;
            this.BtnMainboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnMainboard.Image")));
            this.BtnMainboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMainboard.Location = new System.Drawing.Point(1049, 618);
            this.BtnMainboard.Name = "BtnMainboard";
            this.BtnMainboard.Size = new System.Drawing.Size(196, 42);
            this.BtnMainboard.TabIndex = 10;
            this.BtnMainboard.Text = "  Ana səhifəyə qayıt";
            this.BtnMainboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMainboard.UseVisualStyleBackColor = false;
            this.BtnMainboard.Click += new System.EventHandler(this.BtnMainboard_Click);
            // 
            // EditMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BtnMainboard);
            this.Controls.Add(this.BtnBackArrow);
            this.Controls.Add(this.DgvViewAllMembers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMembersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtMemberAddress;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxtMemberPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtMemberEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtMemberFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpCreatedAt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DgvViewAllMembers;
        private System.Windows.Forms.TextBox TxtMemberPassword;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button BtnBackArrow;
        private System.Windows.Forms.Button BtnMainboard;
    }
}