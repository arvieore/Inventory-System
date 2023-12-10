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
using Microsoft.VisualBasic;
using System.Globalization;
using System.Web;

namespace Inventory_Management_System.UserControls
{
    public partial class OrderProduct : UserControl
    {
        private DB_InventoryEntities db;
        public int accountID;
        private DataGridViewButtonColumn addToCart;
        private String input;
        private Products products;
        private Commands cmd;

        private int currentOrderNo;
        public OrderProduct()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
            products = new Products();
            cmd = new Commands();

            addToCart = new DataGridViewButtonColumn
            {
                HeaderText = "Order",
                Text = "Order",
                UseColumnTextForButtonValue = true,
                Name = "btnAddToCart",
                FlatStyle = FlatStyle.Flat
            };
        }
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }
        private void OrderProduct_Load(object sender, EventArgs e)
        {
            loadCbBoxCategory();
            LoadTable();

            var lastOrderNo = db.vw_LastOrderNumber.FirstOrDefault();
            currentOrderNo = lastOrderNo != null ? lastOrderNo.OrderNo + 1 : 1;
            lblOrderNo.Text = currentOrderNo.ToString();
        }
        private void Cbox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTable();
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
            dgv_Products.Columns.Clear();
            dgv_Products.DataSource = db.sp_CategoryFilter(Cbox_Category.Text).Where(p => Convert.ToInt32(p.product_Quantity) > 0).ToList();

            Tables.DisplayProducts(dgv_Products);
            dgv_Products.Columns.Add(addToCart);
        }
        private void dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCustomer.Text))
            {
                errorProvider.SetError(txtCustomer, "Empty field!");
            }
            else if (String.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Empty field!");
            }
            else
            {
                if (e.ColumnIndex == dgv_Products.Columns["btnAddToCart"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgv_Products.Rows[e.RowIndex];
                    products = new Products
                    {
                        productID = int.Parse(selectedRow.Cells["productID"].Value.ToString()),
                        product_Name = selectedRow.Cells["product_Name"].Value.ToString(),
                        product_Sku = selectedRow.Cells["product_Sku"].Value.ToString(),
                        product_Quantity = selectedRow.Cells["product_Quantity"].Value.ToString(),
                        product_Price = decimal.Parse(selectedRow.Cells["product_Price"].Value.ToString()),
                        product_Description = selectedRow.Cells["product_Description"].Value.ToString()
                    };
                    int quantity;
                    bool validInput = false;
                    do
                    {
                        input = Interaction.InputBox($"Enter quantity for {products.product_Name}", "Quantity");
                        if (string.IsNullOrEmpty(input))
                        {
                            return;
                        }
                        if(input.Equals("0"))
                        {
                            MessageBox.Show("Please enter a quantity greater than 0.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        validInput = int.TryParse(input, out quantity);
                        if (!validInput)
                        {
                            MessageBox.Show("Please enter a valid numeric quantity.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if(Convert.ToInt32(products.product_Quantity) < quantity)
                        {
                            MessageBox.Show($"The available quantity of this product is {products.product_Quantity}", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (validInput)
                        {
                            int categoryID = db.Products.Where(p => p.productID == products.productID).Select(p => p.categoryID).FirstOrDefault();
                            int user_ID = db.Accounts.Where(a => a.user_ID == accountID).Select(a => a.user_ID).FirstOrDefault();

                            UpdateLoadCart(products, quantity);


                            string customerName = txtCustomer.Text;
                            string customerAddress = txtAddress.Text;
                            int OrderNo = Convert.ToInt32(lblOrderNo.Text);

                            cmd.AddToCart(OrderNo, products.productID, categoryID, user_ID, quantity, customerName, customerAddress);
                            MessageBox.Show("The product has been successfully added cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } while (!validInput);
                }
            }
        }
        private void UpdateLoadCart(Products products, int inputtedQty)
        {
            int newQty = Convert.ToInt32(products.product_Quantity) - inputtedQty;

            var checkID = db.Products.SingleOrDefault(p => p.productID == products.productID);
            if(checkID != null)
            {
                checkID.product_Quantity = newQty.ToString();
                db.SaveChanges();
                LoadTable();
            }
            else
            {
                MessageBox.Show($"No product found with productID {checkID.productID}");
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

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            var lastOrderNo = db.vw_LastOrderNumber.FirstOrDefault();

            currentOrderNo = lastOrderNo != null ? lastOrderNo.OrderNo + 1 : 1;
            lblOrderNo.Text = currentOrderNo.ToString();

            //Create a table in database to store the Order of the customer .....
            var status = db.Cart.Where(s => s.Order_status == "Pending").ToList();
            foreach (var order in status)
            {
                order.Order_status = "Completed";
            }
            db.SaveChanges();
            CheckStatus();
        }
        private void CheckStatus()
        {
            var pendingOrdersExist = db.Cart.Any(s => s.Order_status == "Pending");

            if (!pendingOrdersExist)
            {
                MessageBox.Show("All orders are complete.");
            }
        }
    }
}
