namespace LibraryManagementSystem.Forms
{
    partial class ViewAllMembersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllMembersForm));
            this.DgvViewAllMembers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtMemberPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtMemberEmail = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            this.TxtMemberFullname = new System.Windows.Forms.TextBox();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBackArrow = new System.Windows.Forms.Button();
            this.BtnEditMembers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllMembers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Fullname,
            this.Email,
            this.Address,
            this.Phone});
            this.DgvViewAllMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvViewAllMembers.GridColor = System.Drawing.Color.CadetBlue;
            this.DgvViewAllMembers.Location = new System.Drawing.Point(131, 278);
            this.DgvViewAllMembers.Name = "DgvViewAllMembers";
            this.DgvViewAllMembers.ReadOnly = true;
            this.DgvViewAllMembers.Size = new System.Drawing.Size(929, 343);
            this.DgvViewAllMembers.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.TxtMemberPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.TxtMemberEmail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnSearchMember);
            this.panel1.Controls.Add(this.TxtMemberFullname);
            this.panel1.Location = new System.Drawing.Point(131, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 114);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(589, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 1);
            this.panel3.TabIndex = 24;
            // 
            // TxtMemberPhone
            // 
            this.TxtMemberPhone.BackColor = System.Drawing.Color.White;
            this.TxtMemberPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMemberPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtMemberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMemberPhone.Location = new System.Drawing.Point(589, 50);
            this.TxtMemberPhone.Multiline = true;
            this.TxtMemberPhone.Name = "TxtMemberPhone";
            this.TxtMemberPhone.Size = new System.Drawing.Size(214, 20);
            this.TxtMemberPhone.TabIndex = 23;
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
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad, Soyad:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(302, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 1);
            this.panel4.TabIndex = 19;
            // 
            // TxtMemberEmail
            // 
            this.TxtMemberEmail.BackColor = System.Drawing.Color.White;
            this.TxtMemberEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMemberEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtMemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMemberEmail.Location = new System.Drawing.Point(302, 49);
            this.TxtMemberEmail.Multiline = true;
            this.TxtMemberEmail.Name = "TxtMemberEmail";
            this.TxtMemberEmail.Size = new System.Drawing.Size(235, 20);
            this.TxtMemberEmail.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(29, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 1);
            this.panel2.TabIndex = 15;
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearchMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSearchMember.BackgroundImage")));
            this.BtnSearchMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearchMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchMember.FlatAppearance.BorderSize = 0;
            this.BtnSearchMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchMember.Location = new System.Drawing.Point(844, 42);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(36, 35);
            this.BtnSearchMember.TabIndex = 2;
            this.BtnSearchMember.UseVisualStyleBackColor = false;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // TxtMemberFullname
            // 
            this.TxtMemberFullname.BackColor = System.Drawing.Color.White;
            this.TxtMemberFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMemberFullname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtMemberFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMemberFullname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtMemberFullname.Location = new System.Drawing.Point(29, 52);
            this.TxtMemberFullname.Multiline = true;
            this.TxtMemberFullname.Name = "TxtMemberFullname";
            this.TxtMemberFullname.Size = new System.Drawing.Size(235, 20);
            this.TxtMemberFullname.TabIndex = 1;
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
            // BtnEditMembers
            // 
            this.BtnEditMembers.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnEditMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditMembers.FlatAppearance.BorderSize = 0;
            this.BtnEditMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumBlue;
            this.BtnEditMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditMembers.ForeColor = System.Drawing.Color.White;
            this.BtnEditMembers.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditMembers.Image")));
            this.BtnEditMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditMembers.Location = new System.Drawing.Point(757, 669);
            this.BtnEditMembers.Name = "BtnEditMembers";
            this.BtnEditMembers.Size = new System.Drawing.Size(303, 42);
            this.BtnEditMembers.TabIndex = 10;
            this.BtnEditMembers.Text = "  İstifadəçilər cədvəlində dəyişiklik et";
            this.BtnEditMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditMembers.UseVisualStyleBackColor = false;
            this.BtnEditMembers.Click += new System.EventHandler(this.BtnEditMembers_Click);
            // 
            // ViewAllMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.BtnEditMembers);
            this.Controls.Add(this.BtnBackArrow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvViewAllMembers);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Members:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllMembers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvViewAllMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtMemberPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtMemberEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSearchMember;
        private System.Windows.Forms.TextBox TxtMemberFullname;
        private System.Windows.Forms.Button BtnBackArrow;
        private System.Windows.Forms.Button BtnEditMembers;
    }
}