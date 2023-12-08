using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Inventory_Management_System.Functions;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.UserControls
{
    public partial class Summary : UserControl
    {
        private DB_InventoryEntities db;
        private String SelectedPanel;
        public Summary()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            RefreshSummary();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }
        private void RefreshSummary()
        {
            int countProduct = db.Products.Count();
            lblTotalProduct.Text = countProduct.ToString();

            int countCategory = db.Category.Count();
            lblTotalCategory.Text = countCategory.ToString();

            var countOutOfStock = db.Products.Count(p => p.product_Quantity == "0");
            lblOutOfStock.Text = countOutOfStock.ToString();

            var countLowOfStock = db.sp_SelectProduct().Where(p => Convert.ToInt32(p.Quantity) <= 5 && Convert.ToInt32(p.Quantity) != 0).Count();
            lblLowOfStock.Text = countLowOfStock.ToString();
        }

        private void panelProduct_Click(object sender, EventArgs e)
        {
            panelHover.BackColor = Color.FromArgb(31, 110, 140);
            int x = 7;
            int y = 241;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            SelectedPanel = "panelProduct";
            LoadTable(SelectedPanel);
        }
        private void panelCategory_Click(object sender, EventArgs e)
        {
            panelHover.BackColor = Color.FromArgb(31, 110, 140);
            int x = 251;
            int y = 241;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            SelectedPanel = "panelCategory";
            LoadTable(SelectedPanel);
        }

        private void panelStocks_Click(object sender, EventArgs e)
        {
            panelHover.BackColor = Color.FromArgb(31, 110, 140);
            int x = 495;
            int y = 241;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            SelectedPanel = "panelOutOfStocks";
            LoadTable(SelectedPanel);
        }

        private void panelLowStock_Click(object sender, EventArgs e)
        {
            panelHover.BackColor = Color.FromArgb(31, 110, 140);
            int x = 738;
            int y = 241;
            Point HoverPanel = new Point(x, y);
            panelHover.Location = HoverPanel;

            SelectedPanel = "panelLowOfStock";
            LoadTable(SelectedPanel);
        }
        private void LoadTable(String selectedPanel)
        {
            if(selectedPanel.Equals("panelProduct"))
            {
                dgv_Summary.DataSource = db.sp_SelectProduct().ToList();
                dgv_Summary.Columns["product_Name"].HeaderText = "Product Name";
                dgv_Summary.Columns["ID"].Width = 30;
                dgv_Summary.Columns["Quantity"].Width = 80;
                dgv_Summary.Columns["Price"].Width = 100;
            }
            else if (selectedPanel.Equals("panelCategory"))
            {
                dgv_Summary.DataSource = db.sp_SelectCategory();
                dgv_Summary.Columns["categoryName"].HeaderText = "Category Name";
                dgv_Summary.Columns["ID"].Width = 90;
            }
            else if (selectedPanel.Equals("panelOutOfStocks"))
            {
                dgv_Summary.DataSource = db.sp_SelectProduct().Where(p => Convert.ToInt32(p.Quantity) == 0).ToList();
                dgv_Summary.Columns["product_Name"].HeaderText = "Product Name";
                dgv_Summary.Columns["ID"].Width = 30;
                dgv_Summary.Columns["Quantity"].Width = 80;
                dgv_Summary.Columns["Price"].Width = 100;
            }
            else if (selectedPanel.Equals("panelLowOfStock"))
            {
                dgv_Summary.DataSource = db.sp_SelectProduct().Where(p => Convert.ToInt32(p.Quantity) <= 5 && Convert.ToInt32(p.Quantity) != 0).ToList();
                dgv_Summary.Columns["product_Name"].HeaderText = "Product Name";
                dgv_Summary.Columns["ID"].Width = 30;
                dgv_Summary.Columns["Quantity"].Width = 80;
                dgv_Summary.Columns["Price"].Width = 100;
            }
        }
    }
}
