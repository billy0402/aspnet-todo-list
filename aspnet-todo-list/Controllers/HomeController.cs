using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using aspnet_todo_list.Models;

namespace aspnet_todo_list.Controllers
{
    public class HomeController : Controller
    {
        dbToDoEntities db = new dbToDoEntities();

        // GET: Home
        public ActionResult Index()
        {
            var todos = db.tToDo.OrderByDescending(m => m.fDate).ToList();

            return View(todos);
        }
    }
}