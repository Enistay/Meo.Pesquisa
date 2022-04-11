using Meo.Pesquisa.Domain.Commands.Requests;
using Meo.Pesquisa.Domain.Commands.Responses;

namespace Meo.Pesquisa.Domain.Handlers.Interfaces
{
    public interface ICreateFormHandler
    {
        CreateFormResponse Handle(CreateFormRequest command);
    }
}
