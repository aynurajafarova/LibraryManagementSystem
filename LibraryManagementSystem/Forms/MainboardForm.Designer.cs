namespace LibraryManagementSystem.Forms
{
    partial class MainboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.BtnMembers = new System.Windows.Forms.Button();
            this.BtnLibrarians = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.BtnBooks);
            this.panel1.Controls.Add(this.BtnMembers);
            this.panel1.Controls.Add(this.BtnLibrarians);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 450);
            this.panel1.TabIndex = 0;
            // 
            // BtnBooks
            // 
            this.BtnBooks.FlatAppearance.BorderSize = 0;
            this.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooks.Image = ((System.Drawing.Image)(resources.GetObject("BtnBooks.Image")));
            this.BtnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBooks.Location = new System.Drawing.Point(23, 146);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(187, 43);
            this.BtnBooks.TabIndex = 2;
            this.BtnBooks.Text = "  Kitablar";
            this.BtnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBooks.UseVisualStyleBackColor = true;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnMembers
            // 
            this.BtnMembers.FlatAppearance.BorderSize = 0;
            this.BtnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMembers.Image = ((System.Drawing.Image)(resources.GetObject("BtnMembers.Image")));
            this.BtnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMembers.Location = new System.Drawing.Point(23, 97);
            this.BtnMembers.Name = "BtnMembers";
            this.BtnMembers.Size = new System.Drawing.Size(187, 43);
            this.BtnMembers.TabIndex = 1;
            this.BtnMembers.Text = "  İstifadəçilər";
            this.BtnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMembers.UseVisualStyleBackColor = true;
            this.BtnMembers.Click += new System.EventHandler(this.BtnMembers_Click);
            // 
            // BtnLibrarians
            // 
            this.BtnLibrarians.FlatAppearance.BorderSize = 0;
            this.BtnLibrarians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLibrarians.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibrarians.Image = ((System.Drawing.Image)(resources.GetObject("BtnLibrarians.Image")));
            this.BtnLibrarians.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLibrarians.Location = new System.Drawing.Point(23, 48);
            this.BtnLibrarians.Name = "BtnLibrarians";
            this.BtnLibrarians.Size = new System.Drawing.Size(187, 43);
            this.BtnLibrarians.TabIndex = 0;
            this.BtnLibrarians.Text = "  İdarəçilər";
            this.BtnLibrarians.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLibrarians.UseVisualStyleBackColor = true;
            this.BtnLibrarians.Click += new System.EventHandler(this.BtnLibrarians_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(744, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(34, 36);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainboardForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLibrarians;
        private System.Windows.Forms.Button BtnBooks;
        private System.Windows.Forms.Button BtnMembers;
        private System.Windows.Forms.Button BtnExit;
    }
}