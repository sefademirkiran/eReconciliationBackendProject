﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public  class OperationClaim : IEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
