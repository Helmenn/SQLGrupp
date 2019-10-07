﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SQL
{
    public class Svaralt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SvaraltID { get; set; }

        public string SvaraltText { get; set; }
        public string Rätt { get; set; }
    }

}