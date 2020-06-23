using System;

namespace KE.ERP.Domain.Users
{
    public class User : EntityBase
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }

    }
}
