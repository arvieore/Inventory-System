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
    public partial class HistoryControl : UserControl
    {
        private DB_InventoryEntities db;
        public HistoryControl()
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

        private void HistoryControl_Load(object sender, EventArgs e)
        {
            loadCbBoxCategory();
            LoadHistory();
        }
        public void loadCbBoxCategory()
        {
            // SELECT * FROM Category
            var categories = db.Category.ToList();

            Cbox_Category.ValueMember = "categoryID";
            Cbox_Category.DisplayMember = "categoryName";
            Cbox_Category.DataSource = categories;
        }
        private void Cbox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHistory();
        }
        private void LoadHistory()
        {
            if (Cbox_Category.Text != "All")
            {
                dgv_Transactions.DataSource = db.vw_Transaction_History.Where(c => c.Category == Cbox_Category.Text).ToList();
                dgv_Transactions.Columns["ID"].Width = 30;
                dgv_Transactions.Columns["Order_no"].HeaderText = "Order number";
                dgv_Transactions.Columns["Order_no"].Width = 85;

                dgv_Transactions.Columns["Products"].Width = 200;
                dgv_Transactions.Columns["Quantity"].Width = 50;
                dgv_Transactions.Columns["Total"].Width = 80;
                dgv_Transactions.Columns["Date"].Width = 85;
            }
            else
            {
                dgv_Transactions.DataSource = db.vw_Transaction_History.ToList();
                dgv_Transactions.Columns["ID"].Width = 30;
                dgv_Transactions.Columns["Order_no"].HeaderText = "Order number";
                dgv_Transactions.Columns["Order_no"].Width = 85;

                dgv_Transactions.Columns["Products"].Width = 200;
                dgv_Transactions.Columns["Quantity"].Width = 50;
                dgv_Transactions.Columns["Total"].Width = 80;
                dgv_Transactions.Columns["Date"].Width = 85;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData(txtSearch.Text);
        }
        private void FilterData(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                LoadHistory();
            }
            else
            {
                //dgv_Transactions.Columns.Clear();
                var filteredData = db.vw_Transaction_History
                    .Where(p =>
                        p.Order_no.ToString().Contains(searchText) ||
                        p.Clerk.Contains(searchText) ||
                        p.Products.Contains(searchText) ||
                        p.Category.Contains(searchText) ||
                        p.Customer.Contains(searchText) ||
                        p.Address.Contains(searchText) ||
                        p.Date.ToString().Contains(searchText)
                    )
                    .ToList();
                dgv_Transactions.DataSource = filteredData;
            }
        }
    }
}