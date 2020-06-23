using System;
using System.ComponentModel.DataAnnotations.Schema;
using KE.ERP.Domain.Addresses;

namespace KE.ERP.Domain.Customers
{
    public class Customer : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerEmail { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Addresses { get; set; }

    }
}
