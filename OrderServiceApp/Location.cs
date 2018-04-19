using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceApp
{
  public  class Location
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

    }
}
