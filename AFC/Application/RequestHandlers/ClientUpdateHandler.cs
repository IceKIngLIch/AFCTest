using AFC.Application.RequestModels;
using AFC.Repository.Models;
using AFC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace AFC.Application.RequestHandlers
{
    public class ClientUpdateHandler : IRequestHandler<ClientUpdateModel>
    {
        private IRepository<Client> _accessor;
        public ClientUpdateHandler(IRepository<Client> accessor)
        {
            _accessor = accessor;
        }

        public Task Handle(ClientUpdateModel request, CancellationToken cancellationToken)
        {
            var client = _accessor.Get(request.Id);
            if (client == null)
                return Task.CompletedTask;            
            client.FullName = request.FullName;
            client.Adress = request.Adress;
            client.PhoneNumber = request.PhoneNumber;
            client.EmployeeId = request.EmployerId; 
            _accessor.Update(client);            
            _accessor.Save();
            return Task.CompletedTask;
        }
    }
}

