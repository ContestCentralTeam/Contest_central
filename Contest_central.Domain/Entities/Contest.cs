﻿using Contest_central.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Domain.Entities;
public class Contest : BaseEntity
{
    public string Name { get; set; }
    public int Duration { get; set; }
    public Guid Creator_id { get; set; }
    List<Problem> problems { get; set; }
    List<User> users { get; set; }
}
