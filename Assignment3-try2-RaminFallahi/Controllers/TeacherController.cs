using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;//added
using System.Web.Http;//added
using System.Diagnostics;
using Assignment3_try2_RaminFallahi.Models; //2-try this line as Comment to see where you get error //added
using System.Web.Mvc;

namespace Assignment3_try2_RaminFallahi.Controllers
{
    public class TeacherController : Controller
    {
        // GET: /Teacher/List?SearchKey=Simon
        public ActionResult List(string SearchKey)
        {
            // want to recieve search key and print it out

            Debug.WriteLine("The user is tring to search for "+ SearchKey);

            //I want to recieve all teachers in the system
            TeacherDataController MyController = new TeacherDataController();   
            IEnumerable<teacher> MyTeacher = MyController.ListTeachers(SearchKey);

            Debug.WriteLine("I have access " + MyTeacher.Count());
            return View(MyTeacher);
        }
        public ActionResult Show(int id)
        {
            TeacherDataController MyController = new TeacherDataController();
            teacher SelectedTeacher = MyController.FindTeacher(id);

            return View(SelectedTeacher);
        }
    }
}