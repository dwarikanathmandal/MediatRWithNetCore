using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KE.ERP.Domain.Addresses
{
    public class District : EntityBase
    {
        public string DistrictName { get; set; }
        public string DistrictCode { get; set; }
        
        [ForeignKey("StateId")]
        public virtual State States {get;set;}
    }
}
