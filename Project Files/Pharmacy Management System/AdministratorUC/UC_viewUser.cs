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
    public partial class UC_viewUser : UserControl
    {
        function fn = new function();
        String query;
        String currentUser;
        public UC_viewUser()
        {
            InitializeComponent();
        }

        public String ID
        {
            set { currentUser = value; }
        }

        private void btnAddUser_Click(object sender, EventArgs e) // This is delete button click not adduserclick
        {
            if (MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != username)
                {
                    query = "delete from users where username = '" + username + "'";
                    fn.setData(query,"User record deleted.");
                    UC_viewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Can't delete your own profile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UC_viewUser_Load(object sender, EventArgs e)
        {
            query = "select username as UserName,userRole as UserRole,fullName as FullName,mobile as Mobile,addres as Address,otherDetails as Details from users";
            DataSet ds = fn.GetData(query);
            viewUserGridView.DataSource = ds.Tables[0];
            String query2 = "select count(id) from users";
            ds = fn.GetData(query2);
            totalUsers.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void txtsearchbyUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select username as UserName,userRole as UserRole,fullName as FullName,mobile as Mobile,addres as Address,otherDetails as Details from users where username like '%"+txtsearchbyUsername.Text+"%'";
            DataSet ds = fn.GetData(query);
            viewUserGridView.DataSource = ds.Tables[0]; 
        }
        String username;
        private void viewUserGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username = viewUserGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnViewuserRefresh_Click(object sender, EventArgs e)
        {
            UC_viewUser_Load(this, null);
        }

        private void totalUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
