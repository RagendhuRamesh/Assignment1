using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
    {
        new Course{CId = 1,CName = "Introduction to C#",CFee = 99.99m,Technology = "C#",CStartDate = DateTime.Now.AddDays(7),CEndDate = DateTime.Now.AddDays(30) },
        new Course{CId = 2,CName = "Advanced C# Programming",CFee = 149.99m,Technology = "C#",CStartDate = DateTime.Now.AddDays(15),CEndDate = DateTime.Now.AddDays(45)},
        new Course{CId = 3,CName = "Web Development with ASP.NET",CFee = 129.99m,Technology = "ASP.NET",CStartDate = DateTime.Now.AddDays(10),CEndDate = DateTime.Now.AddDays(35)},
        new Course{CId = 4,CName = "Database Design with Entity Framework",CFee = 139.99m,Technology = "Entity Framework",CStartDate = DateTime.Now.AddDays(20),CEndDate = DateTime.Now.AddDays(50)},
        new Course{CId = 5,CName = "Mobile App Development with Xamarin",CFee = 159.99m,Technology = "Xamarin",CStartDate = DateTime.Now.AddDays(25),CEndDate = DateTime.Now.AddDays(60)},
        new Course{CId = 6,CName = "Software Testing Techniques",CFee = 119.99m,Technology = "Software Testing",CStartDate = DateTime.Now.AddDays(12),CEndDate = DateTime.Now.AddDays(40)},
    };


        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }

        [HttpPost]
        public ActionResult Create(Course c)
        {
            if (ModelState.IsValid)
            {
                courses.Add(c);
                return RedirectToAction("Index");
            }
            return View(c);

        }

    }
}
