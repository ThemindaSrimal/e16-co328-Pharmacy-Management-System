using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managment_System.Core
{

    // interfaces for Adminstrator
    public interface IAdminView
    {
        
    }

    public interface IAdmin_AddUser
    {
        
        string Role { get; set; }
        String fullName { get; set; }
        string dob { get; set; }
        string email { get; set; }
        Int64 mobile { get; set; }
        string username { get; set; }
        string address { get; set; }
        string password { get; set; }
        string OtherDetails { get; set; }
    }

    public interface IAdmin_Dashboard
    {

    }

    public interface IAdmin_Profile
    {

    }

    public interface IAdmin_viewUser
    {

    }
}
