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
using System.Linq.Expressions;

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
        public void AddToCart(int OrderNo, int product, int categoryID, int user_ID, int quantity, string customerName, string customerAddress)
        {
            try
            {
                using (var db = new DB_InventoryEntities())
                {
                    //var lastOrderNo = db.vw_LastOrderNumber.FirstOrDefault();
                    DateTime currentDate = DateTime.Now;
                    string formattedDate = currentDate.ToString("dddd, dd MMMM yyyy");

                    var Order = new Cart
                    {
                        productID = product,
                        categoryID = categoryID,
                        user_ID = user_ID,

                        OrderNo = OrderNo,
                        OrderQuantity = quantity,
                        customer_name = customerName,
                        customer_address = customerAddress,
                        Order_status = "Pending",
                        Order_Date = currentDate
                    };

                    db.Cart.Add(Order);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void UpdateProductQty(int ProductID, string CartQty)
        {
            dbContext();

            // Retrieve the product from the database
            Products productInfo = db.Products.SingleOrDefault(i => i.productID == ProductID);

            if (productInfo != null)
            {
                int newQty = Convert.ToInt32(productInfo.product_Quantity) + Convert.ToInt32(CartQty);
                productInfo.product_Quantity = newQty.ToString();

                db.SaveChanges();
            }
            else
            {
                MessageBox.Show($"No product found with productID {ProductID}");
            }
        }
        public void RemoveProductInCart(int ID)
        {
            using (var db = new DB_InventoryEntities())
            {
                var removeUsingID = db.Cart.Where(i => i.CartID == ID);
                foreach (var productInfo in removeUsingID)
                {
                    db.Cart.Remove(productInfo);
                }
                db.SaveChanges();
                MessageBox.Show("Remove product successfully!", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void EditCartQuantity(int ID, int ProductID, int TotalQuantity, int newInputtedQuantity)
        {
            using (var db = new DB_InventoryEntities())
            {
                Cart cartQuantity = db.Cart.SingleOrDefault(q => q.CartID == ID);
                Products productInfo = db.Products.SingleOrDefault(p => p.productID == ProductID);
                if (cartQuantity != null)
                {
                    productInfo.product_Quantity = Convert.ToString(TotalQuantity - newInputtedQuantity);
                    cartQuantity.OrderQuantity = newInputtedQuantity;

                    db.SaveChanges();
                    MessageBox.Show($"Edited successfully! The product_Quantity is now: {productInfo.product_Quantity}", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Can't find the product ID: {cartQuantity.productID}");
                }
            }
        }
        public void UpdateCartStatus(int CartID, String CartStatus)
        {
            try
            {
                using (var db = new DB_InventoryEntities())
                {
                    Cart cartStatus = db.Cart.SingleOrDefault(c => c.CartID == CartID);
                    {
                        if (CartStatus.Equals("Pending"))
                        {
                            cartStatus.Order_status = "Completed";
                            MessageBox.Show("Order is ready");
                            db.SaveChanges();
                        }
                        else
                        {
                            cartStatus.Order_status = "Pending";
                            db.SaveChanges();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void AddHistoryTransac(int cartID, int userID, int productID, int categoryID)
        {
            try
            {
                using (var db = new DB_InventoryEntities())
                {
                    var historyTransaction = new HistoryTransaction
                    {
                        CartID = cartID,
                        user_ID = userID,
                        productID = productID,
                        categoryID = categoryID
                    };
                    db.HistoryTransaction.Add(historyTransaction);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
