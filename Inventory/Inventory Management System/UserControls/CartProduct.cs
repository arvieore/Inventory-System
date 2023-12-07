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
    public partial class CartProduct : UserControl
    {
        private DB_InventoryEntities db;
        private DataGridViewButtonColumn btnRemove;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDone;

        private Commands cmd;

        public int accountID;
        private bool btns = true;
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
            loadCbBoxCategory();
            LoadCart();
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
        private void dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_Products.Rows[e.RowIndex];
            if(e.ColumnIndex == dgv_Products.Columns["btnRemove"].Index && e.RowIndex >= 0)
            {
                int ProductID = Convert.ToInt32(selectedRow.Cells["ProductID"].Value); //ID sa Products
                int ID = Convert.ToInt32(selectedRow.Cells["ID"].Value); //ID sa Cart
                String Qty = selectedRow.Cells["Quantity"].Value.ToString(); //Quantity sa Cart

                cmd.UpdateProductQty(ProductID, Qty);

                var removeUsingID = db.Cart.Where(i => i.CartID == ID);
                foreach (var productInfo in removeUsingID)
                {
                    db.Cart.Remove(productInfo);
                }

                db.SaveChanges();
                btns = false;
                LoadCart();


                MessageBox.Show($"button remove click, Quantity: {Qty}");
            }
            if (e.ColumnIndex == dgv_Products.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("button edit");
            }
            if (e.ColumnIndex == dgv_Products.Columns["btnDone"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("button done");
            }
        }
    }
}
