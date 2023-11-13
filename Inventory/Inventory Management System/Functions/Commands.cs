using System;
using System.Collections.Generic;
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
        public void InitializeDB()
        {
            db = new DB_InventoryEntities();
        }
        public Commands (DB_InventoryEntities db)
        {
            db = new DB_InventoryEntities();
        }
        public void AddNewProductCommand(String category, String ItemName, String SKU, String Quantity, decimal Price, String Description)
        {
            db.sp_AddNewProduct(category, ItemName, SKU, Quantity, Price, Description);
        }
    }
}
