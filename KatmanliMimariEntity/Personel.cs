﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariEntity
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}
