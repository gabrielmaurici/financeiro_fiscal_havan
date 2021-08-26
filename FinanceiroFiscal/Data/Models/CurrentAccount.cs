﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CurrentAccount : BaseModel
    {
        public int AccountNumber  { get; set; }
        public decimal Balance { get; set; }
        public decimal Limit { get; set; }
        public Extract Extract { get; set; }
    }
}
