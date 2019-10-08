using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL
{
    public class Betygssgrad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BetygssgradID { get; set; }
        public int CourseID { get; set; }
        public Courses Courses { get; set; }
        public int Poäng { get; set; }
        public string Betyg { get; set; }
    }
}