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
    public class Payment : FullAuditedEntity
    {
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public string BatchReference { get; set; }
        public string InvoiceUrl { get; set; }
        public string ReceiptrUrl { get; set; }
    }
}
