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
            this.DgvViewAllMembers = new System.Windows.Forms.DataGridView();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllMembers)).BeginInit();
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
            this.DgvViewAllMembers.Location = new System.Drawing.Point(32, 32);
            this.DgvViewAllMembers.Name = "DgvViewAllMembers";
            this.DgvViewAllMembers.ReadOnly = true;
            this.DgvViewAllMembers.Size = new System.Drawing.Size(706, 343);
            this.DgvViewAllMembers.TabIndex = 2;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Fullname:";
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
            this.Address.HeaderText = "Address:";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone:";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // ViewAllMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(766, 405);
            this.Controls.Add(this.DgvViewAllMembers);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewAllMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Members:";
            ((System.ComponentModel.ISupportInitialize)(this.DgvViewAllMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvViewAllMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}