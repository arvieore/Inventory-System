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
using Inventory_Management_System.Functions;

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

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            PointF pnt1 = new PointF(8.0F, 50.0F);
            PointF pnt2 = new PointF(960.0F, 50.0F);

            e.Graphics.DrawLine(blackPen, pnt1, pnt2);
        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM Role
            var roles = db.Role.ToList();

            Cbox_Roles.ValueMember = "roleID";
            Cbox_Roles.DisplayMember = "roleName";
            Cbox_Roles.DataSource = roles;
        }

        //This method is to display the Accounts and also filtered display.
        public void AccountDisplay()
        {
            dgv_Accounts.DataSource = db.sp_AccountFilter(Cbox_Roles.Text).ToList();
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
                                               Status = account.user_Status
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
                                               Status = account.user_Status
                                           }).ToList();
            }

            dgv_Accounts.Columns["ID"].Width = 30;

            // Ensure the display order of the columns
            dgv_Accounts.Columns["ID"].DisplayIndex = 0;
            dgv_Accounts.Columns["Fullname"].DisplayIndex = 1;
            dgv_Accounts.Columns["Email"].DisplayIndex = 2;
            dgv_Accounts.Columns["Address"].DisplayIndex = 3;
            dgv_Accounts.Columns["Phone"].DisplayIndex = 4;
            dgv_Accounts.Columns["Position"].DisplayIndex = 5;
            dgv_Accounts.Columns["Username"].DisplayIndex = 6;
            dgv_Accounts.Columns["Status"].DisplayIndex = 7;

            // Find the index of the "Status" column
            int statusColumnIndex = dgv_Accounts.Columns["Status"].Index;

            // Add the "Edit" button column after the "Status" column
            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Name = "btnEdit",
                FlatStyle = FlatStyle.Flat
            };

            // Check if the column already exists before adding it
            if (!dgv_Accounts.Columns.Contains("btnEdit"))
            {
                // Insert the "Edit" button column after the "Status" column
                dgv_Accounts.Columns.Insert(statusColumnIndex + 1, editButton);

                // Ensure "Edit" comes after "Status"
                int editColumnIndex = dgv_Accounts.Columns["btnEdit"].Index;
                if (editColumnIndex <= statusColumnIndex)
                {
                    dgv_Accounts.Columns["btnEdit"].DisplayIndex = statusColumnIndex + 1;
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Registration register = new Registration(this);
            register.ShowDialog();
        }

        private void dgv_Accounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_Accounts.Rows[e.RowIndex];

            Accounts account = new Accounts
            {
                user_Status = selectedRow.Cells["Status"].Value.ToString()
            };

            if (account.user_Status.Equals("Active"))
            {
                ToggleStatus.Checked = true;
            }
            else
            {
                ToggleStatus.Checked = false;
            }

            //Edit button
            if (e.ColumnIndex == dgv_Accounts.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                int ID = int.Parse(selectedRow.Cells["ID"].Value.ToString());
                EditAccount edit = new EditAccount(ID, this);
                edit.ShowDialog();
            }
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

        private void ToggleStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Accounts.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgv_Accounts.SelectedRows[0];
                    int GetID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                    bool status = ToggleStatus.Checked;

                    Commands statusCMD = new Commands();
                    statusCMD.UpdateStatusCommand(GetID, status);
                    AccountDisplay();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
