using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pharmacy_Managment_System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managment_System.Core.Tests
{
    [TestClass]
    public class AdminPresenterTests 
    {
        [TestMethod]
        public void AddUserClearFieldsTest()
        {
            // arrange
            StubView view = new StubView();
            var sut = new AdminPresenter(view);
            view.username = "sfsda";
            view.fullName = "sdfasddfas";
            view.dob = "21/12/2000";
            view.email = "";
            view.mobile = 07145283944;
            view.Role = "";


            //act
            sut.AddUserClearFields();

            //assert
            Assert.AreEqual("", view.username);
            Assert.AreEqual("", view.password);


        }

        public class StubView : IAdmin_AddUser
        {

            public string Role { get; set; }
            public String fullName { get; set; }
            public string dob { get; set; }
            public string email { get; set; }
            public Int64 mobile { get; set; }
            public string username { get; set; }
            public string address { get; set; }
            public string password { get; set; }
            public string OtherDetails { get; set; }
        }
    }
}