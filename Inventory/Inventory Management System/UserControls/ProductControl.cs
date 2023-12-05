using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Models;
using Inventory_Management_System.Forms;
using Inventory_Management_System.Functions;

namespace Inventory_Management_System.UserControls
{
    public partial class ProductControl : UserControl
    {
        private DB_InventoryEntities db;
        public ProductControl()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
        }
        public DataGridView GetDataGridView()
        {
            return dgv_Products;
        }
        public void loadCbBoxCategory()
        {
            // SELECT * FROM Category
            var categories = db.Category.ToList();

            Cbox_Category.ValueMember = "categoryID";
            Cbox_Category.DisplayMember = "categoryName";
            Cbox_Category.DataSource = categories;
        }
        public void LoadTable()
        {
            dgv_Products.DataSource = db.sp_CategoryFilter(Cbox_Category.Text).ToList();

            Tables.DisplayProducts(dgv_Products);
        }
        private void ProductControl_Load(object sender, EventArgs e)
        {
            loadCbBoxCategory();
            LoadTable();
            // Add "Edit" and "Remove" buttons to DataGridView columns
            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Name = "btnEdit",
                FlatStyle = FlatStyle.Flat
            };
            dgv_Products.Columns.Add(editButton);

            var removeButton = new DataGridViewButtonColumn
            {
                HeaderText = "Remove",
                Text = "Remove",
                UseColumnTextForButtonValue = true,
                Name = "btnRemove",
                FlatStyle = FlatStyle.Flat
            };
            dgv_Products.Columns.Add(removeButton);

            dgv_Products.Columns["btnEdit"].Width = 60;
            dgv_Products.Columns["btnRemove"].Width = 60;
        }
        private void dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit button
            if (e.ColumnIndex == dgv_Products.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Products.Rows[e.RowIndex];

                Products products = new Products
                {
                    productID = int.Parse(selectedRow.Cells["productID"].Value.ToString()),
                    product_Name = selectedRow.Cells["product_Name"].Value.ToString(),
                    product_Sku = selectedRow.Cells["product_Sku"].Value.ToString(),
                    product_Quantity = selectedRow.Cells["product_Quantity"].Value.ToString(),
                    product_Price = decimal.Parse(selectedRow.Cells["product_Price"].Value.ToString()),
                    product_Description = selectedRow.Cells["product_Description"].Value.ToString()
                };
                EditForm edit = new EditForm(products, this);
                edit.ShowDialog();
            }
            //Remove button
            if (e.ColumnIndex == dgv_Products.Columns["btnRemove"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Products.Rows[e.RowIndex];

                Products products = new Products
                {
                    productID = int.Parse(selectedRow.Cells["productID"].Value.ToString()),
                    product_Name = selectedRow.Cells["product_Name"].Value.ToString(),
                    product_Sku = selectedRow.Cells["product_Sku"].Value.ToString(),
                    product_Quantity = selectedRow.Cells["product_Quantity"].Value.ToString(),
                    product_Price = decimal.Parse(selectedRow.Cells["product_Price"].Value.ToString()),
                    product_Description = selectedRow.Cells["product_Description"].Value.ToString()
                };
                Commands cmd = new Commands();
                cmd.RemoveProductCommand(products);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm(this);
            add.ShowDialog();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }

        private void Cbox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData(txtSearch.Text);
        }

        private void FilterData(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                LoadTable();
            }
            else
            {
                var filteredData = db.sp_CategoryFilter(Cbox_Category.Text)
                    .Where(p =>
                        p.product_Name.Contains(searchText) ||
                        p.product_Sku.Contains(searchText) ||
                        p.product_Description.Contains(searchText)
                    )
                    .ToList();

                dgv_Products.DataSource = filteredData;
            }
        }
    }
}
