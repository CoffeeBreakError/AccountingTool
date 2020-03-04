using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class WearProportion : BaseEntity
    {
        public Guid WearSizeId { get; set; }
        public WearSize WearSize { get; set; }

        public Guid WearHeightId { get; set; }
        public WearHeight WearHeight { get; set; }
        
        public ICollection<Wear> Wears { get; set; }
    }
}
