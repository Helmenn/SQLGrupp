using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace SQL
{
    public class RättatSvar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int RättatSvarID { get; set; }
        public int SvarID { get; set; }
        public Svar Svar { get; set; }
        public int SvaraltID {get; set;}
        public Svaralt Svaralt { get; set; }

        public bool Rätt { get; set; }
           



    }
}
