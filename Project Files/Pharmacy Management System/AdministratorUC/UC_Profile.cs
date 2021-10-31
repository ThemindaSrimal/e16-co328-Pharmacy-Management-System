using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.AdministratorUC
{
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        String query;
        public UC_Profile()
        {
            InitializeComponent();
        }

        public String ID
        {
            set { txtUsername.Text = value; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnResetprofile_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            try
            {
                query = "select * from users where username = '" + txtUsername.Text + "'";
                DataSet ds = fn.GetData(query);
                txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
                //txtUsername.Text = ds.Tables[0].Rows[0][1].ToString();
                txtPassword.Text = ds.Tables[0].Rows[0][8].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                txtFullName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                txtdetails.Text = ds.Tables[0].Rows[0][9].ToString();
                txtdateOfBirth.Text = ds.Tables[0].Rows[0][3].ToString();
                txtaddress.Text = ds.Tables[0].Rows[0][4].ToString();
            }
            catch
            {

            }
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String fulllname = txtFullName.Text;
            String dob = txtdateOfBirth.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String userName = txtUsername.Text;
            String pass = txtPassword.Text;
            String add = txtaddress.Text;
            String details = txtdetails.Text;

            query = "update users set userRole = '"+role+"',fullName='"+fulllname+"',dob = '"+dob+"',addres = '"+add+"',mobile = '"+mobile+"',email = '"+email+"',username='"+userName+"',pass='"+pass+"',otherDetails='"+details+"' where username = '"+userName+"'";
            fn.setData(query, "Profile update successful.");

        }
    }
}
