﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Entities
{
    public class User
    {
        public Guid? UserId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
    }
}
