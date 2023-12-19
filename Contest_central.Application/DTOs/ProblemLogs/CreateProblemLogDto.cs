using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.DTOs.ProblemLogs
{
    public class CreateProblemLogDto
    {
        public Guid Contest_id { get; set; }
        public Guid User_id { get; set; }
        public bool Is_solved { get; set; }
        public int Problem_id { get; set; }
    }
}
