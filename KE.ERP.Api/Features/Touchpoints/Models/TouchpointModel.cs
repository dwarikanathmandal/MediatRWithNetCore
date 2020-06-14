using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;

namespace KE.ERP.Api.Features.Touchpoints.Models
{
    public class TouchpointModel
    {
        public int TouchpointId { get; set; }
        public string ToucpointName { get; set; }
    }
}
