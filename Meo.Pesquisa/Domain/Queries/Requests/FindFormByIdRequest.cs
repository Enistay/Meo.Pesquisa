using MediatR;
using Meo.Pesquisa.Domain.Queries.Responses;
using System;

namespace Meo.Pesquisa.Domain.Queries.Requests
{
    public class FindFormByIdRequest : IRequest<FindFormByIdResponse>
    {
        public Guid Id { get; set; }
    }
}
