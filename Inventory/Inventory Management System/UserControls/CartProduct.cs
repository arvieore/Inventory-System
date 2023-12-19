using Inventory_Management_System.Functions;
using Inventory_Management_System.Models;
using Microsoft.VisualBasic;
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
    public partial class CartProduct : UserControl
    {
        private DB_InventoryEntities db;
        private DataGridViewButtonColumn btnRemove;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDone;
        private Commands cmd;
        
        private String input;
        public int accountID;
        private bool btns = true;
        private bool cboxBtns = false;
        public CartProduct()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
            cmd = new Commands();

            btnRemove = new DataGridViewButtonColumn
            {
                HeaderText = "Remove",
                Text = "Remove",
                UseColumnTextForButtonValue = true,
                Name = "btnRemove",
                FlatStyle = FlatStyle.Flat,
                Width = 14
            };

            btnEdit = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Name = "btnEdit",
                FlatStyle = FlatStyle.Flat,
                Width = 14
            };

            btnDone = new DataGridViewButtonColumn
            {
                HeaderText = "Done",
                Text = "Done",
                UseColumnTextForButtonValue = true,
                Name = "btnDone",
                FlatStyle = FlatStyle.Flat,
                Width = 14
            };
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            LoadCart();
            loadCbBoxCategory();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }
        public void loadCbBoxCategory()
        {
            // SELECT * FROM Category
            var categories = db.Category.ToList();

            Cbox_Category.ValueMember = "categoryID";
            Cbox_Category.DisplayMember = "categoryName";
            Cbox_Category.DataSource = categories;
        }
        public void LoadCart()
        {
            cboxBtns = false;
            dgv_Products.Columns.Clear();
            dgv_Products.DataSource = db.vw_PendingOrders.ToList();
            dgv_Products.Columns["ID"].Visible = false;
            dgv_Products.Columns["ProductID"].Visible = false;

            dgv_Products.Columns["Clerk"].HeaderText = "Clerk name";
            dgv_Products.Columns["Order_no_"].HeaderText = "Order no.";
            dgv_Products.Columns["Order_no_"].Width = 70;
            dgv_Products.Columns["Quantity"].Width = 65;
            dgv_Products.Columns["Status"].Width = 65;

            if (btns)
            {
                dgv_Products.Columns.Add(btnRemove);
                dgv_Products.Columns.Add(btnEdit);
                dgv_Products.Columns.Add(btnDone);
            }
        }
        private void Cbox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxBtns = true;
            if (cboxBtns)
            {
                dgv_Products.Columns.Clear();
                dgv_Products.DataSource = db.sp_CartCategoryFilter(Cbox_Category.Text).ToList();
                dgv_Products.Columns["ID"].Visible = false;
                dgv_Products.Columns["ProductID"].Visible = false;

                dgv_Products.Columns["Clerk"].HeaderText = "Clerk name";
                dgv_Products.Columns["Order_no_"].HeaderText = "Order no.";
                dgv_Products.Columns["Order_no_"].Width = 70;
                dgv_Products.Columns["Quantity"].Width = 65;
                dgv_Products.Columns["Status"].Width = 65;

                if (btns)
                {
                    dgv_Products.Columns.Add(btnRemove);
                    dgv_Products.Columns.Add(btnEdit);
                    dgv_Products.Columns.Add(btnDone);
                }
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
                LoadCart();
            }
            else
            {
                dgv_Products.Columns.Clear();
                var filteredData = db.vw_PendingOrders
                    .Where(p =>
                        p.Clerk.Contains(searchText) ||
                        p.Order_no_.ToString().Contains(searchText) ||
                        p.Product.Contains(searchText) ||
                        p.Category.Contains(searchText) ||
                        p.Customer.Contains(searchText) ||
                        p.Address.Contains(searchText) ||
                        p.Status.Contains(searchText)
                    )
                    .ToList();
                    dgv_Products.DataSource = filteredData;
                    dgv_Products.Columns["ID"].Visible = false;
                    dgv_Products.Columns["ProductID"].Visible = false;
                    
                    dgv_Products.Columns["Clerk"].HeaderText = "Clerk name";
                    dgv_Products.Columns["Order_no_"].HeaderText = "Order no.";
                    dgv_Products.Columns["Order_no_"].Width = 70;
                    dgv_Products.Columns["Quantity"].Width = 65;
                    dgv_Products.Columns["Status"].Width = 65;
                    
                    if (btns)
                    {
                        dgv_Products.Columns.Add(btnRemove);
                        dgv_Products.Columns.Add(btnEdit);
                        dgv_Products.Columns.Add(btnDone);
                    }
            }
        }
        private void dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_Products.Rows[e.RowIndex];
            if(e.ColumnIndex == dgv_Products.Columns["btnRemove"].Index && e.RowIndex >= 0)
            {
                int ProductID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value); //ID sa Products
                int ID = Convert.ToInt32(selectedRow.Cells["ID"].Value); //ID sa Cart
                String Qty = selectedRow.Cells["Quantity"].Value.ToString(); //Quantity sa Cart

                cmd.UpdateProductQty(ProductID, Qty);
                cmd.RemoveProductInCart(ID);
                LoadCart();
            }
            if (e.ColumnIndex == dgv_Products.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                int ProductID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value); //ID sa Products
                int ID = Convert.ToInt32(selectedRow.Cells["ID"].Value); //ID sa Cart
                String CartQty = selectedRow.Cells["Quantity"].Value.ToString(); //Quantity sa Cart
                String productName = selectedRow.Cells["Product"].Value.ToString();

                String ProductQty = db.Products.Where(q => q.productID == ProductID).Select(q => q.product_Quantity).FirstOrDefault();

                int totalQty = Convert.ToInt32(CartQty) + Convert.ToInt32(ProductQty);

                int quantity;
                bool validInput = false;
                do
                {
                    input = Interaction.InputBox($"Enter quantity for {productName}", "Quantity");
                    if (string.IsNullOrEmpty(input))
                    {
                        return;
                    }
                    if (input.Equals("0"))
                    {
                        MessageBox.Show("Please enter a quantity greater than 0.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    validInput = int.TryParse(input, out quantity);
                    if (!validInput)
                    {
                        MessageBox.Show("Please enter a valid numeric quantity.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (totalQty < quantity)
                    {
                        MessageBox.Show($"The available quantity of this product is {totalQty}", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (validInput)
                    {
                        cmd.EditCartQuantity(ID, ProductID, totalQty, quantity);
                        LoadCart();
                    }
                } 
                while (!validInput);
            }
            if (e.ColumnIndex == dgv_Products.Columns["btnDone"].Index && e.RowIndex >= 0)
            {
                int ProductID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value); //ID sa Products
                int CartID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                String CartStatus = selectedRow.Cells["Status"].Value.ToString();
                String CategoryName = selectedRow.Cells["Category"].Value.ToString();
                int CartQty = Convert.ToInt32(selectedRow.Cells["Quantity"].Value); //Quantity sa Cart

                int categoryID = db.Category.Where(c => c.categoryName == CategoryName).Select(c => c.categoryID).FirstOrDefault();

                cmd.UpdateCartStatus(CartID, CartStatus);
                LoadCart();

                cmd.AddHistoryTransac(CartID, accountID, ProductID, categoryID);
            }
        }
    }
}
