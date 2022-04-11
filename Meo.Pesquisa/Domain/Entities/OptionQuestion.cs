
using Meo.Pesquisa.Domain.Interfaces.Repository;
using System;

namespace Meo.Pesquisa.Domain.Entities
{
    public class OptionQuestion 
    {
        public OptionQuestion(string description)
        {
            Enable = true;
            Description = description;
        }
        public int Id { get; set; }
        public Guid QuestionId { get; set; }
        public string Description { get; set; }
        public Boolean Enable { get; set; }
    }
}
