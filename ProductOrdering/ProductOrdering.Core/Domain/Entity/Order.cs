using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductOrdering.Core.Domain.Audit;
using ProductOrdering.Core.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ProductOrdering.Core.Domain.Entity
{
    public class Order : FullAuditedEntity
    {
        [Required]
        public long UserId { get; set; }
        [Required]
        public OrderStatus OrderStatus { get; set; }
    }
}
