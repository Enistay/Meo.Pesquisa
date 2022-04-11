using MediatR;
using Meo.Pesquisa.Domain.Commands.Requests;
using Meo.Pesquisa.Domain.Commands.Responses;
using Meo.Pesquisa.Domain.Entities;
using Meo.Pesquisa.Infra.Data.Sql;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meo.Pesquisa.Domain.Handlers
{
    public class CreateFormHandler : IRequestHandler<CreateFormRequest, CreateFormResponse> 
    {
     
        private SurveyContext _surveyContext;
        public CreateFormHandler(SurveyContext surveyContext)
        {
            _surveyContext = surveyContext;
        }

        public async Task<CreateFormResponse> Handle(CreateFormRequest request, CancellationToken cancellationToken)
        {
            Form form = new Form(request.Name, request.Description);
            form.Questions = new List<Question>();

            foreach (var item in request.Questions)
            {                
                form.Questions.Add(item);
            }
            _ = _surveyContext.Form.AddAsync(form);
            await this._surveyContext.SaveChangesAsync();

            var result = new CreateFormResponse
            {
                Id = form.Id,
                Name = form.Name,
                Description = form.Description,
                CreateDate = form.CreateDate,
                QuestionTotal = form.Questions.Count                
            };

            return await Task.FromResult(result);
        }
    }
}
