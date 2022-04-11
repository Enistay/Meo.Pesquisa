using MediatR;
using Meo.Pesquisa.Domain.Commands.Responses;
using Meo.Pesquisa.Domain.Entities;
using System.Collections.Generic;

namespace Meo.Pesquisa.Domain.Commands.Requests
{
    public class CreateFormRequest : IRequest<CreateFormResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Question> Questions { get; set; }
    }
}
