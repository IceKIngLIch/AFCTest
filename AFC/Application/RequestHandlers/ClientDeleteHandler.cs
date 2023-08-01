using AFC.Application.RequestModels;
using AFC.Repository.Models;
using AFC.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Application.RequestHandlers
{
    public class ClientDeleteHandler : IRequestHandler<ClientDeleteModel>
    {
        private IRepository<Client> _accessor;
        public ClientDeleteHandler(IRepository<Client> accessor)
        {
            _accessor = accessor;
        }
        public Task Handle(ClientDeleteModel request, CancellationToken cancellationToken)
        {
            _accessor.Delete(request.Id);
            _accessor.Save();
            return Task.CompletedTask;
        }
    }
}
