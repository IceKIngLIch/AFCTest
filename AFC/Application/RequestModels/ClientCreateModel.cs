using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Application.RequestModels
{
    public class ClientCreateModel :IRequest
    {       
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
