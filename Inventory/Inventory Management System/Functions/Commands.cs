using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using System.Xml.Linq;
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
        public void UpdateStatusCommand(int ID, bool status)
        {
            try
            {
                using (var db = new DB_InventoryEntities())
                {
                    var acc = db.Accounts.Find(ID);
                    if(status)
                    {
                        acc.user_Status = "Active";
                    }
                    else
                    {
                        acc.user_Status = "Inactive";
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditAccountCommand(Accounts acc)
        {
            try
            {
                using (db = new DB_InventoryEntities())
                {
                    Accounts accountUpdate = db.Accounts.Where(i => i.user_ID == acc.user_ID).FirstOrDefault();
                    if(accountUpdate != null) 
                    {
                        accountUpdate.user_firstname = acc.user_firstname;
                        accountUpdate.user_lastname = acc.user_lastname;
                        accountUpdate.user_email = acc.user_email;
                        accountUpdate.user_Address = acc.user_Address;
                        accountUpdate.user_phone = acc.user_phone;
                        accountUpdate.user_position = acc.user_position;
                        accountUpdate.user_name = acc.user_name;
                        accountUpdate.user_password = acc.user_password;

                        db.SaveChanges();
                        MessageBox.Show("Saved!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
