using MediatR;
using Meo.Pesquisa.Domain.Commands.Requests;
using Meo.Pesquisa.Domain.Commands.Responses;
using Meo.Pesquisa.Domain.Entities;
using Meo.Pesquisa.Infra.Data.Sql;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Meo.Pesquisa.Domain.Handlers
{
    public class CreateAnswerHandler : IRequestHandler<CreateAnswerRequest, CreateAnswerResponse>
    {
        private SurveyContext _surveyContext;
        public CreateAnswerHandler(SurveyContext surveyContext)
        {
            _surveyContext = surveyContext;
        }
        public async Task<CreateAnswerResponse> Handle(CreateAnswerRequest request, CancellationToken cancellationToken)
        {
            List<Answer> answers = new List<Answer>();

            foreach (var item in request.AnswersRequest)
            {
                answers.Add(new Answer { OptionId = item.OptionId, QuestionId = item.QuestionId, Description = item.Description });
            }
            _ = _surveyContext.Answer.AddRangeAsync(answers);
            await this._surveyContext.SaveChangesAsync();

            var result = new CreateAnswerResponse { AnswerId = new List<System.Guid>() };
            result.AnswerId.AddRange(answers.FindAll(a => a.Id != null).Select(a => a.Id).ToList());

            return await Task.FromResult(result);
        }
    }
}
