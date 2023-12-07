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
using Inventory_Management_System.Models;
using System.Data.Entity;
using Inventory_Management_System.Functions;

namespace Inventory_Management_System
{
    public partial class Login : Form
    {
        private readonly LoginFunction validate;

        private readonly AdminDashboard Form_Admin;
        private readonly ManagerDashboard Form_Manager;
        private readonly ClerksDashboard Form_Clerk;
        public Login()
        {
            InitializeComponent();
            validate = new LoginFunction();

            Form_Admin = new AdminDashboard();
            Form_Manager = new ManagerDashboard();
            Form_Clerk = new ClerksDashboard();
        }
        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UsernameLineLabel()
        {
            lblPassword.ForeColor = Color.Black;
            lblUsername.ForeColor = Color.Blue;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Field is empty!");
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Field is Empty");
            }
            else
            {
                int account = validate.GetAccount(txtUsername.Text, txtPassword.Text);

                String position = validate.GetPosition(account);
                String fullName = validate.FullName(account);

                //Determine the position of the user.
                if (account != 0)
                {
                    switch (position)
                    {
                        case "Admin":
                            MessageBox.Show("Welcome Admin!");
                            this.Hide();
                            //AdminDashboard Form_Admin = new AdminDashboard();
                            Form_Admin.account_fullname = "Admin "+fullName;
                            Form_Admin.Show();
                            break;
                        case "Manager":
                            MessageBox.Show("Welcome Manager!");
                            this.Hide();
                            //ManagerDashboard Form_Manager = new ManagerDashboard();
                            Form_Manager.account_fullname = "Manager " + fullName;
                            Form_Manager.Show();
                            break;
                        case "Clerk":
                            MessageBox.Show("Welcome Clerk!");
                            this.Hide();
                            //ClerksDashboard Form_Clerk = new ClerksDashboard();
                            Form_Clerk.account_fullname = "Clerk " + fullName;
                            Form_Clerk.userID = account;
                            Form_Clerk.Show();
                            break;
                    }
                }
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            UsernameLineLabel();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            UsernameLineLabel();
        }
        
        private void PasswordLineLabel()
        {
            lblUsername.ForeColor = Color.Black;
            lblPassword.ForeColor = Color.Blue;
        }
        private void txtPassword_Click(object sender, EventArgs e)
        {
            PasswordLineLabel();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            PasswordLineLabel();
        }
    }
}
