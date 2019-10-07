using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace SQL
{
    public class Svar

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SvarID { get; set; }

        public int provsvarID { get; set; }
        public Provsvar Provsvar { get; set; }

        public int FrågaID { get; set; }
        public Fråga Fråga { get; set; }

        public int SvaraltID { get; set; }
        public Svaralt svaralt { get; set; }
    }
}
