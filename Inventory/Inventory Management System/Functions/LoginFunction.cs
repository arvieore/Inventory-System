using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Management_System.Models;
using System.Data.Entity;
using System.Collections;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public class LoginFunction
    {
        private DB_InventoryEntities db;

        public int GetAccount(String username, String userpass)
        {
            //GET THE ID BY USING SPECIFIC USERNAME AND PASSWORD
            db = new DB_InventoryEntities();

            var account = db.Accounts.Where(a => a.user_name == username && a.user_password == userpass).FirstOrDefault();
            if (account != null)
            {
                if (account.user_Status == "Active")
                {
                    return account.user_ID;
                }
                else
                {
                    MessageBox.Show("The account is Inactive.");
                    return 0;
                }
            }
            else
                MessageBox.Show("Account does not exist");
                return 0;
        }
        public String GetPosition(int id)
        {
            //SELECT THE POSITION BY SPECIFIC ID
            return db.Accounts.Where(a => a.user_ID == id).Select(a => a.user_position).FirstOrDefault();
        }
        public string FullName(int id)
        {
            using (var db = new DB_InventoryEntities())
            {
                var fullName = db.Accounts.Where(a => a.user_ID == id).Select(a => a.user_firstname + " " + a.user_lastname).FirstOrDefault();

                return fullName;
            }
        }
    }
}
