using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Repository.Models
{
    public class Schedule //рассписание
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public int HallId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan LessonDuration { get; set; }
    }
}
