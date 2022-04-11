using MediatR;
using Meo.Pesquisa.Domain.Queries.Requests;
using Meo.Pesquisa.Domain.Queries.Responses;
using Meo.Pesquisa.Infra.Data.Sql;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meo.Pesquisa.Domain.Handlers
{
    public class FindFormByIdHandler : IRequestHandler<FindFormByIdRequest, FindFormByIdResponse>
    {
        private SurveyContext _surveyContext;
        public FindFormByIdHandler(SurveyContext surveyContext)
        {
            _surveyContext = surveyContext;
        }

        public Task<FindFormByIdResponse> Handle(FindFormByIdRequest request, CancellationToken cancellationToken)
        {
            var result = _surveyContext
                            .Form
                            .Include(a => a.Questions)
                            .ThenInclude(o => o.Options)
                            .FirstOrDefaultAsync(x => x.Id == request.Id)                            
                            .Result;

            var resultResponse = new FindFormByIdResponse
            {
                Id = result.Id,
                Name = result.Name,
                CreateDate = result.CreateDate,
                Description = result.Description
            };

            resultResponse.Questions = new List<Entities.Question>();
            resultResponse.Questions.AddRange(result.Questions);

            return Task.FromResult(resultResponse);
        }
    }
}
