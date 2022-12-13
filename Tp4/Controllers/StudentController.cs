using Microsoft.AspNetCore.Mvc;
using Tp4.Data;

namespace Tp4.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepo studentRepo;

        public StudentController(IConfiguration configuration)
        {
            studentRepo = new StudentRepo(configuration);
        }

        public IActionResult Index()
        {
            return View(studentRepo.getAllStudent());
        }
        [Route("student/course/{course}")]
        public ViewResult Course(string course)
        {
            //Console.WriteLine(studentRepo.getCourse(course));
            return View(studentRepo.getCourse(course));
        }

        [Route("student/unique")]
        public ViewResult UniqueCours()
        {
         return View(studentRepo.getUniqueCourse());
          
        }
    }
    
}