using Meo.Pesquisa.Domain.Queries.Requests;
using Meo.Pesquisa.Domain.Queries.Responses;

namespace Meo.Pesquisa.Domain.Handlers.Interfaces
{
    public interface IFindFormByIdHandler
    {
        FindFormByIdResponse Handle(FindFormByIdRequest command);
    }
}
