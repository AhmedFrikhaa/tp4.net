using System.ComponentModel.DataAnnotations;

namespace Tp4.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string university { get; set; }
        public DateTime timestamp { get; set; }
        public string course { get; set; }
    }
}
