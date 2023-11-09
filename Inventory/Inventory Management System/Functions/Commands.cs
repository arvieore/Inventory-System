using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Functions
{
    internal class Commands
    {
        private DB_InventoryEntities db;

        public void InsertCommand()
        {

        }
        public void AddNewProductCommand(String category, String ItemName, String SKU, String Quantity, decimal Price, String Description)
        {
            db.sp_AddNewProduct(category, ItemName, SKU, Quantity, Price, Description);
        }
    }
}
