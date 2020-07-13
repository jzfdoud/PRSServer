using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRSServer.Models
{
    public class Product
    {
        public int Id { get; set; }
        [StringLength(30)]
        [Required]
        public string PartNbr { get; set; } //unique
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Price { get; set; }
        [StringLength(15)]
        [Required]
        public string Unit { get; set; }
        [StringLength(225)]
        [Required]
        public string? PhotoPath { get; set; } // what is green line for under ?

        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }


        public Product()
        {

        }
    }
}
