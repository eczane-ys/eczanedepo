﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

            try
            {
                query = "insert into users (userRole, name, dob, mobile, email, username, pass)values ('"+role+ "','" +name+ "','"+dob+ "','"+mobile+ "','"+email+ "','"+username+"','"+pass+"')";
                fn.setData(query, "Sign Up Successful.");

            }

            catch (Exception)
            {
                MessageBox.Show("Username Allready exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                // dosya yolu hata veriyo değişicek
                pictureBox1.ImageLocation = @"C:\\Users\\lenovo\\Desktop\\C# Pharmacy Management System\\Pharmacy Management System in C#\\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\\Users\\lenovo\\Desktop\\C# Pharmacy Management System\\Pharmacy Management System in C#\\no.png";
            }
        }
    }


}