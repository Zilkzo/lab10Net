using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string id)
        {
            if (Database.shared?.students != null)
                foreach (var student in Database.shared.students)
                {
                    string new_id = "";
                    //Adding first 3 letters of Name
                    new_id = Convert.ToString(student.Name[0]);
                    new_id = new_id + Convert.ToString(student.Name[1]);
                    new_id = new_id + Convert.ToString(student.Name[2]);

                    //Adding first and last letters of speciality
                    new_id = new_id + student.Group[0];
                    new_id = new_id + student.Group[student.Group.Length - 6];

                   
                    int day = Int32.Parse(Convert.ToString(student.Birthdate[0])) + Int32.Parse(Convert.ToString(student.Birthdate[1]));
                    int month = Int32.Parse(Convert.ToString(student.Birthdate[3])) + Int32.Parse(Convert.ToString(student.Birthdate[4]));
                    int year = Int32.Parse(Convert.ToString(student.Birthdate[6])) + Int32.Parse(Convert.ToString(student.Birthdate[7])) + Int32.Parse(Convert.ToString(student.Birthdate[8])) + Int32.Parse(Convert.ToString(student.Birthdate[9]));

                    new_id = new_id + Convert.ToString(day);
                    new_id = new_id + Convert.ToString(month);
                    new_id = new_id + Convert.ToString(year);

                    new_id = new_id + student.Group[student.Group.Length - 3];
                    new_id = new_id + student.Group[student.Group.Length - 2];
                    new_id = new_id + student.Group[student.Group.Length - 1];
                   
                   
                    if (new_id.Equals(id))
                    {
                        return Content("You found your student!\n" + student.Name + " was born on " + student.Birthdate + " and studies at " + student.Group);
                    }
                }
            return Content("not found");
        }
    }
}