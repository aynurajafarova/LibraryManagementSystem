namespace LibraryManagementSystem.Forms
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.DgvReports = new System.Windows.Forms.DataGridView();
            this.BtnExport = new System.Windows.Forms.Button();
            this.FbdChooseDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnBackArrow = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReports
            // 
            this.DgvReports.AllowUserToAddRows = false;
            this.DgvReports.AllowUserToDeleteRows = false;
            this.DgvReports.AllowUserToResizeRows = false;
            this.DgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReports.BackgroundColor = System.Drawing.Color.White;
            this.DgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvReports.GridColor = System.Drawing.Color.Black;
            this.DgvReports.Location = new System.Drawing.Point(132, 85);
            this.DgvReports.Name = "DgvReports";
            this.DgvReports.ReadOnly = true;
            this.DgvReports.Size = new System.Drawing.Size(1091, 440);
            this.DgvReports.TabIndex = 1;
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExport.BackgroundImage")));
            this.BtnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExport.FlatAppearance.BorderSize = 0;
            this.BtnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.ForeColor = System.Drawing.Color.DarkBlue;
            this.BtnExport.Location = new System.Drawing.Point(1014, 573);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(209, 66);
            this.BtnExport.TabIndex = 3;
            this.BtnExport.Text = "            Excel file yarat";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnBackArrow
            // 
            this.BtnBackArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBackArrow.BackgroundImage")));
            this.BtnBackArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBackArrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackArrow.FlatAppearance.BorderSize = 0;
            this.BtnBackArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackArrow.Location = new System.Drawing.Point(1280, 56);
            this.BtnBackArrow.Name = "BtnBackArrow";
            this.BtnBackArrow.Size = new System.Drawing.Size(37, 37);
            this.BtnBackArrow.TabIndex = 4;
            this.BtnBackArrow.UseVisualStyleBackColor = true;
            this.BtnBackArrow.Click += new System.EventHandler(this.BtnBackArrow_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Istifadechi adi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kitabin adi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mebleg";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.BtnBackArrow);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.DgvReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReports;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.FolderBrowserDialog FbdChooseDirectory;
        private System.Windows.Forms.Button BtnBackArrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}