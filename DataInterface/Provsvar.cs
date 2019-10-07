using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SQL
{
    public class Provsvar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ProvsvarID { get; set; }

        public int ProvID {get; set;}
        public Prov Prov { get; set; }
        public int studentID { get; set; }
        public Student Student { get; set; }

    }
}