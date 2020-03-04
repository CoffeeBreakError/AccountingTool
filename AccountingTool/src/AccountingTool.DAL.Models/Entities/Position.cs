﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
