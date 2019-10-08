using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace SQL
{
    public class Provresultat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ProvresultatID { get; set; }

        public int Poäng { get; set; }
      

        public int ProvsvarID { get; set; }
        public Provsvar Provsvar { get; set; }
    }

}

