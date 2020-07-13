using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string? RejectionReason { get; set; }
        [StringLength(30)]
        [Required]
        public string DeliveryMode { get; set; }
        [StringLength(30)]
        [Required]
        public string Status { get; private set; } // no user mod- readonly?? where?
        public decimal Total { get; private set; } // mo user mod
        public int UserId { get; set; }
        public virtual User User { get; set; } // should be the user that is logged in


        public Request()
        {

        }
    }
}
