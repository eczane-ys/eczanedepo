﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsarname.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if(txtUsarname.Text=="root" && txtPassword.Text== "root")
                {
                    Adminstrator admin = new Adminstrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username ='" + txtUsarname.Text + "' and pass='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role =="Administrator")
                    {
                        Adminstrator admin =new Adminstrator(txtUsarname.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if(role =="Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show(); 
                        this.Hide();
                    }

                }
                else
                { 
                    MessageBox.Show("Yanlış Kullanıcı Adı Veya Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }





















            //if (txtUsarname.Text == "admin" && txtPassword.Text == "admin")
            //{
            //    Adminstrator am = new Adminstrator();
            //    am.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
