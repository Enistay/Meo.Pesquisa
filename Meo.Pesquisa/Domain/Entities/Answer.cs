using Meo.Pesquisa.Domain.Interfaces.Repository;
using System;

namespace Meo.Pesquisa.Domain.Entities
{
    public class Answer 
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid QuestionId { get; set; }
        public int? OptionId { get; set; }
        public virtual Question Question { get; set; }
        public virtual OptionQuestion Option { get; set; }
    }
}
