using System;
using System.Data;

namespace Pharmacy_Managment_System.Core
{
    public class LoginPresenter
    {
        private readonly ILoginView _View;
        private Model model = new Model();

        public LoginPresenter(ILoginView view)
        {
            this._View = view; 
        }

        public void ResetTextBox()
        {
            _View.username = "";
            _View.password = "";
        }

        public void VerifyUser()
        {
            string query = "select * from users";
            DataSet ds = model.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                if (_View.username == "root" && _View.password == "rootPassword")
                {
                    
                    //Administrator admin = new Administrator();
                    //admin.Show();
                }
                
            }
            else
            {
                query = "select * from users where username = '" + _View.username + "' and pass = '" + _View.password + "'";
                ds = model.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        //Administrator admin = new Administrator(txtUsername.Text);
                        //admin.Show();
                        //this.Hide();
                        
                    }
                    else if (role == "Pharmacist")
                    {
                        //Pharmacist pharm = new Pharmacist(txtUsername.Text);
                        //pharm.Show();
                        //this.Hide();
                        
                    }
                }
                else
                {
                    
                    //MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
