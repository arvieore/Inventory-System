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

namespace Inventory_Management_System
{
    public partial class Login : Form
    {
        private readonly LoginFunction validate;
        public Login()
        {
            InitializeComponent();
            validate = new LoginFunction();
        }
        private void txtLogin_Click(object sender, EventArgs e)
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

                //Determine the position of the user.
                if (account != 0)
                {
                    switch(position)
                    {
                        case "Admin":
                            MessageBox.Show("Welcome Admin!");
                            this.Hide();
                            AdminDashboard Form_Admin = new AdminDashboard();
                            Form_Admin.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Account!");
                }
            }
        }

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UsernameLineLabel()
        {
            lblPassword.ForeColor = Color.Black;
            lblUsername.ForeColor = Color.Blue;
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
