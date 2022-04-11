using System;

namespace Meo.Pesquisa.Domain.Commands.Responses
{
    public class CreateFormResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int QuestionTotal { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
