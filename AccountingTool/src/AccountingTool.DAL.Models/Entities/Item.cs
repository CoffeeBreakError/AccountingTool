using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class Item : BaseEntity
    {
        public Guid SeasonId { get; set; }
        public Season Season { get; set; }

        public ICollection<Clothes> Clothes { get; set; }
        public ICollection<Wear> Wears { get; set; }
        public ICollection<ItemAccounting> ItemAccountings { get; set; }
    }
}
