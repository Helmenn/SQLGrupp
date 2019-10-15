using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SQL
{
    public class Fråga
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int FrågaID { get; set; }

        public string FrågText { get; set; }

        public int ProvID { get; set; }
        public Prov Prov { get; set; }

        public ICollection<Svaralt> Svaralt { get; set; }
    }
}