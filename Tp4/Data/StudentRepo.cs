using Tp4.Models;

namespace Tp4.Data
{
    public class StudentRepo
    {
        private UniversityContext context=null;
        public StudentRepo() { }

        public StudentRepo(IConfiguration configuration) {
        context = UniversityContext.Instantiate_UniversityContext(configuration);
        }
        public IEnumerable <Student> getAllStudent() 
        { 
            return context.dbStudent.ToList();
        }
        public IEnumerable<Student> getCourse(string course){
            return context.dbStudent.Where(s => s.course.Equals(course));
                   
        }
       /* public IEnumerable<Student> getUniqueCourse()
        {
            return context.dbStudent.Where(s => s.course.);
        }*/
        
    }
}
