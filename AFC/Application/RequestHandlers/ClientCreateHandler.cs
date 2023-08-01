using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFC.Repository;
using AFC.Repository.Models;
using AFC.Application.RequestModels;

namespace AFC.Application.RequestHandlers
{
    public class ClientCreateHandler : IRequestHandler<ClientCreateModel>
    {
        private IRepository<Client> _accessor;
        public ClientCreateHandler(IRepository<Client> accessor) 
        {
            _accessor = accessor;
        }
        Task IRequestHandler<ClientCreateModel>.Handle(ClientCreateModel request, CancellationToken cancellationToken)
        {
            Client client = new Client();
            client.FullName = request.FullName;
            client.Adress = request.Adress;
            client.PhoneNumber = request.PhoneNumber;
            client.EmployeeId = request.EmployeeId; 
            _accessor.Create(client);
            _accessor.Save();
            return Task.CompletedTask;
        }
    }
}
