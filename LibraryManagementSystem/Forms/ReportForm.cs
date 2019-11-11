using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace LibraryManagementSystem.Forms
{
    public partial class ReportForm : Form
    {
        private readonly OrderService _orderService;

        decimal income = 0;
        public ReportForm()
        {
            InitializeComponent();

            _orderService = new OrderService();

            FillReports();
        }


        // This method will fill DgvReports
        private void FillReports()
        {
            foreach (Order order in _orderService.Orders())
            {
                if (order.ReturnDate != null)
                {
                    if (order.ReturnDate > order.MustBeReturned)
                    {
                        Decimal fine = (order.ReturnDate.Day - order.MustBeReturned.Day) + (order.Cost * 5 / 100);

                        DgvReports.Rows.Add(order.Id, order.Member.Fullname, order.Book.Name, order.Cost + fine);
                        income += (order.Cost + fine);
                    }
                    else
                    {
                        DgvReports.Rows.Add(order.Id, order.Member.Fullname, order.Book.Name, order.Cost);
                        income += order.Cost;

                    }
                }
            }
        }


        // export to Excel
        private void BtnExport_Click(object sender, EventArgs e)
        {
            string str = string.Empty;

            DialogResult result = FbdChooseDirectory.ShowDialog();

            if (DialogResult.OK == result)
            {
                str = FbdChooseDirectory.SelectedPath;
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Reports");
                    worksheet.Cell("A1").Value = "İstifadəçinin adı";
                    worksheet.Cell("B1").Value = "Kitabın adı";
                    worksheet.Cell("C1").Value = "Məbləğ";

                    worksheet.Column("A").Width = 30;
                    worksheet.Column("B").Width = 30;
                    worksheet.Column("C").Width = 15;

                    int rowstart = 2;
                    foreach (DataGridViewRow row in DgvReports.Rows)
                    {
                        worksheet.Cell(rowstart, 1).Value = row.Cells[1].Value;
                        worksheet.Cell(rowstart, 2).Value = row.Cells[2].Value;
                        worksheet.Cell(rowstart, 3).Value = row.Cells[3].Value;
                        rowstart++;
                    }

                    try
                    {
                        workbook.SaveAs(Path.Combine(str, $"Hesabat.xlsx"));
                    }
                    catch
                    {
                        MessageBox.Show("Açıq olan faylı bağlayın");
                        return;
                    }
                    MessageBox.Show("Excel fayl yaradıldı");
                }
            }
        }



        // This event will close the current - ReportForm form and open the MainboardForm
        private void BtnBackArrow_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }
    }
}

