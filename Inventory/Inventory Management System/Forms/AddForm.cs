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
using Inventory_Management_System.Functions;
using Inventory_Management_System.UserControls;
using Guna.UI2.WinForms.Suite;
using System.Diagnostics;

namespace Inventory_Management_System.Forms
{
    public partial class AddForm : Form
    {
        private DB_InventoryEntities db;
        private String category;
        private Commands cmd;
        private ProductControl productControl;
        public AddForm(ProductControl productControl)
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
            this.productControl = productControl;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            loadCbBoxCategory();
        }
        public void loadCbBoxCategory()
        {
            // SELECT * FROM Category
            var categories = db.Category.Where(c => c.categoryID != 1).ToList();

            cbx_Category.ValueMember = "categoryID";
            cbx_Category.DisplayMember = "categoryName";
            cbx_Category.DataSource = categories;
        }
        private void rbtnExist_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnExist.Checked)
            {
                txtCategory.Enabled = false;
                cbx_Category.Enabled = true;
            }
            else
            {
                txtCategory.Enabled = true;
                cbx_Category.Enabled = false;
            }
        }

        private void rbtnNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNew.Checked)
            {
                txtCategory.Enabled = true;
                cbx_Category.Enabled = false;
            }
            else
            {
                txtCategory.Enabled = false;
                cbx_Category.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbtnNew.Checked)
            {
                category = txtCategory.Text;
            }
            else if (rbtnExist.Checked)
            {
                category = cbx_Category.Text;
            }
            cmd = new Commands();
            cmd.AddNewProductCommand(category, txtItemName.Text, txtSKU.Text, txtQuantity.Text, decimal.Parse(txtItemPrice.Text), txtDescription.Text);

            productControl.loadCbBoxCategory();
            productControl.LoadTable();
            Clear();
        }
        private void Clear()
        {
            txtCategory.Text = txtItemName.Text = txtItemPrice.Text = txtQuantity.Text = txtSKU.Text = txtDescription.Text = "";
        }
    }
}
