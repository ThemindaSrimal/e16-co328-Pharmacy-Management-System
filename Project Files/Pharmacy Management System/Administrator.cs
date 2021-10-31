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
    public partial class Administrator : Form, IAdminView
    {

        String user = "";

        private readonly AdminPresenter _Presenter;

        public Administrator()
        {
            _Presenter = new AdminPresenter(this);
            InitializeComponent();
        }

        public String ID
        {
            get{ return user.ToString(); }
        }
        public Administrator(String username)
        {
            InitializeComponent();
            _Presenter = new AdminPresenter(this);
            adminUsernameLabel.Text = username;
            user = username;
            uC_viewUser2.ID = ID;
            uC_Profile2.ID = ID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Dispose();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard2.Visible = true;
            uC_Dashboard2.BringToFront();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard2.Visible = true;
            uC_AddUser2.Visible = false;
            uC_viewUser2.Visible = false;
            uC_Profile2.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser2.Visible = true;
            uC_AddUser2.BringToFront(); 
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_viewUser2.Visible = true;
            uC_viewUser2.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uC_Profile2.Visible = true;
            uC_Profile2.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminUsernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
