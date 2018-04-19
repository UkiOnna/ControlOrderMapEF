﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceApp
{
   public class Route
    {
        [Key]
        public int Id { get; set; }

        public virtual IEnumerable<Location> Location { get; set; }

    }
}
