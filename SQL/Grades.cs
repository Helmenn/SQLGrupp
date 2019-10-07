using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL
{
    public class Grades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GradesID { get; set; }
        public string GradesName { get; set; }
        public int CourseID { get; set; }
        public Courses Courses { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}
