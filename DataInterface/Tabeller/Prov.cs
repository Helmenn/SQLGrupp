using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace SQL
{
    public class Prov
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ProvID { get; set; }

        public int Andel { get; set; }

        public int CourseId {get; set;}

        public Courses Courses { get; set; }

        public ICollection<Fråga> Frågor { get; set; }

        public ICollection<Provsvar> Provsvar { get; set; }

    }
}
