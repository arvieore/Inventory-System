using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Models;
using Inventory_Management_System.UserControls;

namespace Inventory_Management_System.Functions
{
    internal class Commands
    {
        private DB_InventoryEntities db;
        private void dbContext()
        {
            db = new DB_InventoryEntities();
        }
        public void AddNewProductCommand(String category, String ItemName, String SKU, String Quantity, decimal Price, String Description)
        {
            dbContext();
            db.sp_AddNewProduct(category, ItemName, SKU, Quantity, Price, Description);
            MessageBox.Show("Added successfully!");
        }
        public void EditProductsCommand(int id, String Name, String Sku, String Qty, decimal? Price, String Description)
        {
            try
            {
                dbContext();
                Products productInfo = db.Products.Where(i => i.productID == id).FirstOrDefault();

                productInfo.product_Name = Name;
                productInfo.product_Sku = Sku;
                productInfo.product_Quantity = Qty;
                productInfo.product_Price = Price;
                productInfo.product_Description = Description;

                db.SaveChanges();
                MessageBox.Show("Saved!");
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        public void RemoveProductCommand(Products product)
        {
            try
            {
                dbContext();
                var RemoveProduct = db.Products.Find(product.productID);
                DialogResult result = MessageBox.Show("Continue to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    db.Products.Remove(RemoveProduct);
                    db.SaveChanges();
                    MessageBox.Show("Delete successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cancel delete", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: "+ e.Message);
            }
        }
    }
}
