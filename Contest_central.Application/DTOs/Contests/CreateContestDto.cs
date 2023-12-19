using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.DTOs.Contest;
public class CreateContestDto
{
    public Guid Id { get; set; }
    public DateTime DateTime { get; set; } = DateTime.Now;
    public string Name { get; set; }
    public int Duration { get; set; }
    public Guid Creator_id { get; set; }
}
