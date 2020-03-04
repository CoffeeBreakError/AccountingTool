using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingTool.DAL.Models.Entities
{
    public class ClothesSize : BaseEntity
    {
        public string Size { get; set; }

        public ICollection<Clothes> Clothes { get; set; }
    }
}
