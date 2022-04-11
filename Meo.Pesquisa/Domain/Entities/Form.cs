using Meo.Pesquisa.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Meo.Pesquisa.Domain.Entities
{
    public class Form 
    {
        public Form(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            CreateDate = DateTime.Now;
            Enable = true;
        }
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateDate { get; private set; }
        public bool Enable { get; private set; }
        public ICollection<Question> Questions { get; set; }
    }
}
