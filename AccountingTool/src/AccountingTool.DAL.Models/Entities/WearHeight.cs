using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class WearHeight : BaseEntity
    {
        public string Height { get; set; }

        public ICollection<WearProportion> WearProportions { get; set; }
    }
}
