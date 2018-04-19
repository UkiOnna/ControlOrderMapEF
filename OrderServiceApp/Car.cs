using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceApp
{
  public  class Car
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        [ForeignKey("Type")]
        public int TypeId { get; set; }
        public CarType Type { get; set; }
        public string Color { get; set; }
    }
}
