using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace KE.ERP.Domain.Addresses
{
    public class State : EntityBase
    {
        public string StateName { get; set; }
        public string StateCode { get; set; }
        
        [ForeignKey("CountryId")]
        public virtual Country Countries {get;set;}
    }
}
