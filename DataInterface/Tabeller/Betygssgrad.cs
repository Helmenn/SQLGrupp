using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SQL
{
    public class Betygssgrad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BetygssgradID { get; set; }

        public int CourseID { get; set; }
        public Courses Couses { get; set; }

    }
}