using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using KE.ERP.Api.Features.Touchpoints.Models;

namespace KE.ERP.Api.Features.Touchpoints.GetAll
{
    public class RequestCommand : IRequest<IList<TouchpointModel>>
    {
        [FromQuery]
        public int TouchpointId { get; set; }
    }
}
