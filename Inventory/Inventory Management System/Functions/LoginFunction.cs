using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.Models;
using System.Data.Entity;
using System.Collections;
using System.Web.UI.WebControls;

namespace Inventory_Management_System
{
    public class LoginFunction
    {
        private DB_InventoryEntities db;

        public int GetAccount(String username, String userpass)
        {
            //GET THE ID BY USING SPECIFIC USERNAME AND PASSWORD
            db = new DB_InventoryEntities();
            int userID = db.Accounts.Where(a => a.user_name == username && a.user_password == userpass).Select(a => a.user_ID).FirstOrDefault();
            if (userID != 0)
            {
                return userID;
            }
            else
                return 0;
            //var account =  db.Accounts.Where(a => a.user_name == username && a.user_password == userpass).FirstOrDefault();
            //if (account != null)
            //{
            //    return account.user_ID;
            //}
            //else
            //    return null;
        }
        public String GetPosition(int id)
        {
            //SELECT THE POSITION BY SPECIFIC ID
            return db.Accounts.Where(a => a.user_ID == id).Select(a => a.user_position).FirstOrDefault();
        }
    }
}
