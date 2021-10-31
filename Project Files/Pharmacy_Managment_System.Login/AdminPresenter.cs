using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managment_System.Core
{
    public class AdminPresenter
    {
        private readonly IAdminView _AdminView;
        private readonly IAdmin_AddUser _AddUserView;
        private readonly IAdmin_Dashboard _DashboardView;
        private readonly IAdmin_Profile _ProfileView;
        private readonly IAdmin_viewUser _ViewUserView;

        private Model model = new Model();

        // constructors
        public AdminPresenter(IAdminView adminview)
        {
            this._AdminView = adminview;
            
        }
        public AdminPresenter(IAdmin_AddUser adminview_adduser)
        {
            this._AddUserView = adminview_adduser;
        }
        public AdminPresenter(IAdmin_Dashboard adminview_dashboard)
        {
            this._DashboardView = adminview_dashboard;
            
        }
        public AdminPresenter(IAdmin_Profile adminview_Profile)
        {
      
            this._ProfileView = adminview_Profile;
        }
        public AdminPresenter(IAdmin_viewUser adminview_ViewUser)
        {

            this._ViewUserView = adminview_ViewUser;
        }


        public void AddUserClearFields()
        {
            // clear fields in adduser form
            _AddUserView.Role = "";
            _AddUserView.fullName = "";
            _AddUserView.dob = "";
            _AddUserView.email = "";
            _AddUserView.mobile = 0;
            _AddUserView.username = "";
            _AddUserView.address = "";
            _AddUserView.password = "";
            _AddUserView.OtherDetails = "";
        }





    }
}
