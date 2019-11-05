namespace LibraryManagementSystem.Forms
{
    partial class DashboardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memmberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewLibrarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllLibrariansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.memmberToolStripMenuItem,
            this.librarianToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewAllBooksToolStripMenuItem,
            this.editBooksToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addNewBookToolStripMenuItem.Text = "Add new book";
            // 
            // viewAllBooksToolStripMenuItem
            // 
            this.viewAllBooksToolStripMenuItem.Name = "viewAllBooksToolStripMenuItem";
            this.viewAllBooksToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.viewAllBooksToolStripMenuItem.Text = "View all books";
            this.viewAllBooksToolStripMenuItem.Click += new System.EventHandler(this.viewAllBooksToolStripMenuItem_Click);
            // 
            // editBooksToolStripMenuItem
            // 
            this.editBooksToolStripMenuItem.Name = "editBooksToolStripMenuItem";
            this.editBooksToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.editBooksToolStripMenuItem.Text = "Edit books";
            // 
            // memmberToolStripMenuItem
            // 
            this.memmberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMemberToolStripMenuItem,
            this.viewAllMembersToolStripMenuItem});
            this.memmberToolStripMenuItem.Name = "memmberToolStripMenuItem";
            this.memmberToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.memmberToolStripMenuItem.Text = "Member";
            // 
            // addNewMemberToolStripMenuItem
            // 
            this.addNewMemberToolStripMenuItem.Name = "addNewMemberToolStripMenuItem";
            this.addNewMemberToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addNewMemberToolStripMenuItem.Text = "Add new member";
            // 
            // viewAllMembersToolStripMenuItem
            // 
            this.viewAllMembersToolStripMenuItem.Name = "viewAllMembersToolStripMenuItem";
            this.viewAllMembersToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viewAllMembersToolStripMenuItem.Text = "View all members";
            this.viewAllMembersToolStripMenuItem.Click += new System.EventHandler(this.viewAllMembersToolStripMenuItem_Click);
            // 
            // librarianToolStripMenuItem
            // 
            this.librarianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewLibrarianToolStripMenuItem,
            this.viewAllLibrariansToolStripMenuItem});
            this.librarianToolStripMenuItem.Name = "librarianToolStripMenuItem";
            this.librarianToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.librarianToolStripMenuItem.Text = "Librarian";
            // 
            // addNewLibrarianToolStripMenuItem
            // 
            this.addNewLibrarianToolStripMenuItem.Name = "addNewLibrarianToolStripMenuItem";
            this.addNewLibrarianToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addNewLibrarianToolStripMenuItem.Text = "Add new librarian";
            // 
            // viewAllLibrariansToolStripMenuItem
            // 
            this.viewAllLibrariansToolStripMenuItem.Name = "viewAllLibrariansToolStripMenuItem";
            this.viewAllLibrariansToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewAllLibrariansToolStripMenuItem.Text = "View all librarians";
            this.viewAllLibrariansToolStripMenuItem.Click += new System.EventHandler(this.viewAllLibrariansToolStripMenuItem_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(543, 9);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(35, 13);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(19, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 183);
            this.panel1.TabIndex = 2;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memmberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewLibrarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllBooksToolStripMenuItem;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem editBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllLibrariansToolStripMenuItem;
    }
}