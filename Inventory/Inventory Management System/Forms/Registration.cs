﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_System.Functions;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Forms
{
    public partial class Registration : Form
    {
        private String gender;
        private DB_InventoryEntities db;
        public Registration()
        {
            InitializeComponent();
            db = new DB_InventoryEntities();
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            loadCbBoxCategory();
        }
        public void loadCbBoxCategory()
        {
            // SELECT * FROM Role
            var role = db.Role.Where(c => c.roleID != 1).ToList();

            Cbox_Position.ValueMember = "roleID";
            Cbox_Position.DisplayMember = "roleName";
            Cbox_Position.DataSource = role;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create backToCreate = new Create();
            backToCreate.ShowDialog();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtFirstname.Text))
                {
                    errorProvider.SetError(txtFirstname, "Empty field!");
                    txtFirstname.BorderColor = Color.Red;
                }
                else if (String.IsNullOrEmpty(txtLastname.Text))
                {
                    errorProvider.SetError(txtLastname, "Empty field!");
                    txtLastname.BorderColor = Color.Red;
                }
                else if (String.IsNullOrEmpty(txtEmail.Text))
                {
                    errorProvider.SetError(txtEmail, "Empty field!");
                    txtEmail.BorderColor = Color.Red;
                }
                else if (String.IsNullOrEmpty(txtAddress.Text))
                {
                    errorProvider.SetError(txtAddress, "Empty field!");
                    txtAddress.BorderColor = Color.Red;
                }
                else if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    errorProvider.SetError(txtPassword, "Empty field!");
                    txtPassword.BorderColor = Color.Red;
                }
                else if (String.IsNullOrEmpty(txtConfirmpassword.Text))
                {
                    errorProvider.SetError(txtConfirmpassword, "Empty field!");
                    txtConfirmpassword.BorderColor = Color.Red;
                }
                else if (!txtPassword.Text.Equals(txtConfirmpassword.Text))
                {
                    errorProvider.SetError(txtConfirmpassword, "Password mismatch");
                    txtPassword.BorderColor = Color.Red;
                    txtConfirmpassword.BorderColor = Color.Red;
                }
                else
                {
                    UserRegistration register = new UserRegistration();
                    Gender();
                    register.RegisterAccount(txtFirstname.Text, txtLastname.Text, txtEmail.Text, txtPhone.Text, gender, birthdate_picker.Value, Cbox_Position.Text, txtPassword.Text, txtAddress.Text);
                    Confirm();
                }
            }
            catch(Exception ex)
            {
                Clear();
                MessageBox.Show("Error: "+ ex.Message);
            }
        }
        void Clear()
        {
            txtFirstname.Text = txtLastname.Text = txtEmail.Text = txtPhone.Text = gender = Cbox_Position.Text = txtPassword.Text = txtConfirmpassword.Text = txtAddress.Text = "";
            loadCbBoxCategory();
        }
        private void Confirm()
        {
            Clear();
            MessageBox.Show("Registered successfully!");
        }
        private void Gender()
        {
            if(rbtnMale.Checked)
            {
                gender = rbtnMale.Text;
            }
            else if(rbtnFemale.Checked)
            {
                gender = rbtnFemale.Text;
            }
        }
    }
}
