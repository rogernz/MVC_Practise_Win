using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCListBoxTrans.Controllers;

namespace MVCListBoxTrans.Controllers
{
    [TestClass]
    public class JsonDemoControllerTest
    {
        [TestMethod]
        public void WelcomeNote()
        {
            JsonDemoController controller = new JsonDemoController();

            JsonResult result = (JsonResult)controller.WelcomeNote();
            string msg = Convert.ToString(result.Data);
            // Assert  
            Assert.AreEqual("Welcome to the User", msg);
        }
    }
}