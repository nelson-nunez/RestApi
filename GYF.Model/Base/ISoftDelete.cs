﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYF.Model.Model
{
    public interface ISoftDelete
    {
        public DateTime? Deleted { get; set; }
    }
}
