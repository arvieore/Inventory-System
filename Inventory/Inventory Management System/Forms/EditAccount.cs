using Inventory_Management_System.Functions;
using Inventory_Management_System.Models;
using Inventory_Management_System.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class EditAccount : Form
    {
        private Commands commands;
        private int ID;
        private ManageAccount AccountControl;
        private DB_InventoryEntities db;
        private Accounts Accounts;
        private bool pass = false;
        private String pattern = @"[.,'""\]\[{^@&#!%()_=+}\\|:;*]";
        public EditAccount(int ID, ManageAccount manageAccount)
        {
            InitializeComponent();
            this.ID = ID;
            this.AccountControl = manageAccount;
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            loadCbBoxCategory();
            DisplayAccountInfo();
        }
        private void DisplayAccountInfo()
        {
            try
            {
                using (db = new DB_InventoryEntities())
                {
                    Accounts accounts = db.Accounts.Find(ID);
                    if (accounts != null)
                    {
                        txtID.Text = accounts.user_ID.ToString();

                        txtFirstname.Text = accounts.user_firstname;
                        txtLastname.Text = accounts.user_lastname;
                        txtEmail.Text = accounts.user_email.Replace("@gmail.com", "");
                        txtAddress.Text = accounts.user_Address;
                        txtPhone.Text = accounts.user_phone;

                        Cbox_Position.Text = accounts.user_position;

                        txtUsername.Text = accounts.user_name;
                        txtPassword.Text = accounts.user_password;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }
        public void loadCbBoxCategory()
        {
            // SELECT * FROM Role
            using (db = new DB_InventoryEntities())
            {
                var role = db.Role.Where(c => c.roleID != 1).ToList();

                Cbox_Position.ValueMember = "roleID";
                Cbox_Position.DisplayMember = "roleName";
                Cbox_Position.DataSource = role;
            }
        }
        private void picPassword_Click(object sender, EventArgs e)
        {
            if (pass)
            {
                picPassword.Image = Properties.Resources.View;
                txtPassword.PasswordChar = '\0';
                pass = false;
            }
            else if (!pass)
            {
                picPassword.Image = Properties.Resources.Hide;
                txtPassword.PasswordChar = '*';
                pass = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtFirstname.Text))
            {
                errorProvider.SetError(txtFirstname, "Field is empty!");
            }
            else if (String.IsNullOrEmpty(txtLastname.Text))
            {
                errorProvider.SetError(txtLastname, "Field is empty!");
            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Field is empty!");
            }
            else if (String.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Field is empty!");
            }
            else if (String.IsNullOrEmpty(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Field is empty!");
            }
            else if (String.IsNullOrEmpty(Cbox_Position.Text))
            {
                errorProvider.SetError(Cbox_Position, "Field is empty!");
            }
            else if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Field is empty!");
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Field is empty!");
            }
            else if (Regex.IsMatch(txtFirstname.Text, pattern))
            {
                MessageBox.Show("Please avoid using Symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtFirstname, "Avoid using symbols!");
                txtFirstname.BorderColor = Color.Red;
                return;
            }
            else if (Regex.IsMatch(txtFirstname.Text, @"\d"))
            {
                MessageBox.Show("The firstname contain a number(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtFirstname, "Contain a number(s)!");
                txtFirstname.BorderColor = Color.Red;
                return;
            }
            else if (Regex.IsMatch(txtLastname.Text, pattern))
            {
                MessageBox.Show("Please avoid using Symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtLastname, "Avoid using symbols!");
                txtLastname.BorderColor = Color.Red;
                return;
            }
            else if (Regex.IsMatch(txtLastname.Text, @"\d"))
            {
                MessageBox.Show("The lastname contain a number(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtFirstname, "Contain a number(s)!");
                txtLastname.BorderColor = Color.Red;
                return;
            }
            else if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                MessageBox.Show("Please avoid using Symbols.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(txtEmail, "Avoid using symbols!");
                txtEmail.BorderColor = Color.Red;
                return;
            }
            else
            {
                NoIssue();
            }
        }
        private void NoIssue()
        {
            try
            {
                string userEmail = txtEmail.Text + "" + DefaultEmailSmbol.Text;
                Accounts = new Accounts
                {
                    user_ID = Convert.ToInt32(txtID.Text),
                    user_firstname = txtFirstname.Text,
                    user_lastname = txtLastname.Text,
                    user_email = userEmail,
                    user_Address = txtAddress.Text,
                    user_phone = txtPhone.Text,
                    user_position = Cbox_Position.Text,
                    user_name = txtUsername.Text,
                    user_password = txtPassword.Text
                };
                commands = new Commands();
                commands.EditAccountCommand(Accounts);
                Clear();
                RefreshTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid" + ex.Message);
            }
        }
        private void Clear()
        {
            txtID.Text = txtFirstname.Text = txtLastname.Text = txtEmail.Text = txtAddress.Text = txtPhone.Text = txtUsername.Text = txtPassword.Text = "";
        }
        private void RefreshTable()
        {
            AccountControl.AccountDisplay();
        }
    }
}
