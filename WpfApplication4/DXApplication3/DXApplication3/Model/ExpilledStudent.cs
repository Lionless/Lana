﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication3.Model
{
    class ExpilledStudent : BaseModel
    {   public ExpilledStudent() { }
        public string IsExpilled { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
        public string MobileNumber { get; set; }
    }
}
