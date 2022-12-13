using Tp4.Models;

namespace Tp4.Data
{
    public class StudentRepo
    {
        private UniversityContext context;
        public StudentRepo() { }

        public StudentRepo(IConfiguration configuration) {
            context = UniversityContext.Instantiate_UniversityContext(configuration);
        }
        public IEnumerable <Student> getAllStudent() 
        {
            Console.WriteLine(context.Student);

            return context.Student.ToList();
        }
        public IEnumerable<Student> getCourse(string course){
            return context.Student.Where(s => s.course.Equals(course));
                   
        }
        public IEnumerable<String> getUniqueCourse()
        {
            return context.Student.Select(s => s.course).Distinct();
        }
        
    }
}
