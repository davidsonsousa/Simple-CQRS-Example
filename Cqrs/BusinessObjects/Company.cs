﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs.BusinessObjects
{
    /// <summary>
    /// Represents the Company table on the DB
    /// </summary>
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}