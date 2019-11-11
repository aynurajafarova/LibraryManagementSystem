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
            this.BtnNewBookOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(296, 788);
            this.panel1.TabIndex = 0;
            // 
            // BtnBooks
            // 
            this.BtnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBooks.FlatAppearance.BorderSize = 0;
            this.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooks.Image = ((System.Drawing.Image)(resources.GetObject("BtnBooks.Image")));
            this.BtnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBooks.Location = new System.Drawing.Point(36, 317);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(209, 72);
            this.BtnBooks.TabIndex = 2;
            this.BtnBooks.Text = "  Kitablar";
            this.BtnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBooks.UseVisualStyleBackColor = true;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnMembers
            // 
            this.BtnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMembers.FlatAppearance.BorderSize = 0;
            this.BtnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMembers.Image = ((System.Drawing.Image)(resources.GetObject("BtnMembers.Image")));
            this.BtnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMembers.Location = new System.Drawing.Point(36, 211);
            this.BtnMembers.Name = "BtnMembers";
            this.BtnMembers.Size = new System.Drawing.Size(209, 72);
            this.BtnMembers.TabIndex = 1;
            this.BtnMembers.Text = "   İstifadəçilər";
            this.BtnMembers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMembers.UseVisualStyleBackColor = true;
            this.BtnMembers.Click += new System.EventHandler(this.BtnMembers_Click);
            // 
            // BtnLibrarians
            // 
            this.BtnLibrarians.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLibrarians.FlatAppearance.BorderSize = 0;
            this.BtnLibrarians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLibrarians.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibrarians.Image = ((System.Drawing.Image)(resources.GetObject("BtnLibrarians.Image")));
            this.BtnLibrarians.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLibrarians.Location = new System.Drawing.Point(36, 115);
            this.BtnLibrarians.Name = "BtnLibrarians";
            this.BtnLibrarians.Size = new System.Drawing.Size(209, 72);
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
            this.BtnExit.Location = new System.Drawing.Point(1290, 49);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(36, 33);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnNewBookOrder
            // 
            this.BtnNewBookOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewBookOrder.FlatAppearance.BorderSize = 0;
            this.BtnNewBookOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewBookOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewBookOrder.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewBookOrder.Image")));
            this.BtnNewBookOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewBookOrder.Location = new System.Drawing.Point(452, 175);
            this.BtnNewBookOrder.Name = "BtnNewBookOrder";
            this.BtnNewBookOrder.Size = new System.Drawing.Size(209, 72);
            this.BtnNewBookOrder.TabIndex = 2;
            this.BtnNewBookOrder.Text = " Yeni sifariş yarat";
            this.BtnNewBookOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNewBookOrder.UseVisualStyleBackColor = true;
            this.BtnNewBookOrder.Click += new System.EventHandler(this.BtnNewBookOrder_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(715, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "Geri təhvil verilən kitablar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnReport.Image")));
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReport.Location = new System.Drawing.Point(977, 175);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(209, 82);
            this.BtnReport.TabIndex = 4;
            this.BtnReport.Text = "  Hesabat";
            this.BtnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // MainboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnNewBookOrder);
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
        private System.Windows.Forms.Button BtnNewBookOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnReport;
    }
}