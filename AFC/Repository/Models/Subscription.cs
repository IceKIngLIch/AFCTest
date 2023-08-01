using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Repository.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartSubscribe { get; set; }
        public DateTime EndSubsribe { get; set; }
        public decimal Price { get; set; }
    }
}
