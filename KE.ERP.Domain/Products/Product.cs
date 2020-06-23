using System;
using System.ComponentModel.DataAnnotations.Schema;
using KE.ERP.Domain.Touchpoints;

namespace KE.ERP.Domain.Products
{
    public class Product : EntityBase
    {
        public string ProductName { get; set; }
        
        [ForeignKey("CategoryId")]
        public ProductCategory ProductCategory { get; set; }
        [ForeignKey("TouchpointId")]
        public Touchpoint Touchpoint { get; set; }

    }
}
