﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contest_central.Application.DTOs.Users
{
    public class CreateUserDto : IUserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid Group_id { get; set; }
        public string Role { get; set; }
        public string ProfilePic { get; set; }
    }
}
