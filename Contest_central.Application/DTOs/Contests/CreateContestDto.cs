using Contest_central.Application.DTOs.Contests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.DTOs.Contest;
public class CreateContestDto : ContestDto
{
    public Guid Creator_id { get; set; }
}
