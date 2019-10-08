using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL
{
    public class StudentCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentCourseID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Courses Course { get; set; }
    }
}
