using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductOrdering.Core.Domain.Audit;
using ProductOrdering.Core.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ProductOrdering.Core.Domain.Entity
{
    public class User : IdentityUser<long> //: FullAuditedEntity
    {

        public string FullName { get; set; }
        public GenderType GenderType { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string CountryCode { get; set; }
    }
}
