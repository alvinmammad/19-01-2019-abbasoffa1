using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _190119.Models;
using _190119.ViewModels;

namespace _190119.Controllers
{
    public class StudentsController : Controller
    {

        private readonly Models.AppContext db = new Models.AppContext();

        public ActionResult Index()
        {
            ViewBag.PageTitle = "Tələbələr";

            VwStudents data = new VwStudents();

            data.Students = db.Students.Include("Group").ToList();

            data.Groups = db.Groups.ToList();

            return View(data);
        }
    }
}