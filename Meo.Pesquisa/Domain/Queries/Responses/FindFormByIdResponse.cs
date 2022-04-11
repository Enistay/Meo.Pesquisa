using Meo.Pesquisa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meo.Pesquisa.Domain.Queries.Responses
{
    public class FindFormByIdResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Question> Questions { get; set; }

    }
}
