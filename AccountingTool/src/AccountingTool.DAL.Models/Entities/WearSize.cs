﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class WearSize : BaseEntity
    {
        public string Size { get; set; }

        public ICollection<WearProportion> WearProportions { get; set; }
    }
}
