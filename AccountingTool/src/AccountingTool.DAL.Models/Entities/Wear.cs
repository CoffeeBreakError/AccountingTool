using System;

namespace AccountingTool.DAL.Models.Entities
{
    public class Wear : BaseEntity
    {
        public Guid WearTypeId { get; set; }
        public WearType WearType { get; set; }

        public Guid ItemId { get; set; }
        public Item Item { get; set; }

        public Guid WearSizeId { get; set; }
        public WearSize WearSize { get; set; }
    }
}
