using Meo.Pesquisa.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Meo.Pesquisa.Domain.Entities
{
    public class Question 
    {
        public Question(string description, string inputType, int position)
        {          
            Id = Guid.NewGuid();
            Description = description;
            InputType = inputType;
            Enable = true;
            Position = position;
        }

        public Guid Id { get; set; }
        public Guid FormId { get; set; }       
        public string Description { get; set; }
        public string InputType { get; set; }
        public ICollection<OptionQuestion> Options { get; set; }
        public ICollection<Answer> Answer { get; set; }
        public bool Enable { get; set; }
        public int Position { get; set; }
    }
}
