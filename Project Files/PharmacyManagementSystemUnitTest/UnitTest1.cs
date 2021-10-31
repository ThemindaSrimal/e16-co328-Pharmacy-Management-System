using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pharmacy_Managment_System.Core;
using System;

namespace PharmacyManagementSystemUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ResetTextBoxField()
        {
            // Login screen reset text fields
            // arange
            StubView view = new StubView();
            var sut = new LoginPresenter(view);

            // act
            view.username = "asdasd";
            view.password = "sdasd";
            sut.ResetTextBox();

            // assert
            Assert.AreEqual("", view.username);
            Assert.AreEqual("", view.password);

        }

        public class StubView : ILoginView
        {
            public string username { get ; set; }
            public string password { get ; set; }
        }
    }
}
