using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using MVCListBoxTrans.Models;

namespace MVCListBoxTrans.Controllers
{
    public class JsonDemoController : Controller
    {

        public ActionResult WelcomeNote()
        {
            bool isAdmin = false;
            //TODO: Check the user if it is admin or normal user, (true-Admin, false- Normal user)  
            string output = isAdmin ? "Welcome to the Admin User" : "Welcome to the User";


            return Json(output, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Sample()
        {
            return View();
        }

        [HttpPost]
        public JsonResult UpdateUsersDetail(string usersJson)
        {
            var js = new JavaScriptSerializer();
            PersonModel[] user = js.Deserialize<PersonModel[]>(usersJson);

            //TODO: user now contains the details, you can do required operations  
            return Json("User Details are updated");
        }
        public JsonResult GetUsersHugeList()
        {
            var users = GetUsersHugeData();
            var result = Json(users, JsonRequestBehavior.AllowGet);
            result.MaxJsonLength = int.MaxValue;
            return result;


        }
        /// <summary>  
        /// Override the JSON Result with Max integer JSON lenght  
        /// </summary>  
        /// <param name="data">Data</param>  
        /// <param name="contentType">Content Type</param>  
        /// <param name="contentEncoding">Content Encoding</param>  
        /// <param name="behavior">Behavior</param>  
        /// <returns>As JsonResult</returns>  


        private List<PersonModel> GetUsersHugeData()
        {
            var usersList = new List<PersonModel>();
            PersonModel user;
            for (int i = 1; i < 51000; i++)
            {
                user = new PersonModel
                {
                    PersonId = i,
                    Name = "User-" + i,
                    City = "Company-" + i
                };
                usersList.Add(user);
            }

            return usersList;
        }
        private List<PersonModel> GetUsers()
        {
            var usersList = new List<PersonModel>
            {
                new PersonModel
                {
                     PersonId = 1,
                     Name = "Ram",
                     City = "Mindfire Solutions"
                },
                new PersonModel
                {
                    PersonId = 1,
                    Name = "chand",
                    City = "Mindfire Solutions"
                },
                new PersonModel
                {
                    PersonId = 1,
                    Name = "Abc",
                    City = "Abc Solutions"
                }
            };

            return usersList;
        }
    }
}