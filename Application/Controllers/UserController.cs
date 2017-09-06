using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Models;

namespace Application.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            ViewBag.Message = "Your Registration page.";
            user userModel = new user();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(user userModel)
        {
            using (DbModels dbModel = new DbModels())
            {
                if (dbModel.users.Any(x => x.userName == userModel.userName))
                {
                    ViewBag.DuplicateMessage = "User Name is Exists !";
                    return View("AddOrEdit", userModel);
                }  
                dbModel.users.Add(userModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration is success";
            return View("AddOrEdit", new user());
        }
    }
}