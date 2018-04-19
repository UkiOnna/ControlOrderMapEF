using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceApp
{
  public  class Marker
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        [ForeignKey("Info")]
        public int InfoId { get; set; }
        public Info Info { get; set; }
        

    }
}
