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

namespace Pharmacy_Management_System.AdministratorUC
{
    public partial class UC_AddUser : UserControl, IAdmin_AddUser
    {

        function fn = new function();
        String query;
        private readonly AdminPresenter _Presenter;

        // getters and setters
        public string Role { get => txtUserRole.Text; set => txtUserRole.Text = value; }
        public string fullName { get => txtFullName.Text; set => txtFullName.Text = value; }
        public string dob { get => txtDOB.Text; set => txtDOB.Text = value; }
        public string email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public long mobile { get => Int64.Parse(txtMobile.Text); set => txtMobile.Text = String.Format("%d",value); }
        public string username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string address { get => txtAddress.Text; set => txtAddress.Text = value; }
        public string password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string OtherDetails { get => txtOtherDetails.Text; set => txtOtherDetails.Text = value; }

        public UC_AddUser()
        {
            InitializeComponent();
            _Presenter = new AdminPresenter(this);
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.TextLength > 6)
            {
                pictureBox2.ImageLocation = @"F:\Semester 6\CO 328\Management System Project\Project Files\Pharmacy Management System\Resources\Icons\yes.png";
            }
            else
            {
                pictureBox2.ImageLocation = @"F:\Semester 6\CO 328\Management System Project\Project Files\Pharmacy Management System\Resources\Icons\no.png";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
            String role = txtUserRole.Text;
            String fullName = txtFullName.Text;
            String dob = txtDOB.Text;
            String email = txtEmail.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String username = txtUsername.Text;
            String address = txtAddress.Text;
            String password = txtPassword.Text;
            String otherDetails = txtOtherDetails.Text;
            
           

            try
            {
                query = "insert into users (userRole,fullName,dob,addres,mobile,email,username,pass,otherDetails) values('"+role+"','"+fullName+"','"+dob+ "','"+address+ "',"+mobile+",'" +email+ "','"+username+ "','"+password+"','"+otherDetails+"')";
                fn.setData(query, "User successfully added.");
            }
            catch(Exception)
            {
                MessageBox.Show("Username already exists.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnResetAddUser_Click(object sender, EventArgs e)
        {
            clearAll(); 
        }

        public void clearAll()
        {

            /*txtAddress.Clear();
            txtDOB.ResetText();
            txtEmail.Clear();
            txtFullName.Clear();
            txtMobile.Clear();
            txtOtherDetails.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            */
            _Presenter.AddUserClearFields();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + txtUsername.Text + "'";
            DataSet ds = fn.GetData(query);

            if((ds.Tables[0].Rows.Count==0) && (txtUsername.TextLength > 2))
            {
                pictureBox1.ImageLocation = @"F:\Semester 6\CO 328\Management System Project\Project Files\Pharmacy Management System\Resources\Icons\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"F:\Semester 6\CO 328\Management System Project\Project Files\Pharmacy Management System\Resources\Icons\no.png";
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
