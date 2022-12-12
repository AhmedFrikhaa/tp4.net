using Microsoft.AspNetCore.Mvc;
using Tp4.Data;

namespace Tp4.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult Index(StudentRepo studentRepo)
        {
            return View(studentRepo.getAllStudent());
        }
        [Route("student/course/{course}")]
        public ViewResult Course(string course , StudentRepo studentRepo)
        {
            return View(studentRepo.getCourse(course));
        }
    }
}
