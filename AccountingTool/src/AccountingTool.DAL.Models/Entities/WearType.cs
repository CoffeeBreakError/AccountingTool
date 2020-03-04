using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class WearType : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Wear> Wears { get; set; }
    }
}
