using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MediatR;
using KE.ERP.Api.Features.Touchpoints.Models;
using System.Threading;
using KE.ERP.Api.Persistence;
using KE.ERP.Domain;
using Microsoft.EntityFrameworkCore;

namespace KE.ERP.Api.Features.Touchpoints.GetAll
{
    public class Handler : IRequestHandler<RequestCommand, IList<TouchpointModel>>
    {
        private readonly ProductDBContext _dbContext;
        public Handler(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int TouchpointId { get; set; }

        public async Task<IList<TouchpointModel>> Handle(RequestCommand request, CancellationToken cancellationToken)
        {
            return await _dbContext.Touchpoints.Select(tp => new TouchpointModel
            {
                TouchpointId = tp.TouchpointId,
                ToucpointName = tp.TouchpointName,
            }).ToListAsync();
        }
    }
}
