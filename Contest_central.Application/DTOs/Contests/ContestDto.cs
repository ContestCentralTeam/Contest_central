using Contest_central.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.DTOs.Contests
{
    public class ContestDto
    {
        public DateTime DateTime { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public Guid Creator_id { get; set; }
        List<Problem> problems { get; set; }
        List<User> users { get; set; }
    }
}
