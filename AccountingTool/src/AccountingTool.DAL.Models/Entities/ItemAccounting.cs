using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class ItemAccounting : BaseEntity
    {
        public DateTime DateOfIssue { get; set; }

        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
