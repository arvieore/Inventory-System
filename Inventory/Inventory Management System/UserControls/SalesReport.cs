using Inventory_Management_System.Functions;
using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.UserControls
{
    public partial class SalesReport : UserControl
    {
        private DB_InventoryEntities db;
        public SalesReport()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            loadCbBoxCategory();
            LoadReport();
        }
        public void loadCbBoxCategory()
        {
            // SELECT * FROM Category
            var categories = db.Category.ToList();

            Cbox_Category.ValueMember = "categoryID";
            Cbox_Category.DisplayMember = "categoryName";
            Cbox_Category.DataSource = categories;
        }
        private void Cbox_Category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            FilterData(txtSearch.Text);
        }
        private void LoadReport()
        {

            if (Cbox_Category.Text != "All")
            {
                dgv_Transactions.DataSource = db.vw_HistoryTransaction.Where(c => c.Category == Cbox_Category.Text).ToList();
                dgv_Transactions.Columns["ID"].Width = 30;
                dgv_Transactions.Columns["Order_no"].HeaderText = "Order number";
                dgv_Transactions.Columns["Order_no"].Width = 85;

                dgv_Transactions.Columns["Products"].Width = 200;
                dgv_Transactions.Columns["Quantity"].Width = 50;
                dgv_Transactions.Columns["Total"].Width = 80;
                dgv_Transactions.Columns["Date"].Width = 85;

                decimal? total = db.vw_HistoryTransaction.Where(s => s.Category == Cbox_Category.Text).Select(s => s.Total).Sum();
                if (total > 0)
                {
                    lblTotal.Text = "₱ " + total?.ToString("#,##0.00");
                }
                else
                    lblTotal.Text = "₱ 0.00";
            }
            else
            {
                dgv_Transactions.DataSource = db.vw_HistoryTransaction.ToList();
                dgv_Transactions.Columns["ID"].Width = 30;
                dgv_Transactions.Columns["Order_no"].HeaderText = "Order number";
                dgv_Transactions.Columns["Order_no"].Width = 85;

                dgv_Transactions.Columns["Products"].Width = 200;
                dgv_Transactions.Columns["Quantity"].Width = 50;
                dgv_Transactions.Columns["Total"].Width = 80;
                dgv_Transactions.Columns["Date"].Width = 85;

                decimal? total = db.vw_HistoryTransaction.Select(s => s.Total).Sum();
                if (total > 0)
                {
                    lblTotal.Text = "₱ " + total?.ToString("#,##0.00");
                }
                else
                    lblTotal.Text = "₱ 0.00";
            }
        }
        private void FilterData(string searchText)
        {
            try
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    LoadReport();
                }
                else
                {
                    var filteredData = db.vw_HistoryTransaction
                        .Where(p =>
                            p.Order_no.ToString().Contains(searchText) ||
                            p.Clerk.Contains(searchText) ||
                            p.Products.Contains(searchText) ||
                            p.Category.Contains(searchText) ||
                            p.Customer.Contains(searchText) ||
                            p.Address.Contains(searchText)
                        ).ToList();
                    dgv_Transactions.DataSource = filteredData;

                    var filteredTotal = db.vw_HistoryTransaction
                        .Where(p =>
                            p.Order_no.ToString().Contains(searchText) ||
                            p.Clerk.Contains(searchText) ||
                            p.Products.Contains(searchText) ||
                            p.Category.Contains(searchText) ||
                            p.Customer.Contains(searchText) ||
                            p.Address.Contains(searchText)
                        ).Select(p => p.Total).Sum().ToString();

                    decimal? total = Decimal.Parse(filteredTotal);

                    if (total > 0)
                    {
                        lblTotal.Text = "₱ " + total?.ToString("#,##0.00");
                    }
                    else
                        lblTotal.Text = "₱ 0.00";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}
