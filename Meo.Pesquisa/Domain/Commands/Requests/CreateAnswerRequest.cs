using MediatR;
using Meo.Pesquisa.Domain.Commands.Responses;
using System;
using System.Collections.Generic;

namespace Meo.Pesquisa.Domain.Commands.Requests
{
    public class CreateAnswerRequest : IRequest<CreateAnswerResponse>
    {
        public List<AnswerRequest> AnswersRequest { get; set; }  
        
    }

    public class AnswerRequest 
    {
        public string Description { get; set; }
        public Guid QuestionId { get; set; }
        public int? OptionId { get; set; }
    }
}
