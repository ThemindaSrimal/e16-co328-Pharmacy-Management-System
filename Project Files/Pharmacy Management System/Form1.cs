using Pharmacy_Managment_System.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    
    public partial class Form1 : Form, ILoginView
    {
       /*
        * Login Form
        */

        function fn = new function();
        String query;
        DataSet ds;
        private readonly LoginPresenter _Presenter;


        public Form1()
        {
            InitializeComponent();
            _Presenter = new LoginPresenter(this);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Dpi;

        }

        public string username { 
            get => txtUsername.Text;
            set { txtUsername.Text = value; }
        }

        public string password
        {
            get => txtPassword.Text;
            set { txtPassword.Text = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // for design in 96 DPI
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // for design in 96 DPI
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // for design in 96 DPI
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // for design in 96 DPI
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // for design in 96 DPI
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // for design in 96 DPI
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // for design in 96 DPI
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // for design in 96 DPI
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            _Presenter.ResetTextBox();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //VerifyUser();
            query = "select * from users";
            ds = fn.GetData(query);

            if(ds.Tables[0].Rows.Count == 0)
            {
                if(txtUsername.Text == "root" && txtPassword.Text == "rootPassword")
                {
                    Administrator admin = new Administrator("root");
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "'";
                ds = fn.GetData(query);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role == "Administrator")
                    {
                        Administrator admin = new Administrator(txtUsername.Text);
                        admin.Show();
                        this.Dispose();
                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist(txtUsername.Text);
                        pharm.Show();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
            
            
            
        }

        
    }
}
