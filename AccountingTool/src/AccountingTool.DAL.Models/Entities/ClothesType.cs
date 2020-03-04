using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class ClothesType : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Clothes> Clothes { get; set; }
    }
}
