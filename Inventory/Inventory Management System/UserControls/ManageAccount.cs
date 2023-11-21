using Inventory_Management_System.Models;
using Inventory_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace Inventory_Management_System.UserControls
{
    public partial class ManageAccount : UserControl
    {
        private DB_InventoryEntities db;
        public ManageAccount()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
        }
        public void loadCbBoxRole()
        {
            // SELECT * FROM Role
            var roles = db.Role.ToList();

            Cbox_Roles.ValueMember = "roleID";
            Cbox_Roles.DisplayMember = "roleName";
            Cbox_Roles.DataSource = roles;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }

        private void dgv_Accounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cbox_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountDisplay();
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            loadCbBoxRole();
            AccountDisplay();
        }
        //This method is to display the Accounts and also filtered display.
        public void AccountDisplay()
        {
            if (Cbox_Roles.Text == "All")
            {
                dgv_Accounts.DataSource = (from account in db.Accounts
                                           select new
                                           {
                                               ID = account.user_ID,
                                               Fullname = account.user_firstname + " " + account.user_lastname,
                                               Email = account.user_email,
                                               Address = account.user_Address,
                                               Phone = account.user_phone,
                                               Position = account.user_position,
                                               Username = account.user_name,
                                           }).ToList();
            }
            else
            {
                dgv_Accounts.DataSource = (from account in db.Accounts
                                           where account.user_position == Cbox_Roles.Text
                                           select new
                                           {
                                               ID = account.user_ID,
                                               Fullname = account.user_firstname + " " + account.user_lastname,
                                               Email = account.user_email,
                                               Address = account.user_Address,
                                               Phone = account.user_phone,
                                               Position = account.user_position,
                                               Username = account.user_name,
                                           }).ToList();
            }
            dgv_Accounts.Columns["ID"].Width = 30;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterData(txtSearch.Text.ToLower());
        }

        //Filtered Search
        private void FilterData(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                AccountDisplay();
            }
            else
            {
                var searchData = db.sp_AccountFilter(Cbox_Roles.Text)
                    .Where(acc =>
                        acc.ID.ToString().Contains(searchText) ||
                        acc.Fullname.ToLower().Contains(searchText) ||
                        acc.Email.ToLower().Contains(searchText) ||
                        acc.Address.ToLower().Contains(searchText) ||
                        acc.Phone.ToLower().Contains(searchText) ||
                        acc.Username.ToLower().Contains(searchText)
                    )
                    .ToList();

                dgv_Accounts.DataSource = searchData;
            }
        }
    }
}
