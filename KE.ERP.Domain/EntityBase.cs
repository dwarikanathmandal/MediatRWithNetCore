using System;
using System.ComponentModel.DataAnnotations;

namespace KE.ERP.Domain
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; } 
        [Required]     
        public bool IsDeleted { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public System.Nullable<DateTime> ModifyDate { get; set; }
    }
}
