﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBankApp.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}
