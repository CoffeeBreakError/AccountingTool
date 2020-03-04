using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class Clothes : BaseEntity
    {
        public Guid ClothesTypeId { get; set; }
        public ClothesType ClothesType { get; set; }

        public Guid ClothesSizeId { get; set; }
        public ClothesSize ClothesSize { get; set; }

        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
