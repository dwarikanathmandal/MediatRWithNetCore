using System;

namespace KE.ERP.Domain.Addresses
{
    public class Country : EntityBase
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}
