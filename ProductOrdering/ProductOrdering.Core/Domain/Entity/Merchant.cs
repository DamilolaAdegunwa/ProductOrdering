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
    public class Merchant : FullAuditedEntity
    {
        [Required]
        public string MerchantName { get; set; }
        [Required]
        public long AdminId { get; set; }
        [Required]
        public string CountryCode { get; set; }
    }
}
