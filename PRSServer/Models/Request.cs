using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRSServer.Models
{
    public class Request
    {
        public int Id { get; set; }
        [StringLength(80)]
        [Required]
        public string Description { get; set; }
        [StringLength(80)]
        [Required]
        public string Justification { get; set; }
        [StringLength(80)]
        public string RejectionReason { get; set; }
        [StringLength(30)]
        [Required]
        public string DeliveryMode { get; set; }
        [StringLength(30)]
        [Required]
        public string Status { get; set; }
        [Column(TypeName = "decimal(16,2)")]
        public decimal Total { get; set; } 
        public int UserId { get; set; }
        public virtual User User { get; set; } // should be the user that is logged in

        public virtual IEnumerable<RequestLine> RequestLines { get; set; }

        public Request()
        {

        }
    }
}
