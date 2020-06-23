using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace KE.ERP.Domain.Addresses
{
    public class Address : EntityBase
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        
        [ForeignKey("CountryId")]
        public virtual Country Countries { get; set; }
        
        [ForeignKey("StateId")]
        public virtual State States { get; set; }
        
        [ForeignKey("DistrictId")]
        public virtual District Districts { get; set; }
    }
}
