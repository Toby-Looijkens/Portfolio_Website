﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Role
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; } = null!;
    }
}
