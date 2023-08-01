using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFC.Application.RequestModels;
using AFC.Repository.Models;
using AFC.Repository;
using MediatR;
namespace AFC.Application.RequestHandlers
{
    public class ClientReadAllHandler : IRequestHandler<ClientReadAllModel,IEnumerable<Client>>
    {
        private IRepository<Client> _accessor;
        public ClientReadAllHandler(IRepository<Client> accessor)
        {
            _accessor = accessor;
        }  
        async Task<IEnumerable<Client>> IRequestHandler<ClientReadAllModel, IEnumerable<Client>>.Handle(ClientReadAllModel request, CancellationToken cancellationToken)
        {
            await Task.Delay(0);
            var allClient = _accessor.GetList();
            return allClient;
        }
    }
}
