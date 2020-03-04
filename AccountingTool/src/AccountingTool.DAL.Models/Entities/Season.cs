using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class Season : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
