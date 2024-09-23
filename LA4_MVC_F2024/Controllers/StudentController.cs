using LA4_MVC_F2024.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LA4_MVC_F2024.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository studentRepo = new StudentRepository();

        // GET: StudentController
        public ActionResult Index()
        {
            // display a list of students
            return View("Index", studentRepo.getAllStudents());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            // show info on one student
            return View("Details", studentRepo.getStudentById(id) );
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // Add the student to the repo using data from the view
                StudentModel newStudent = new StudentModel();
                // Retrieve form data using form collection
                newStudent.Id = Int32.Parse(collection["Id"]);
                newStudent.Name = collection["Name"];
                newStudent.Credits = Int32.Parse(collection["Credits"]);

                studentRepo.addStudent(newStudent);
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
