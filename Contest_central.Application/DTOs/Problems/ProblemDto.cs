using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contest_central.Application.DTOs.Problems
{
    public class ProblemDto
    {
        public Guid ProblemId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string University { get; set; }
        public string Url { get; set; }
    }
}