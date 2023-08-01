using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFC.Repository.Models;
using AFC.Repository;
using MediatR;
using AFC.Application.RequestModels;

namespace AFC.Application.RequestHandlers
{
    public class ClientReadHandler : IRequestHandler<ClientReadModel,Client>
    {
        private IRepository<Client> _accessor;
        public ClientReadHandler(IRepository<Client> accessor)
        {
            _accessor = accessor;
        }
        //вожможно кастыль с таск дилей не оч. как подругому?
         Task<Client> IRequestHandler<ClientReadModel, Client>.Handle(ClientReadModel request, CancellationToken cancellationToken)
        {
            //await Task.Delay(0);
            var client =_accessor.Get(request.Id) ;
            return Task.FromResult(client);
        }
    }
}
