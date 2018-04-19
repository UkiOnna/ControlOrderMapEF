using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceApp
{
   public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CustomerCompany")]
        public int CustomerId { get; set; }
        public Company CustomerCompany { get; set; }

        [ForeignKey("ProviderCompany")]
        public int ProviderId { get; set; }
        public Company ProviderCompany { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
        [ForeignKey("Cargo")]
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ComingDate { get; set; }

    }
}
