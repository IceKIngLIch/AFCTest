using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Application.RequestModels
{
    public class ClientUpdateModel :IRequest
    {
        public int Id { get; set; }
        public int EmployerId { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
