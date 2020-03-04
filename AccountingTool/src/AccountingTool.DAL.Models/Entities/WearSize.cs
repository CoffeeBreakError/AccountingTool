using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class WearSize : BaseEntity
    {
        public string Size { get; set; }
        public string Height { get; set; }
        
        public ICollection<Wear> Wears { get; set; }
    }
}
