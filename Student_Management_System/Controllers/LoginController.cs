using Student_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management_System.Controllers
{
    public class LoginController : Controller
    {

        StudentManageEntities db = new StudentManageEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Index(User objcheck)
        {
            if(ModelState.IsValid)
            {
                using (StudentManageEntities db = new StudentManageEntities())
                {

                    var obj = db.Users.Where(a => a.Username.Equals(objcheck.Username) && a.Password.Equals(objcheck.Password)).FirstOrDefault();

                    if (obj != null)
                    {
                        Session["UserID"] = obj.UserID.ToString();
                        Session["Username"] = obj.Username.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "The Username or Password is Incorrect, Please try again");



                    }

                }
            }

           
            return View(objcheck);
        }


        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");

        }
    }
}