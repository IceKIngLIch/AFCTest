using AFC.Repository.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Application.RequestModels
{
    public class ClientReadModel :IRequest<Client>
    {
        public int Id { get; set; }
    }
}
