using Inventory_Management_System.Functions;
using Inventory_Management_System.Models;
using Inventory_Management_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class EditForm : Form
    {
        private Commands commands;
        private Products editProduct;
        private ProductControl productControl;
        public EditForm(Products products, ProductControl productControl)
        {
            InitializeComponent();
            editProduct = products;
            this.productControl = productControl;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            txtID.Text = editProduct.productID.ToString();
            txtItemName.Text = editProduct.product_Name;
            txtSKU.Text = editProduct.product_Sku;
            txtQuantity.Text = editProduct.product_Quantity;
            txtItemPrice.Text = editProduct.product_Price.ToString();
            txtDescription.Text = editProduct.product_Description;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text))
            {
                errorProvider.SetError(txtID, "Field empty!");
            }
            else if (String.IsNullOrEmpty(txtItemName.Text))
            {
                errorProvider.SetError(txtItemName, "Field empty!");
            }
            else if (String.IsNullOrEmpty(txtSKU.Text))
            {
                errorProvider.SetError(txtSKU, "Field empty!");
            }
            else if (String.IsNullOrEmpty(txtItemPrice.Text))
            {
                errorProvider.SetError(txtItemPrice, "Field empty!");
            }
            else if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                errorProvider.SetError(txtQuantity, "Field empty!");
            }
            else if (String.IsNullOrEmpty(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Field empty!");
            }
            else
            {
                NoIssue();
            }
        }
        private void NoIssue()
        {
            editProduct = new Products
            {
                productID = int.Parse(txtID.Text),
                product_Name = txtItemName.Text,
                product_Sku = txtSKU.Text,
                product_Quantity = txtQuantity.Text,
                product_Price = decimal.Parse(txtItemPrice.Text),
                product_Description = txtDescription.Text,
            };
            commands = new Commands();
            commands.EditProductsCommand(editProduct.productID, editProduct.product_Name, editProduct.product_Sku, editProduct.product_Quantity, editProduct.product_Price, editProduct.product_Description);
            RefreshTable();
            Clear();
        }
        private void Clear()
        {
            txtID.Text = txtItemName.Text = txtItemPrice.Text = txtQuantity.Text = txtSKU.Text = txtDescription.Text = "";
        }
        private void RefreshTable()
        {
            productControl.LoadTable();
        }
    }
}
