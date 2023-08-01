using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFC.Repository.Models;
using MediatR;

namespace AFC.Application.RequestModels
{
    public class ClientReadAllModel :IRequest<IEnumerable<Client>>
    {

    }
}
