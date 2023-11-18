using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Functions
{
    public class UserRegistration
    {
        private DB_InventoryEntities db;

        private DB_InventoryEntities dbContext()
        {
            return db = new DB_InventoryEntities();
        }
        public void RegisterAccount(String firstname, String lastname, String email, String phone, String gender, DateTime birthdate, String position, String password, String address)
        {
            using (var db = dbContext())
            {
                db.sp_AddAccount(firstname, lastname, email, phone, gender, birthdate, position, password, address);
            }
        }
    }
}
