using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week6Capstone.Models;

namespace Week6Capstone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LogUser logU) 
        {
            int index = 0;
            if (Users.IsUser(logU.UserName, out index))
            {
                if (Users.IsPass(logU.Password, index))
                {
                    Session["Error"] = "";
                    Session["User"] = Users.users[index];
                }
                else
                {
                    Session["Error"] = "Wrong password buddy";
                }
            }
            else
            {
                Session["Error"] = "I couldn't find that username";
                RedirectToAction("Index");
            }
            return RedirectToAction("Index");
            //return View();
        }


        public ActionResult Logout()
        {
            return View();
        }

        public ActionResult Tasks()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult RegisterUser(User u)
        {
            Users.users.Add(u);
            return View();
        }
        public ActionResult DeleteTask(int @i)
        {
            TaskList.tasks.RemoveAt(i);
            return RedirectToAction("Tasks");
        }

        public ActionResult AddTask(task t)
        {
            TaskList.tasks.Add(t);
            return RedirectToAction("Tasks");
        }
    }
}